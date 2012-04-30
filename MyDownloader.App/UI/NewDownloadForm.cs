using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Core.Common;
using MyDownloader.Core;
using MyDownloader.Core.UI;
using MyDownloader.Extension.Protocols;
using ICSharpCode.SharpZipLib.Zip;
using MyDownloader.Extension.Zip;
using System.IO;
using System.Threading;

namespace MyDownloader.App.UI
{
    public partial class NewDownloadForm : Form
    {
        Thread zipReaderThread;

        public NewDownloadForm()
        {
            InitializeComponent();

            locationMain.UrlChanged += new EventHandler(locationMain_UrlChanged);

            ShowZIPMode(false);
        }

        void locationMain_UrlChanged(object sender, EventArgs e)
        {
            try
            {
                Uri u = new Uri(locationMain.ResourceLocation.URL);
                txtFilename.Text = u.Segments[u.Segments.Length - 1];
            }
            catch
            {
                txtFilename.Text = string.Empty;
            }
        }

        public ResourceLocation DownloadLocation
        {
            get
            {
                return locationMain.ResourceLocation;
            }
            set
            {
                locationMain.ResourceLocation = value;
            }
        }

        public ResourceLocation[] Mirrors
        {
            get
            {
                MyDownloader.Core.ResourceLocation[] mirrors = new MyDownloader.Core.ResourceLocation[lvwLocations.Items.Count];

                for (int i = 0; i < lvwLocations.Items.Count; i++)
                {
                    ListViewItem item = lvwLocations.Items[i];
                    mirrors[i] = MyDownloader.Core.ResourceLocation.FromURL(
                            item.SubItems[0].Text, 
                            BoolFormatter.FromString(item.SubItems[1].Text), 
                            item.SubItems[2].Text, 
                            item.SubItems[3].Text);
                }

                return mirrors;
            }
        }

        public string LocalFile
        {
            get
            {
                return PathHelper.GetWithBackslash(folderBrowser1.Folder) + txtFilename.Text;
            }
        }

        public int Segments
        {
            get
            {
                return (int)numSegments.Value;
            }
        }

        public bool StartNow
        {
            get
            {
                return chkStartNow.Checked;
            }
        }

