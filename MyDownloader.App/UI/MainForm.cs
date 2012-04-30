using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Web;
using System.Diagnostics;

using MyDownloader.Core;
using MyDownloader.Core.Common;
using MyDownloader.App.SingleInstancing;
using MyDownloader.Extension.AutoDownloads;
using MyDownloader.Core.Extensions;
using MyDownloader.Extension.SpeedLimit;
using MyDownloader.Extension.Video;
using MyDownloader.Extension.WindowsIntegration.ClipboardMonitor;

namespace MyDownloader.App.UI
{
    public partial class MainForm : Form, ISingleInstanceEnforcer
    {
        SpeedLimitExtension speedLimit;

        public MainForm()
        {
            InitializeComponent();

            downloadList1.SelectionChange += new EventHandler(downloadList1_SelectionChange);
            downloadList1.UpdateUI();           

            speedLimit = (SpeedLimitExtension)App.Instance.GetExtensionByType(typeof(SpeedLimitExtension));
        }

        void downloadList1_SelectionChange(object sender, EventArgs e)
        {
            int cnt = downloadList1.SelectedCount;

            bool isSelected = cnt > 0;
            bool isSelectedOnlyOne = cnt == 1;

            removeToolStripMenuItem.Enabled = isSelected;
            removeCompletedToolStripMenuItem.Enabled = isSelected; 

            toolStart.Enabled = isSelected;
            toolPause.Enabled = isSelected;
            toolRemove.Enabled = isSelected;

            copyURLToClipboardToolStripMenuItem1.Enabled = isSelectedOnlyOne;

            toolMoveSelectionsDown.Enabled = isSelected;
            toolMoveSelectionsUp.Enabled = isSelected;
        }        

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            string strRate;

            if (speedLimit.CurrentEnabled)
            {
                strRate = String.Format("[{0:0.##} kpbs] {1:0.##} kbps",
                    speedLimit.CurrentMaxRate / 1024.0,
                    DownloadManager.Instance.TotalDownloadRate / 1024.0);
            }
            else
            {
                strRate = String.Format("{0:0.##} kbps", DownloadManager.Instance.TotalDownloadRate / 1024.0);
            }

            toolStripScheduler.Checked = downloadList1.SchedulerStarted();

            toolStripLblRateTxt.Text = strRate;

            notifyIcon.Text = String.Concat(this.Text, "\n", toolStripLblRate.Text, " ", strRate);

            downloadList1.UpdateList();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadViewSettings();

            notifyIcon.Icon = this.Icon;
            notifyIcon.Text = this.Text;
            notifyIcon.Visible = true;
        }

        private void toolNewDownload_Click(object sender, EventArgs e)
        {
            downloadList1.NewFileDownload(null, true);
        }

        private void toolStart_Click(object sender, EventArgs e)
        {
            downloadList1.StartSelections();
        }

        private void toolPause_Click(object sender, EventArgs e)
        {
            downloadList1.Pause();
        }

        private void toolPauseAll_Click(object sender, EventArgs e)
        {
            downloadList1.PauseAll();
        }

        private void toolRemove_Click(object sender, EventArgs e)
        {
            downloadList1.RemoveSelections();
        }

        private void toolRemoveCompleted_Click(object sender, EventArgs e)
        {
            downloadList1.RemoveCompleted();
        }

        private void toolOptions_Click(object sender, EventArgs e)
        {
            using (OptionsForm options = new OptionsForm())
            {
                options.ShowDialog();
            }
        }

        private void toolAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm about = new AboutForm())
            {
                about.ShowDialog();
            }
        }

        #region ISingleInstanceEnforcer Members

        public void OnMessageReceived(MessageEventArgs e)
        {
            string[] args = (string[])e.Message;

            if (args.Length == 2 && args[0] == "/sw")
            {
                this.BeginInvoke((MethodInvoker) delegate { downloadList1.NewDownloadFromData(args[1]); });
            }
            else
            {
                downloadList1.AddDownloadURLs(ResourceLocation.FromURLArray(args), 1, null, 0);
            }
        }

        public void OnNewInstanceCreated(EventArgs e)
        {
            this.Focus();
        }

        #endregion

        private void LoadViewSettings()
        {
            downloadList1.LoadSettingsView();

            toolStripMain.Visible = Settings.Default.ViewToolbar;

            if (toolStripMain.Visible)
            {
                faTabStrip1.Top = menuBarStrip.Height + toolStripMain.Top + 1;
            }
            else
            {
                faTabStrip1.Top = menuBarStrip.Height + 4;
            }

            faTabStrip1.Height = this.ClientSize.Height - statusStrip1.Height - faTabStrip1.Top; 

            gridToolStripMenuItem.Checked = Settings.Default.ViewGrid;
            segmentsToolStripMenuItem.Checked = Settings.Default.ViewTransDetails;
            toolbarToolStripMenuItem.Checked = Settings.Default.ViewToolbar;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newBatchDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            downloadList1.NewBatchDownload();
        }

        private void viewMenuClickClick(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = ((ToolStripMenuItem)sender);
            menu.Checked = !menu.Checked;

            Settings.Default.ViewGrid = gridToolStripMenuItem.Checked;
            Settings.Default.ViewToolbar = toolbarToolStripMenuItem.Checked;
            Settings.Default.ViewTransDetails = segmentsToolStripMenuItem.Checked;

            LoadViewSettings();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHideForm();
        }

        public void ShowHideForm()
        {
            if (this.Visible)
            {
                HideForm();
            }
            else
            {
                ShowForm();
                LoadViewSettings();
            }
        }

        public void ShowForm()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        public void HideForm()
        {
            this.ShowInTaskbar = false;
            this.Visible = false;
        }

        private void showHideToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowHideForm();
            }
        }

        private void newVideoDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            downloadList1.NewVideoDownload();
        }

        private void toolStripScheduler_Click(object sender, EventArgs e)
        {
            downloadList1.StartScheduler(toolStripScheduler.Checked);
        }

        private void importFromTextFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            downloadList1.ImportFromTextFile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            downloadList1.MoveSelectionsUp();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            downloadList1.MoveSelectionsDown();
        }

        private void setCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((SpeedLimitUIExtension)speedLimit.UIExtension).ShowSpeedLimitDialog();
        }

        private void enableSpeedLimitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speedLimit.Parameters.Enabled = enableSpeedLimitToolStripMenuItem.Checked;
        }

        private void cntxMenuDownLimit_Opening(object sender, CancelEventArgs e)
        {
            enableSpeedLimitToolStripMenuItem.Checked = speedLimit.Parameters.Enabled;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            downloadList1.SelectAll();
        }

        private void clipboardMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            downloadList1.ClipboardMonitorEnabled = (clipboardMonitoringToolStripMenuItem.Checked);
        }

        private void notifyIconContextMenu_Opening(object sender, CancelEventArgs e)
        {
            clipboardMonitoringToolStripMenuItem.Checked = downloadList1.ClipboardMonitorEnabled;
        }
    }
}