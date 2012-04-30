using MyDownloader.Spider.UI;
namespace MyDownloader.App.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolNewDownload = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripScheduler = new System.Windows.Forms.ToolStripButton();
            this.toolPause = new System.Windows.Forms.ToolStripButton();
            this.toolPauseAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRemove = new System.Windows.Forms.ToolStripButton();
            this.toolRemoveCompleted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMoveSelectionsUp = new System.Windows.Forms.ToolStripButton();
            this.toolMoveSelectionsDown = new System.Windows.Forms.ToolStripButton();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.clipboardMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.newDownloadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newBatchDownloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDownloadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newVideoDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBatchDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.importFromTextFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCompletedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyURLToClipboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faTabStrip1 = new FarsiLibrary.Win.FATabStrip();
            this.faTabStripItem1 = new FarsiLibrary.Win.FATabStripItem();
            this.downloadList1 = new MyDownloader.App.UI.DownloadList();
            this.faTabStripItem2 = new FarsiLibrary.Win.FATabStripItem();
            this.webSpider1 = new MyDownloader.Spider.UI.WebSpider();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.cntxMenuDownLimit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setCustomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSpeedLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLblRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLblRateTxt = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMain.SuspendLayout();
            this.notifyIconContextMenu.SuspendLayout();
            this.menuBarStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).BeginInit();
            this.faTabStrip1.SuspendLayout();
            this.faTabStripItem1.SuspendLayout();
            this.faTabStripItem2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.cntxMenuDownLimit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 1500;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNewDownload,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStart,
            this.toolStripScheduler,
            this.toolPause,
            this.toolPauseAll,
            this.toolStripSeparator2,
            this.toolRemove,
            this.toolRemoveCompleted,
            this.toolStripSeparator3,
            this.toolMoveSelectionsUp,
            this.toolMoveSelectionsDown});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(541, 25);
            this.toolStripMain.TabIndex = 1;
            // 
            // toolNewDownload
            // 
            this.toolNewDownload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNewDownload.Image = ((System.Drawing.Image)(resources.GetObject("toolNewDownload.Image")));
            this.toolNewDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNewDownload.Name = "toolNewDownload";
            this.toolNewDownload.Size = new System.Drawing.Size(23, 22);
            this.toolNewDownload.Text = "New Download";
            this.toolNewDownload.Click += new System.EventHandler(this.toolNewDownload_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(127, 22);
            this.toolStripButton1.Text = "New Video Download";
            this.toolStripButton1.ToolTipText = "New Video Download (from YouTube, GoogleVideo, Break...)";
            this.toolStripButton1.Click += new System.EventHandler(this.newVideoDownloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStart
            // 
            this.toolStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStart.Image")));
            this.toolStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStart.Name = "toolStart";
            this.toolStart.Size = new System.Drawing.Size(23, 22);
            this.toolStart.Text = "Start";
            this.toolStart.Click += new System.EventHandler(this.toolStart_Click);
            // 
            // toolStripScheduler
            // 
            this.toolStripScheduler.CheckOnClick = true;
            this.toolStripScheduler.Image = ((System.Drawing.Image)(resources.GetObject("toolStripScheduler.Image")));
            this.toolStripScheduler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripScheduler.Name = "toolStripScheduler";
            this.toolStripScheduler.Size = new System.Drawing.Size(106, 22);
            this.toolStripScheduler.Text = "Auto-Downloads";
            this.toolStripScheduler.ToolTipText = "Toggle Auto-Downloads On/Off";
            this.toolStripScheduler.Click += new System.EventHandler(this.toolStripScheduler_Click);
            // 
            // toolPause
            // 
            this.toolPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPause.Image = ((System.Drawing.Image)(resources.GetObject("toolPause.Image")));
            this.toolPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPause.Name = "toolPause";
            this.toolPause.Size = new System.Drawing.Size(23, 22);
            this.toolPause.Text = "Pause";
            this.toolPause.Click += new System.EventHandler(this.toolPause_Click);
            // 
            // toolPauseAll
            // 
            this.toolPauseAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPauseAll.Image = ((System.Drawing.Image)(resources.GetObject("toolPauseAll.Image")));
            this.toolPauseAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPauseAll.Name = "toolPauseAll";
            this.toolPauseAll.Size = new System.Drawing.Size(23, 22);
            this.toolPauseAll.Text = "Pause All";
            this.toolPauseAll.Click += new System.EventHandler(this.toolPauseAll_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolRemove
            // 
            this.toolRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolRemove.Image")));
            this.toolRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemove.Name = "toolRemove";
            this.toolRemove.Size = new System.Drawing.Size(23, 22);
            this.toolRemove.Text = "Remove";
            this.toolRemove.Click += new System.EventHandler(this.toolRemove_Click);
            // 
            // toolRemoveCompleted
            // 
            this.toolRemoveCompleted.Image = ((System.Drawing.Image)(resources.GetObject("toolRemoveCompleted.Image")));
            this.toolRemoveCompleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRemoveCompleted.Name = "toolRemoveCompleted";
            this.toolRemoveCompleted.Size = new System.Drawing.Size(120, 22);
            this.toolRemoveCompleted.Text = "Remove Completed";
            this.toolRemoveCompleted.Click += new System.EventHandler(this.toolRemoveCompleted_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolMoveSelectionsUp
            // 
            this.toolMoveSelectionsUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveSelectionsUp.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsUp.Image")));
            this.toolMoveSelectionsUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveSelectionsUp.Name = "toolMoveSelectionsUp";
            this.toolMoveSelectionsUp.Size = new System.Drawing.Size(23, 22);
            this.toolMoveSelectionsUp.Text = "Move Selections Up";
            this.toolMoveSelectionsUp.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolMoveSelectionsDown
            // 
            this.toolMoveSelectionsDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolMoveSelectionsDown.Image = ((System.Drawing.Image)(resources.GetObject("toolMoveSelectionsDown.Image")));
            this.toolMoveSelectionsDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolMoveSelectionsDown.Name = "toolMoveSelectionsDown";
            this.toolMoveSelectionsDown.Size = new System.Drawing.Size(23, 22);
            this.toolMoveSelectionsDown.Text = "Move Selections Down";
            this.toolMoveSelectionsDown.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenu;
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // notifyIconContextMenu
            // 
            this.notifyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem,
            this.toolStripSeparator4,
            this.clipboardMonitoringToolStripMenuItem,
            this.toolStripSeparator14,
            this.newDownloadToolStripMenuItem2,
            this.newBatchDownloadToolStripMenuItem1,
            this.toolStripSeparator11,
            this.pauseAllToolStripMenuItem,
            this.toolStripSeparator12,
            this.optionsToolStripMenuItem1,
            this.toolStripSeparator13,
            this.exitToolStripMenuItem1});
            this.notifyIconContextMenu.Name = "notifyIconContextMenu";
            this.notifyIconContextMenu.Size = new System.Drawing.Size(199, 188);
            this.notifyIconContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.notifyIconContextMenu_Opening);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            this.showHideToolStripMenuItem.Click += new System.EventHandler(this.showHideToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(195, 6);
            // 
            // clipboardMonitoringToolStripMenuItem
            // 
            this.clipboardMonitoringToolStripMenuItem.CheckOnClick = true;
            this.clipboardMonitoringToolStripMenuItem.Name = "clipboardMonitoringToolStripMenuItem";
            this.clipboardMonitoringToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clipboardMonitoringToolStripMenuItem.Text = "Clipboard monitoring";
            this.clipboardMonitoringToolStripMenuItem.Click += new System.EventHandler(this.clipboardMonitoringToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(195, 6);
            // 
            // newDownloadToolStripMenuItem2
            // 
            this.newDownloadToolStripMenuItem2.Name = "newDownloadToolStripMenuItem2";
            this.newDownloadToolStripMenuItem2.Size = new System.Drawing.Size(198, 22);
            this.newDownloadToolStripMenuItem2.Text = "New Download...";
            this.newDownloadToolStripMenuItem2.Click += new System.EventHandler(this.toolNewDownload_Click);
            // 
            // newBatchDownloadToolStripMenuItem1
            // 
            this.newBatchDownloadToolStripMenuItem1.Name = "newBatchDownloadToolStripMenuItem1";
            this.newBatchDownloadToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.newBatchDownloadToolStripMenuItem1.Text = "New Batch Download...";
            this.newBatchDownloadToolStripMenuItem1.Click += new System.EventHandler(this.newBatchDownloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(195, 6);
            // 
            // pauseAllToolStripMenuItem
            // 
            this.pauseAllToolStripMenuItem.Name = "pauseAllToolStripMenuItem";
            this.pauseAllToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.pauseAllToolStripMenuItem.Text = "Pause All";
            this.pauseAllToolStripMenuItem.Click += new System.EventHandler(this.toolPauseAll_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(195, 6);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.optionsToolStripMenuItem1.Text = "Options...";
            this.optionsToolStripMenuItem1.Click += new System.EventHandler(this.toolOptions_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(195, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuBarStrip
            // 
            this.menuBarStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem4,
            this.helpToolStripMenuItem});
            this.menuBarStrip.Location = new System.Drawing.Point(0, 0);
            this.menuBarStrip.Name = "menuBarStrip";
            this.menuBarStrip.Size = new System.Drawing.Size(541, 24);
            this.menuBarStrip.TabIndex = 0;
            this.menuBarStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDownloadToolStripMenuItem1,
            this.newVideoDownloadToolStripMenuItem,
            this.newBatchDownloadToolStripMenuItem,
            this.toolStripSeparator8,
            this.importFromTextFileToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newDownloadToolStripMenuItem1
            // 
            this.newDownloadToolStripMenuItem1.Name = "newDownloadToolStripMenuItem1";
            this.newDownloadToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newDownloadToolStripMenuItem1.Size = new System.Drawing.Size(266, 22);
            this.newDownloadToolStripMenuItem1.Text = "New Download...";
            this.newDownloadToolStripMenuItem1.Click += new System.EventHandler(this.toolNewDownload_Click);
            // 
            // newVideoDownloadToolStripMenuItem
            // 
            this.newVideoDownloadToolStripMenuItem.Name = "newVideoDownloadToolStripMenuItem";
            this.newVideoDownloadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.N)));
            this.newVideoDownloadToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.newVideoDownloadToolStripMenuItem.Text = "New Video Download...";
            this.newVideoDownloadToolStripMenuItem.Click += new System.EventHandler(this.newVideoDownloadToolStripMenuItem_Click);
            // 
            // newBatchDownloadToolStripMenuItem
            // 
            this.newBatchDownloadToolStripMenuItem.Name = "newBatchDownloadToolStripMenuItem";
            this.newBatchDownloadToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.newBatchDownloadToolStripMenuItem.Text = "New Batch Download...";
            this.newBatchDownloadToolStripMenuItem.Click += new System.EventHandler(this.newBatchDownloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(263, 6);
            // 
            // importFromTextFileToolStripMenuItem
            // 
            this.importFromTextFileToolStripMenuItem.Name = "importFromTextFileToolStripMenuItem";
            this.importFromTextFileToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.importFromTextFileToolStripMenuItem.Text = "Import from file...";
            this.importFromTextFileToolStripMenuItem.Click += new System.EventHandler(this.importFromTextFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(263, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.removeCompletedToolStripMenuItem,
            this.toolStripSeparator6,
            this.selectAllToolStripMenuItem,
            this.copyURLToClipboardToolStripMenuItem1,
            this.toolStripSeparator9,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.toolRemove_Click);
            // 
            // removeCompletedToolStripMenuItem
            // 
            this.removeCompletedToolStripMenuItem.Name = "removeCompletedToolStripMenuItem";
            this.removeCompletedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.removeCompletedToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.removeCompletedToolStripMenuItem.Text = "Remove Completed";
            this.removeCompletedToolStripMenuItem.Click += new System.EventHandler(this.toolRemoveCompleted_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(227, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyURLToClipboardToolStripMenuItem1
            // 
            this.copyURLToClipboardToolStripMenuItem1.Name = "copyURLToClipboardToolStripMenuItem1";
            this.copyURLToClipboardToolStripMenuItem1.Size = new System.Drawing.Size(230, 22);
            this.copyURLToClipboardToolStripMenuItem1.Text = "Copy URL to Clipboard";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(227, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.optionsToolStripMenuItem.Text = "Options...";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.toolOptions_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segmentsToolStripMenuItem,
            this.toolbarToolStripMenuItem,
            this.gridToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(41, 20);
            this.toolStripMenuItem4.Text = "View";
            // 
            // segmentsToolStripMenuItem
            // 
            this.segmentsToolStripMenuItem.Name = "segmentsToolStripMenuItem";
            this.segmentsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.segmentsToolStripMenuItem.Text = "Segments";
            this.segmentsToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
            // 
            // toolbarToolStripMenuItem
            // 
            this.toolbarToolStripMenuItem.Name = "toolbarToolStripMenuItem";
            this.toolbarToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.toolbarToolStripMenuItem.Text = "Toolbar";
            this.toolbarToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.viewMenuClickClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripSeparator10,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem2.Text = "My Downloader Home Page";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItem1.Text = "Make a Donation";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(213, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // faTabStrip1
            // 
            this.faTabStrip1.AlwaysShowClose = false;
            this.faTabStrip1.AlwaysShowMenuGlyph = false;
            this.faTabStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.faTabStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.faTabStrip1.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.faTabStripItem1,
            this.faTabStripItem2});
            this.faTabStrip1.Location = new System.Drawing.Point(0, 52);
            this.faTabStrip1.Name = "faTabStrip1";
            this.faTabStrip1.SelectedItem = this.faTabStripItem1;
            this.faTabStrip1.Size = new System.Drawing.Size(541, 326);
            this.faTabStrip1.TabIndex = 2;
            this.faTabStrip1.Text = "Downloads";
            // 
            // faTabStripItem1
            // 
            this.faTabStripItem1.CanClose = false;
            this.faTabStripItem1.Controls.Add(this.downloadList1);
            this.faTabStripItem1.IsDrawn = true;
            this.faTabStripItem1.Name = "faTabStripItem1";
            this.faTabStripItem1.Selected = true;
            this.faTabStripItem1.Size = new System.Drawing.Size(539, 305);
            this.faTabStripItem1.TabIndex = 0;
            this.faTabStripItem1.Title = "Downloads";
            // 
            // downloadList1
            // 
            this.downloadList1.ClipboardMonitorEnabled = false;
            this.downloadList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.downloadList1.Location = new System.Drawing.Point(0, 0);
            this.downloadList1.Name = "downloadList1";
            this.downloadList1.Size = new System.Drawing.Size(539, 305);
            this.downloadList1.TabIndex = 0;
            // 
            // faTabStripItem2
            // 
            this.faTabStripItem2.CanClose = false;
            this.faTabStripItem2.Controls.Add(this.webSpider1);
            this.faTabStripItem2.IsDrawn = true;
            this.faTabStripItem2.Name = "faTabStripItem2";
            this.faTabStripItem2.Size = new System.Drawing.Size(655, 320);
            this.faTabStripItem2.TabIndex = 1;
            this.faTabStripItem2.Title = "Web Spider";
            // 
            // webSpider1
            // 
            this.webSpider1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSpider1.Location = new System.Drawing.Point(0, 0);
            this.webSpider1.Name = "webSpider1";
            this.webSpider1.Size = new System.Drawing.Size(655, 320);
            this.webSpider1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ContextMenuStrip = this.cntxMenuDownLimit;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLblRate,
            this.toolStripLblRateTxt});
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(541, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // cntxMenuDownLimit
            // 
            this.cntxMenuDownLimit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setCustomToolStripMenuItem,
            this.enableSpeedLimitToolStripMenuItem});
            this.cntxMenuDownLimit.Name = "cntxMenuDownLimit";
            this.cntxMenuDownLimit.Size = new System.Drawing.Size(175, 48);
            this.cntxMenuDownLimit.Opening += new System.ComponentModel.CancelEventHandler(this.cntxMenuDownLimit_Opening);
            // 
            // setCustomToolStripMenuItem
            // 
            this.setCustomToolStripMenuItem.Name = "setCustomToolStripMenuItem";
            this.setCustomToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.setCustomToolStripMenuItem.Text = "Set Custom...";
            this.setCustomToolStripMenuItem.Click += new System.EventHandler(this.setCustomToolStripMenuItem_Click);
            // 
            // enableSpeedLimitToolStripMenuItem
            // 
            this.enableSpeedLimitToolStripMenuItem.CheckOnClick = true;
            this.enableSpeedLimitToolStripMenuItem.Name = "enableSpeedLimitToolStripMenuItem";
            this.enableSpeedLimitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.enableSpeedLimitToolStripMenuItem.Text = "Enable Speed Limit";
            this.enableSpeedLimitToolStripMenuItem.Click += new System.EventHandler(this.enableSpeedLimitToolStripMenuItem_Click);
            // 
            // toolStripLblRate
            // 
            this.toolStripLblRate.Name = "toolStripLblRate";
            this.toolStripLblRate.Size = new System.Drawing.Size(34, 17);
            this.toolStripLblRate.Text = "Rate:";
            // 
            // toolStripLblRateTxt
            // 
            this.toolStripLblRateTxt.Name = "toolStripLblRateTxt";
            this.toolStripLblRateTxt.Size = new System.Drawing.Size(38, 17);
            this.toolStripLblRateTxt.Text = "0 kbps";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 400);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuBarStrip);
            this.Controls.Add(this.faTabStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuBarStrip;
            this.Name = "MainForm";
            this.Text = "My Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.notifyIconContextMenu.ResumeLayout(false);
            this.menuBarStrip.ResumeLayout(false);
            this.menuBarStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.faTabStrip1)).EndInit();
            this.faTabStrip1.ResumeLayout(false);
            this.faTabStripItem1.ResumeLayout(false);
            this.faTabStripItem2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cntxMenuDownLimit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStart;
        private System.Windows.Forms.ToolStripButton toolPause;
        private System.Windows.Forms.ToolStripButton toolPauseAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolRemove;
        private System.Windows.Forms.ToolStripButton toolRemoveCompleted;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolNewDownload;
        internal System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.MenuStrip menuBarStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDownloadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newBatchDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyURLToClipboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeCompletedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem segmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newDownloadToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newBatchDownloadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem pauseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newVideoDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripScheduler;
        private FarsiLibrary.Win.FATabStrip faTabStrip1;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem1;
        protected internal DownloadList downloadList1;
        private System.Windows.Forms.ToolStripMenuItem importFromTextFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblRate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLblRateTxt;
        private System.Windows.Forms.ToolStripButton toolMoveSelectionsUp;
        private System.Windows.Forms.ToolStripButton toolMoveSelectionsDown;
        private System.Windows.Forms.ContextMenuStrip cntxMenuDownLimit;
        private System.Windows.Forms.ToolStripMenuItem setCustomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSpeedLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private FarsiLibrary.Win.FATabStripItem faTabStripItem2;
        private WebSpider webSpider1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem clipboardMonitoringToolStripMenuItem;


    }
}