        private void lvwLocations_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            bool hasSelected = lvwLocations.SelectedItems.Count > 0;
            btnRemove.Enabled = hasSelected;
            if (hasSelected)
            {
                ListViewItem item = lvwLocations.SelectedItems[0];
                locationAlternate.ResourceLocation = MyDownloader.Core.ResourceLocation.FromURL(
                    item.SubItems[0].Text, BoolFormatter.FromString(item.SubItems[1].Text), item.SubItems[2].Text, item.SubItems[3].Text);
            }
            else
            {
                locationAlternate.ResourceLocation = null;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            for (int i = lvwLocations.Items.Count - 1; i >= 0; i--)
            {
                if (lvwLocations.Items[i].Selected)
                {
                    lvwLocations.Items.RemoveAt(i);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResourceLocation rl = locationAlternate.ResourceLocation;

            if (lvwLocations.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwLocations.SelectedItems[0];
                item.SubItems[0].Text = rl.URL;
                item.SubItems[1].Text = BoolFormatter.ToString(rl.Authenticate);
                item.SubItems[2].Text = rl.Login;
                item.SubItems[3].Text = rl.Password;
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = rl.URL;
                item.SubItems.Add(BoolFormatter.ToString(rl.Authenticate));
                item.SubItems.Add(rl.Login);
                item.SubItems.Add(rl.Password);
                lvwLocations.Items.Add(item);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceLocation rl = this.DownloadLocation;

                rl.BindProtocolProviderType();

                if (rl.ProtocolProviderType == null)
                {
                    MessageBox.Show("Invalid URL format, please check the location field.",
                        AppManager.Instance.Application.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DialogResult = DialogResult.None;
                    return;
                }

                ResourceLocation[] mirrors = this.Mirrors;

                if (mirrors != null && mirrors.Length > 0)
                {
                    foreach (ResourceLocation mirrorRl in mirrors)
                    {
                        mirrorRl.BindProtocolProviderType();

                        if (mirrorRl.ProtocolProviderType == null)
                        {
                            MessageBox.Show("Invalid mirror URL format, please check the mirror URLs.",
                                AppManager.Instance.Application.MainForm.Text, 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);

                            DialogResult = DialogResult.None;
                            return;
                        }
                    }
                }

                if (chkChooseZIP.Checked)
                {
                    AddDownloadsFromZip(checkableTreeView1.Nodes, mirrors);
                }
                else
                {
                    Downloader download = DownloadManager.Instance.Add(
                        rl,
                        mirrors,
                        this.LocalFile,
                        this.Segments,
                        this.StartNow);
                }

                Close();
            }
            catch (Exception)
            {
                DialogResult = DialogResult.None;

                MessageBox.Show("Unknow error, please check your input data.",
                    AppManager.Instance.Application.MainForm.Text, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void AddDownloadsFromZip(TreeNodeCollection nodes, ResourceLocation[] mirrors)
        {
            for (int i = 0; i < nodes.Count; i++)
            {
                if (nodes[i].Checked)
                {
                    if (nodes[i].Nodes.Count > 0)
                    {
                        AddDownloadsFromZip(nodes[i].Nodes, mirrors);
                    }
                    else
                    {
                        ResourceLocation newLocation = this.DownloadLocation;
                        newLocation.ProtocolProviderType = typeof(ZipProtocolProvider).AssemblyQualifiedName;

                        string entryName = ((ZipEntry)nodes[i].Tag).Name;

                        Downloader download = DownloadManager.Instance.Add(
                            newLocation,
                            mirrors,
                            this.folderBrowser1.Folder + entryName,
                            1,
                            false);

                        ZipProtocolProvider.SetZipEntryNameProperty(download, entryName);

                        if (this.StartNow)
                        {
                            download.Start();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkChooseZIP_CheckedChanged(object sender, EventArgs e)
        {
            ReleaseZIPThread();

            ShowZIPMode(chkChooseZIP.Checked);

            if (chkChooseZIP.Checked)
            {
                LoadZIP();
            }
        }

        private TreeNode GetNodeFromPath(String path, out string displayName)
        {
            string[] subPaths = path.Split('/');

            if (subPaths.Length == 0)
            {
                displayName = null;
                return null;
            }

            TreeNode result = null;

            TreeNodeCollection nodes = checkableTreeView1.Nodes;

            displayName = subPaths[subPaths.Length - 1];

            for (int j = 0; j < subPaths.Length - 1; j++)
            {
                TreeNode parentNode = null;

                for (int i = 0; i < nodes.Count; i++)
                {
                    if (String.Equals(nodes[i].Text, subPaths[j], StringComparison.OrdinalIgnoreCase))
                    {
                        parentNode = nodes[i];
                        break;
                    }
                }

                if (parentNode == null)
                {
                    // add the path
                    result = new TreeNode(subPaths[j]);
                    result.ImageIndex = FileTypeImageList.GetImageIndexFromFolder(false);
                    result.SelectedImageIndex = FileTypeImageList.GetImageIndexFromFolder(true);
                    nodes.Add(result);                    
                }
                else
                {
                    result = parentNode;
                }

                nodes = result.Nodes;
            }

            return result;
        }

        private void ReleaseZIPThread()
        {
            if (zipReaderThread != null)
            {
                if (zipReaderThread.IsAlive)
                {
                    zipReaderThread.Abort();
                    zipReaderThread = null;
                }
            }

            waitControl1.Visible = false;
        }

        private void LoadZIP()
        {
            checkableTreeView1.Nodes.Clear();

            ResourceLocation rl = this.DownloadLocation;

            rl.BindProtocolProviderType();

            if (rl.ProtocolProviderType == null)
            {
                chkChooseZIP.Checked = false;

                MessageBox.Show("Invalid URL format, please check the location field.",
                    AppManager.Instance.Application.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }            

            ReleaseZIPThread();

            zipReaderThread = new Thread(
                delegate(object state)
                {
                    ZipRemoteFile zipFile = new ZipRemoteFile((ResourceLocation)state);

                    try
                    {
                        if (zipFile.Load())
                        {
                            this.BeginInvoke((MethodInvoker)delegate() { DisplayZIPOnTree(zipFile); waitControl1.Visible = false; });
                        }
                        else
                        {
                            this.BeginInvoke((MethodInvoker)delegate()
                            {
                                waitControl1.Visible = false;

                                MessageBox.Show("Unable to load ZIP contents.",
                                    AppManager.Instance.Application.MainForm.Text,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            });
                        }
                    }
                    catch (Exception ex)
                    {
                        this.BeginInvoke((MethodInvoker)delegate()
                        {
                            waitControl1.Visible = false;

                            MessageBox.Show("Unable to load ZIP contents: " + ex.Message,
                                AppManager.Instance.Application.MainForm.Text,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        });
                    }
                }
            );

            waitControl1.Visible = true;
            zipReaderThread.Start(rl);            
        }

        private void DisplayZIPOnTree(ZipRemoteFile zipFile)
        {
            checkableTreeView1.ImageList = FileTypeImageList.GetSharedInstance();
            checkableTreeView1.Nodes.Clear();

            foreach (ZipEntry entry in zipFile)
            {
                // skip folders...
                if (entry.Name.EndsWith("/"))
                {
                    continue;
                }

                string displayName;
                TreeNode parentNd = GetNodeFromPath(entry.Name, out displayName);

                TreeNode newNd = new TreeNode(displayName);
                newNd.Tag = entry;
                newNd.ImageIndex = FileTypeImageList.GetImageIndexByExtention(Path.GetExtension(entry.Name));
                newNd.SelectedImageIndex = newNd.ImageIndex;

                if (parentNd == null)
                {
                    checkableTreeView1.Nodes.Add(newNd);
                }
                else
                {
                    parentNd.Nodes.Add(newNd);
                }
            }
        }

        private void ShowZIPMode(bool show)
        {
            if (show)
            {
                this.tableLayoutPanel1.Controls.Clear();
                //this.tableLayoutPanel1.Controls.Add(this.chkChooseZIP, 0, 0);
                //this.tableLayoutPanel1.Controls.Add(this.checkableTreeView1, 0, 1);
                //this.tableLayoutPanel1.Controls.Add(this.folderBrowser1, 0, 2);
                //this.tableLayoutPanel1.Controls.Add(this.chkStartNow, 0, 3);
                //this.tableLayoutPanel1.Controls.Add(this.pnlSegments, 0, 4);

                this.tableLayoutPanel1.Controls.Add(this.chkChooseZIP);
                this.tableLayoutPanel1.Controls.Add(this.checkableTreeView1);
                this.tableLayoutPanel1.Controls.Add(this.folderBrowser1);
                this.tableLayoutPanel1.Controls.Add(this.chkStartNow);
                this.tableLayoutPanel1.Controls.Add(this.pnlSegments);

                //this.tableLayoutPanel1.RowCount = 5;
                this.tableLayoutPanel1.AutoSize = true;
                this.Height = 600;

                /* this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());*/
            }
            else
            {
                this.tableLayoutPanel1.Controls.Clear();
                //this.tableLayoutPanel1.Controls.Add(this.chkChooseZIP, 0, 0);
                //this.tableLayoutPanel1.Controls.Add(this.pnlFileName, 0, 1);
                //this.tableLayoutPanel1.Controls.Add(this.folderBrowser1, 0, 2);
                //this.tableLayoutPanel1.Controls.Add(this.chkStartNow, 0, 3);
                //this.tableLayoutPanel1.Controls.Add(this.pnlSegments, 0, 4);

                this.tableLayoutPanel1.Controls.Add(this.chkChooseZIP);
                this.tableLayoutPanel1.Controls.Add(this.pnlFileName);
                this.tableLayoutPanel1.Controls.Add(this.folderBrowser1);
                this.tableLayoutPanel1.Controls.Add(this.chkStartNow);
                this.tableLayoutPanel1.Controls.Add(this.pnlSegments);

                //this.tableLayoutPanel1.RowCount = 5;
                this.tableLayoutPanel1.AutoSize = true;
                this.Height = 374;

                /* this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());*/
            }
        }

        private void NewDownloadForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ReleaseZIPThread();
        }
    }
}