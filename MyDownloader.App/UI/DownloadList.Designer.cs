namespace MyDownloader.App.UI
{
    partial class DownloadList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lvwDownloads = new System.Windows.Forms.ListView();
            this.columnFile = new System.Windows.Forms.ColumnHeader();
            this.columnSize = new System.Windows.Forms.ColumnHeader();
            this.columnCompleted = new System.Windows.Forms.ColumnHeader();
            this.columnProgress = new System.Windows.Forms.ColumnHeader();
            this.columnLeft = new System.Windows.Forms.ColumnHeader();
            this.columnRate = new System.Windows.Forms.ColumnHeader();
            this.columnAdded = new System.Windows.Forms.ColumnHeader();
            this.columnState = new System.Windows.Forms.ColumnHeader();
            this.columnResume = new System.Windows.Forms.ColumnHeader();
            this.columnURL = new System.Windows.Forms.ColumnHeader();
            this.popUpContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyURLToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSegmentsLogs = new System.Windows.Forms.TabControl();
            this.tabSegments = new System.Windows.Forms.TabPage();
            this.blockedProgressBar1 = new MyDownloader.App.Controls.BlockedProgressBar();
            this.lvwSegments = new System.Windows.Forms.ListView();
            this.columnCurrentTry = new System.Windows.Forms.ColumnHeader();
            this.columnSegProgress = new System.Windows.Forms.ColumnHeader();
            this.columnSegCompleted = new System.Windows.Forms.ColumnHeader();
            this.columnSegSize = new System.Windows.Forms.ColumnHeader();
            this.columnStartPosition = new System.Windows.Forms.ColumnHeader();
            this.columnEndPosition = new System.Windows.Forms.ColumnHeader();
            this.columnSegRate = new System.Windows.Forms.ColumnHeader();
            this.columnSegLeft = new System.Windows.Forms.ColumnHeader();
            this.columnSegState = new System.Windows.Forms.ColumnHeader();
            this.columnCurrURL = new System.Windows.Forms.ColumnHeader();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.logContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.popUpContextMenu.SuspendLayout();
            this.tabSegmentsLogs.SuspendLayout();
            this.tabSegments.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.logContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lvwDownloads);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabSegmentsLogs);
            this.splitContainer2.Size = new System.Drawing.Size(722, 436);
            this.splitContainer2.SplitterDistance = 211;
            this.splitContainer2.TabIndex = 15;
            // 
            // lvwDownloads
            // 
            this.lvwDownloads.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFile,
            this.columnSize,
            this.columnCompleted,
            this.columnProgress,
            this.columnLeft,
            this.columnRate,
            this.columnAdded,
            this.columnState,
            this.columnResume,
            this.columnURL});
            this.lvwDownloads.ContextMenuStrip = this.popUpContextMenu;
            this.lvwDownloads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwDownloads.FullRowSelect = true;
            this.lvwDownloads.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwDownloads.HideSelection = false;
            this.lvwDownloads.Location = new System.Drawing.Point(0, 0);
            this.lvwDownloads.Name = "lvwDownloads";
            this.lvwDownloads.ShowGroups = false;
            this.lvwDownloads.ShowItemToolTips = true;
            this.lvwDownloads.Size = new System.Drawing.Size(722, 211);
            this.lvwDownloads.TabIndex = 0;
            this.lvwDownloads.UseCompatibleStateImageBehavior = false;
            this.lvwDownloads.View = System.Windows.Forms.View.Details;
            this.lvwDownloads.DoubleClick += new System.EventHandler(this.lvwDownloads_DoubleClick);
            this.lvwDownloads.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwDownloads_ItemSelectionChanged);
            // 
            // columnFile
            // 
            this.columnFile.Text = "File";
            this.columnFile.Width = 98;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.Width = 80;
            // 
            // columnCompleted
            // 
            this.columnCompleted.Text = "Completed";
            this.columnCompleted.Width = 81;
            // 
            // columnProgress
            // 
            this.columnProgress.Text = "Progress";
            this.columnProgress.Width = 63;
            // 
            // columnLeft
            // 
            this.columnLeft.Text = "Left";
            this.columnLeft.Width = 70;
            // 
            // columnRate
            // 
            this.columnRate.Text = "Rate";
            this.columnRate.Width = 72;
            // 
            // columnAdded
            // 
            this.columnAdded.Text = "Added";
            this.columnAdded.Width = 77;
            // 
            // columnState
            // 
            this.columnState.Text = "State";
            this.columnState.Width = 97;
            // 
            // columnResume
            // 
            this.columnResume.Text = "Resume";
            // 
            // columnURL
            // 
            this.columnURL.Text = "URL";
            this.columnURL.Width = 171;
            // 
            // popUpContextMenu
            // 
            this.popUpContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDownloadToolStripMenuItem,
            this.toolStripSeparator5,
            this.startToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.toolStripSeparator6,
            this.removeToolStripMenuItem,
            this.toolStripSeparator7,
            this.openFileToolStripMenuItem,
            this.copyURLToClipboardToolStripMenuItem,
            this.showInExplorerToolStripMenuItem});
            this.popUpContextMenu.Name = "contextMenuStrip1";
            this.popUpContextMenu.Size = new System.Drawing.Size(194, 176);
            this.popUpContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.popUpContextMenu_Opening);
            // 
            // newDownloadToolStripMenuItem
            // 
            this.newDownloadToolStripMenuItem.Name = "newDownloadToolStripMenuItem";
            this.newDownloadToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newDownloadToolStripMenuItem.Text = "New Download...";
            this.newDownloadToolStripMenuItem.Click += new System.EventHandler(this.newDownloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(190, 6);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(190, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(190, 6);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // copyURLToClipboardToolStripMenuItem
            // 
            this.copyURLToClipboardToolStripMenuItem.Name = "copyURLToClipboardToolStripMenuItem";
            this.copyURLToClipboardToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyURLToClipboardToolStripMenuItem.Text = "Copy URL to Clipboard";
            this.copyURLToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyURLToClipboardToolStripMenuItem_Click);
            // 
            // showInExplorerToolStripMenuItem
            // 
            this.showInExplorerToolStripMenuItem.Name = "showInExplorerToolStripMenuItem";
            this.showInExplorerToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.showInExplorerToolStripMenuItem.Text = "Show in Explorer";
            this.showInExplorerToolStripMenuItem.Click += new System.EventHandler(this.showInExplorerToolStripMenuItem_Click);
            // 
            // tabSegmentsLogs
            // 
            this.tabSegmentsLogs.Controls.Add(this.tabSegments);
            this.tabSegmentsLogs.Controls.Add(this.tabLog);
            this.tabSegmentsLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSegmentsLogs.Location = new System.Drawing.Point(0, 0);
            this.tabSegmentsLogs.Name = "tabSegmentsLogs";
            this.tabSegmentsLogs.SelectedIndex = 0;
            this.tabSegmentsLogs.Size = new System.Drawing.Size(722, 221);
            this.tabSegmentsLogs.TabIndex = 0;
            // 
            // tabSegments
            // 
            this.tabSegments.Controls.Add(this.blockedProgressBar1);
            this.tabSegments.Controls.Add(this.lvwSegments);
            this.tabSegments.Location = new System.Drawing.Point(4, 22);
            this.tabSegments.Name = "tabSegments";
            this.tabSegments.Padding = new System.Windows.Forms.Padding(3);
            this.tabSegments.Size = new System.Drawing.Size(714, 195);
            this.tabSegments.TabIndex = 0;
            this.tabSegments.Text = "Segments";
            this.tabSegments.UseVisualStyleBackColor = true;
            // 
            // blockedProgressBar1
            // 
            this.blockedProgressBar1.BackColor = System.Drawing.SystemColors.Window;
            this.blockedProgressBar1.Direction = MyDownloader.App.Controls.BlockedProgressBar.DirectionMode.Horizontal;
            this.blockedProgressBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.blockedProgressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.blockedProgressBar1.Length = 0;
            this.blockedProgressBar1.Location = new System.Drawing.Point(3, 3);
            this.blockedProgressBar1.Name = "blockedProgressBar1";
            this.blockedProgressBar1.Size = new System.Drawing.Size(708, 23);
            this.blockedProgressBar1.TabIndex = 0;
            this.blockedProgressBar1.Text = "blockedProgressBar1";
            this.blockedProgressBar1.UpdateMode = MyDownloader.App.Controls.BlockList.UpdateMode.All;
            // 
            // lvwSegments
            // 
            this.lvwSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwSegments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCurrentTry,
            this.columnSegProgress,
            this.columnSegCompleted,
            this.columnSegSize,
            this.columnStartPosition,
            this.columnEndPosition,
            this.columnSegRate,
            this.columnSegLeft,
            this.columnSegState,
            this.columnCurrURL});
            this.lvwSegments.FullRowSelect = true;
            this.lvwSegments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwSegments.HideSelection = false;
            this.lvwSegments.Location = new System.Drawing.Point(3, 30);
            this.lvwSegments.Name = "lvwSegments";
            this.lvwSegments.ShowGroups = false;
            this.lvwSegments.ShowItemToolTips = true;
            this.lvwSegments.Size = new System.Drawing.Size(708, 162);
            this.lvwSegments.TabIndex = 1;
            this.lvwSegments.UseCompatibleStateImageBehavior = false;
            this.lvwSegments.View = System.Windows.Forms.View.Details;
            // 
            // columnCurrentTry
            // 
            this.columnCurrentTry.Text = "Current Try";
            this.columnCurrentTry.Width = 66;
            // 
            // columnSegProgress
            // 
            this.columnSegProgress.Text = "Progress";
            this.columnSegProgress.Width = 80;
            // 
            // columnSegCompleted
            // 
            this.columnSegCompleted.Text = "Completed";
            this.columnSegCompleted.Width = 81;
            // 
            // columnSegSize
            // 
            this.columnSegSize.Text = "Size";
            this.columnSegSize.Width = 77;
            // 
            // columnStartPosition
            // 
            this.columnStartPosition.Text = "Start Position";
            this.columnStartPosition.Width = 97;
            // 
            // columnEndPosition
            // 
            this.columnEndPosition.Text = "End Position";
            this.columnEndPosition.Width = 100;
            // 
            // columnSegRate
            // 
            this.columnSegRate.Text = "Rate";
            this.columnSegRate.Width = 55;
            // 
            // columnSegLeft
            // 
            this.columnSegLeft.Text = "Left";
            this.columnSegLeft.Width = 80;
            // 
            // columnSegState
            // 
            this.columnSegState.Text = "State";
            this.columnSegState.Width = 133;
            // 
            // columnCurrURL
            // 
            this.columnCurrURL.Text = "Current URL";
            this.columnCurrURL.Width = 100;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.richLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(714, 195);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // richLog
            // 
            this.richLog.BackColor = System.Drawing.SystemColors.Window;
            this.richLog.ContextMenuStrip = this.logContextMenu;
            this.richLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richLog.Location = new System.Drawing.Point(3, 3);
            this.richLog.Name = "richLog";
            this.richLog.ReadOnly = true;
            this.richLog.Size = new System.Drawing.Size(708, 189);
            this.richLog.TabIndex = 0;
            this.richLog.Text = "";
            this.richLog.WordWrap = false;
            // 
            // logContextMenu
            // 
            this.logContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
            this.logContextMenu.Name = "logContextMenu";
            this.logContextMenu.Size = new System.Drawing.Size(131, 26);
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.clearLogToolStripMenuItem.Text = "Clear Log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // DownloadList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "DownloadList";
            this.Size = new System.Drawing.Size(722, 436);
            this.Load += new System.EventHandler(this.DownloadList_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.popUpContextMenu.ResumeLayout(false);
            this.tabSegmentsLogs.ResumeLayout(false);
            this.tabSegments.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.logContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView lvwDownloads;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnCompleted;
        private System.Windows.Forms.ColumnHeader columnProgress;
        private System.Windows.Forms.ColumnHeader columnLeft;
        private System.Windows.Forms.ColumnHeader columnRate;
        private System.Windows.Forms.ColumnHeader columnAdded;
        private System.Windows.Forms.ColumnHeader columnState;
        private System.Windows.Forms.ColumnHeader columnURL;
        private System.Windows.Forms.TabControl tabSegmentsLogs;
        private System.Windows.Forms.TabPage tabSegments;
        private System.Windows.Forms.ListView lvwSegments;
        private System.Windows.Forms.ColumnHeader columnCurrentTry;
        private System.Windows.Forms.ColumnHeader columnSegProgress;
        private System.Windows.Forms.ColumnHeader columnSegCompleted;
        private System.Windows.Forms.ColumnHeader columnSegSize;
        private System.Windows.Forms.ColumnHeader columnStartPosition;
        private System.Windows.Forms.ColumnHeader columnEndPosition;
        private System.Windows.Forms.ColumnHeader columnSegRate;
        private System.Windows.Forms.ColumnHeader columnSegLeft;
        private System.Windows.Forms.ColumnHeader columnSegState;
        private System.Windows.Forms.ColumnHeader columnCurrURL;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.ContextMenuStrip logContextMenu;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip popUpContextMenu;
        private System.Windows.Forms.ToolStripMenuItem newDownloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyURLToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInExplorerToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnResume;
        private MyDownloader.App.Controls.BlockedProgressBar blockedProgressBar1;
    }
}
