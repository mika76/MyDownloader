using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using MyDownloader.Core;
using MyDownloader.Core.Common;
using MyDownloader.Core.UI;

namespace MyDownloader.App.UI
{
    public partial class CreateBatchDownloadForm : Form
    {
        public CreateBatchDownloadForm()
        {
            InitializeComponent();

            location1.UrlChanged += new EventHandler(numFrom_ValueChanged);
        }

        private static ResourceLocation GetNumberURL(ResourceLocation locationBase, int i, int wildcard)
        {
            ResourceLocation r = locationBase.Clone();
            r.URL = locationBase.URL.Replace("(*)", i.ToString().PadLeft(wildcard, '0'));
            return r;
        }

        private ResourceLocation GetCharURL(ResourceLocation locationBase, string c)
        {
            ResourceLocation r = locationBase.Clone();
            r.URL = locationBase.URL.Replace("(*)", c);
            return r;
        }

        public string DownloadPath
        {
            get
            {
                return folderBrowser1.Folder;
            }
        }

        public int Segments
        {
            get
            {
                return (int)numSegments.Value;
            }
        }

        public ResourceLocation[] URLs
        {
            get
            {
                ResourceLocation[] result = new ResourceLocation[0];
                ResourceLocation locationBase = location1.ResourceLocation;

                if (rdoNumbers.Checked)
                {
                    int from = (int)numFrom.Value;
                    int to = (int)numTo.Value;
                    int wildcard = (int)numWildcard.Value;

                    if (from <= to)
                    {
                        result = new ResourceLocation[to - from + 1];

                        for (int i = from, j = 0; i <= to; i++, j++)
                        {
                            result[j] = GetNumberURL(locationBase, i, wildcard);
                        }
                    }
                    else
                    {
                        result = new ResourceLocation[2];
                        result[0] = GetNumberURL(locationBase, from, wildcard);
                        result[1] = GetNumberURL(locationBase, to, wildcard);
                    }					
                }
                else
                {
                    string strFrom = txtFrom.Text;
                    string strTo = txtTo.Text;

                    if (String.IsNullOrEmpty(strTo) && !String.IsNullOrEmpty(strFrom))
                    {
                        result = new ResourceLocation[1];
                        result[0] = GetCharURL(locationBase, strFrom);
                    }
                    else if (!String.IsNullOrEmpty(strTo) && String.IsNullOrEmpty(strFrom))
                    {
                        result = new ResourceLocation[1];
                        result[0] = GetCharURL(locationBase, strTo);
                    }
                    else if (!String.IsNullOrEmpty(strTo) && !String.IsNullOrEmpty(strFrom))
                    {
                        char from = strFrom[0];
                        char to = strTo[0];

                        if (from <= to)
                        {
                            result = new ResourceLocation[((int)(to - from)) + 1];

                            int j = 0;
                            for (char i = from; i <= to; i++)
                            {
                                result[j++] = GetCharURL(locationBase, i.ToString());
                            }
                        }
                        else
                        {
                            result = new ResourceLocation[2];
                            result[0] = GetCharURL(locationBase, strFrom);
                            result[1] = GetCharURL(locationBase, strTo);
                        }

                    }

                }

				return result;
            }
        }

        private void PreviewURLs()
        {
            lvwListPreview.BeginUpdate();
            lvwListPreview.DataSource = URLs;
            lvwListPreview.EndUpdate();
        }

        private void numFrom_ValueChanged(object sender, EventArgs e)
        {
            PreviewURLs();
        }

        private void rdoNumbers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateUI();

            PreviewURLs();
        }

        private void UpdateUI()
        {
            numFrom.Enabled = rdoNumbers.Checked;
            numTo.Enabled = rdoNumbers.Checked;
            numWildcard.Enabled = rdoNumbers.Checked;
            txtFrom.Enabled = rdoLetters.Checked;
            txtTo.Enabled = rdoLetters.Checked;
        }

        private void CreateBatchDownloadForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        public void ApplySettings()
        {
            scheduledDownloadEnabler1.ApplySettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceLocation rl = this.location1.ResourceLocation;

                rl.BindProtocolProviderType();

                if (rl.ProtocolProviderType == null)
                {
                    MessageBox.Show("Invalid URL format, please check the location field.",
                        AppManager.Instance.Application.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    DialogResult = DialogResult.None;
                    return;
                }
            }
            catch
            {
                DialogResult = DialogResult.None;

                MessageBox.Show("Unknow error, please check your input data.",
                    AppManager.Instance.Application.MainForm.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}