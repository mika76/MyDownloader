using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Core.Extensions;

namespace MyDownloader.App.UI
{
    public partial class OptionsForm : Form
    {
        delegate void ProcessItemDelegate(IExtension extension, Control[] options);

        public OptionsForm()
        {
            InitializeComponent();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            try
            {
                treeOptions.BeginUpdate();

                for (int i = 0; i < App.Instance.Extensions.Count; i++)
                {
                    IExtension extension = App.Instance.Extensions[i];
                    IUIExtension uiExtension = extension.UIExtension;

                    if (uiExtension == null)
                    {
                        continue;
                    }

                    Control[] options = uiExtension.CreateSettingsView();

                    if (options == null || options.Length == 0)
                    {
                        continue;
                    }

                    TreeNode node = new TreeNode(extension.Name);
                    node.Tag = extension;

                    for (int j = 0; j < options.Length; j++)
                    {
                        TreeNode optioNd = new TreeNode(options[j].Text);
                        optioNd.Tag = options[j];
                        node.Nodes.Add(optioNd);
                    }

                    node.Expand();

                    treeOptions.Nodes.Add(node);
                }
            }
            finally
            {
                treeOptions.EndUpdate();
            }
        }

        private void ProcessSettings(ProcessItemDelegate process)
        {
            for (int i = 0; i < treeOptions.Nodes.Count; i++)
            {
                TreeNode node = treeOptions.Nodes[i];
                IExtension extension = (IExtension)node.Tag;
                Control[] options = new Control[node.Nodes.Count];
                for (int j = 0; j < node.Nodes.Count; j++)
                {
                    options[j] = (Control)node.Nodes[j].Tag;
                }

                process(extension, options);
            }

            treeOptions.Nodes.Clear();
        }

        private void treeOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pnlExtension.Controls.Clear();

            if (e.Node.Parent != null)
            {
                ShowOptionFromNode(e.Node);
            }
            else
            {
                ShowOptionFromNode(e.Node.Nodes[0]);
            }
        }

        private void ShowOptionFromNode(TreeNode node)
        {
            Control ctrl = (Control)node.Tag;
            ctrl.Visible = true;
            ctrl.Dock = DockStyle.Fill;
            pnlExtension.Controls.Add(ctrl);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ProcessSettings(
                delegate(IExtension extension, Control[] options)
                {
                    extension.UIExtension.PersistSettings(options);

                    for (int i = 0; i < options.Length; i++)
                    {
                        options[i].Dispose();
                    }
                }
                );

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ProcessSettings(
                delegate(IExtension extension, Control[] options)
                {
                    for (int i = 0; i < options.Length; i++)
                    {
                        options[i].Dispose();
                    }
                }
            );

            DialogResult = DialogResult.Cancel;
        }
    }
}