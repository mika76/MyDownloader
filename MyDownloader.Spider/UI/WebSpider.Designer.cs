using MyDownloader.Core.UI;
using MyDownloader.App.UI;

namespace MyDownloader.Spider.UI
{
    partial class WebSpider
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
            this.btnDownloadSite = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotalFiles = new System.Windows.Forms.Label();
            this.lblDownloadedFiles = new System.Windows.Forms.Label();
            this.progDownload = new System.Windows.Forms.ProgressBar();
            this.tabParams = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkResourcesFromExternal = new System.Windows.Forms.CheckBox();
            this.chkImagesFromExternal = new System.Windows.Forms.CheckBox();
            this.location1 = new MyDownloader.App.UI.Location();
            this.numDownloadDepth = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.chkRemoveCompleted = new System.Windows.Forms.CheckBox();
            this.folderBrowser1 = new MyDownloader.Core.UI.DownloadFolder();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtExcludeExt = new System.Windows.Forms.TextBox();
            this.chkExcludeExtensions = new System.Windows.Forms.CheckBox();
            this.txtExcludeNames = new System.Windows.Forms.TextBox();
            this.chkExcludeNames = new System.Windows.Forms.CheckBox();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.waitControl1 = new MyDownloader.Core.UI.WaitControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabParams.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadDepth)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownloadSite
            // 
            this.btnDownloadSite.Location = new System.Drawing.Point(0, 222);
            this.btnDownloadSite.Name = "btnDownloadSite";
            this.btnDownloadSite.Size = new System.Drawing.Size(115, 23);
            this.btnDownloadSite.TabIndex = 1;
            this.btnDownloadSite.Text = "Download Site";
            this.btnDownloadSite.UseVisualStyleBackColor = true;
            this.btnDownloadSite.Click += new System.EventHandler(this.btnDownloadSite_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(121, 222);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Downloaded files:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total files:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTotalFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDownloadedFiles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progDownload, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 248);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(466, 56);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Progress:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalFiles
            // 
            this.lblTotalFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalFiles.Location = new System.Drawing.Point(142, 18);
            this.lblTotalFiles.Name = "lblTotalFiles";
            this.lblTotalFiles.Size = new System.Drawing.Size(321, 18);
            this.lblTotalFiles.TabIndex = 3;
            this.lblTotalFiles.Text = "0";
            this.lblTotalFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadedFiles
            // 
            this.lblDownloadedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDownloadedFiles.Location = new System.Drawing.Point(142, 0);
            this.lblDownloadedFiles.Name = "lblDownloadedFiles";
            this.lblDownloadedFiles.Size = new System.Drawing.Size(321, 18);
            this.lblDownloadedFiles.TabIndex = 1;
            this.lblDownloadedFiles.Text = "0";
            this.lblDownloadedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progDownload
            // 
            this.progDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progDownload.Location = new System.Drawing.Point(142, 39);
            this.progDownload.Name = "progDownload";
            this.progDownload.Size = new System.Drawing.Size(321, 14);
            this.progDownload.TabIndex = 5;
            this.progDownload.Value = 50;
            // 
            // tabParams
            // 
            this.tabParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabParams.Controls.Add(this.tabPage1);
            this.tabParams.Controls.Add(this.tabPage2);
            this.tabParams.Location = new System.Drawing.Point(0, 1);
            this.tabParams.Name = "tabParams";
            this.tabParams.SelectedIndex = 0;
            this.tabParams.Size = new System.Drawing.Size(467, 215);
            this.tabParams.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.chkResourcesFromExternal);
            this.tabPage1.Controls.Add(this.chkImagesFromExternal);
            this.tabPage1.Controls.Add(this.location1);
            this.tabPage1.Controls.Add(this.numDownloadDepth);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.chkRemoveCompleted);
            this.tabPage1.Controls.Add(this.folderBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parameters";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkResourcesFromExternal
            // 
            this.chkResourcesFromExternal.AutoSize = true;
            this.chkResourcesFromExternal.Location = new System.Drawing.Point(0, 168);
            this.chkResourcesFromExternal.Name = "chkResourcesFromExternal";
            this.chkResourcesFromExternal.Size = new System.Drawing.Size(210, 17);
            this.chkResourcesFromExternal.TabIndex = 4;
            this.chkResourcesFromExternal.Text = "Download resources from external sites";
            this.chkResourcesFromExternal.UseVisualStyleBackColor = true;
            // 
            // chkImagesFromExternal
            // 
            this.chkImagesFromExternal.AutoSize = true;
            this.chkImagesFromExternal.Location = new System.Drawing.Point(0, 152);
            this.chkImagesFromExternal.Name = "chkImagesFromExternal";
            this.chkImagesFromExternal.Size = new System.Drawing.Size(197, 17);
            this.chkImagesFromExternal.TabIndex = 3;
            this.chkImagesFromExternal.Text = "Download images from external sites";
            this.chkImagesFromExternal.UseVisualStyleBackColor = true;
            // 
            // location1
            // 
            this.location1.Dock = System.Windows.Forms.DockStyle.Top;
            this.location1.Location = new System.Drawing.Point(3, 45);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(453, 91);
            this.location1.TabIndex = 1;
            this.location1.UrlLabelTitle = "URL";
            // 
            // numDownloadDepth
            // 
            this.numDownloadDepth.Location = new System.Drawing.Point(288, 152);
            this.numDownloadDepth.Name = "numDownloadDepth";
            this.numDownloadDepth.Size = new System.Drawing.Size(120, 20);
            this.numDownloadDepth.TabIndex = 6;
            this.numDownloadDepth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Download depth (0 for infinite):";
            // 
            // chkRemoveCompleted
            // 
            this.chkRemoveCompleted.AutoSize = true;
            this.chkRemoveCompleted.Location = new System.Drawing.Point(0, 136);
            this.chkRemoveCompleted.Name = "chkRemoveCompleted";
            this.chkRemoveCompleted.Size = new System.Drawing.Size(210, 17);
            this.chkRemoveCompleted.TabIndex = 2;
            this.chkRemoveCompleted.Text = "Remove completed downloads from list";
            this.chkRemoveCompleted.UseVisualStyleBackColor = true;
            // 
            // folderBrowser1
            // 
            this.folderBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.folderBrowser1.LabelText = "Save to:";
            this.folderBrowser1.Location = new System.Drawing.Point(3, 3);
            this.folderBrowser1.Name = "folderBrowser1";
            this.folderBrowser1.Size = new System.Drawing.Size(453, 42);
            this.folderBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.AutoScrollMargin = new System.Drawing.Size(0, 8);
            this.tabPage2.Controls.Add(this.txtExcludeExt);
            this.tabPage2.Controls.Add(this.chkExcludeExtensions);
            this.tabPage2.Controls.Add(this.txtExcludeNames);
            this.tabPage2.Controls.Add(this.chkExcludeNames);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtExcludeExt
            // 
            this.txtExcludeExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeExt.Enabled = false;
            this.txtExcludeExt.Location = new System.Drawing.Point(8, 64);
            this.txtExcludeExt.Name = "txtExcludeExt";
            this.txtExcludeExt.Size = new System.Drawing.Size(422, 20);
            this.txtExcludeExt.TabIndex = 3;
            // 
            // chkExcludeExtensions
            // 
            this.chkExcludeExtensions.AutoSize = true;
            this.chkExcludeExtensions.Location = new System.Drawing.Point(8, 48);
            this.chkExcludeExtensions.Name = "chkExcludeExtensions";
            this.chkExcludeExtensions.Size = new System.Drawing.Size(262, 17);
            this.chkExcludeExtensions.TabIndex = 2;
            this.chkExcludeExtensions.Text = "Exclude files with extension (separated by comma)";
            this.chkExcludeExtensions.UseVisualStyleBackColor = true;
            this.chkExcludeExtensions.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // txtExcludeNames
            // 
            this.txtExcludeNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExcludeNames.Enabled = false;
            this.txtExcludeNames.Location = new System.Drawing.Point(8, 24);
            this.txtExcludeNames.Name = "txtExcludeNames";
            this.txtExcludeNames.Size = new System.Drawing.Size(422, 20);
            this.txtExcludeNames.TabIndex = 1;
            // 
            // chkExcludeNames
            // 
            this.chkExcludeNames.AutoSize = true;
            this.chkExcludeNames.Location = new System.Drawing.Point(8, 8);
            this.chkExcludeNames.Name = "chkExcludeNames";
            this.chkExcludeNames.Size = new System.Drawing.Size(285, 17);
            this.chkExcludeNames.TabIndex = 0;
            this.chkExcludeNames.Text = "Exclude files that name contains (separated by comma)";
            this.chkExcludeNames.UseVisualStyleBackColor = true;
            this.chkExcludeNames.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Interval = 1500;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // waitControl1
            // 
            this.waitControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waitControl1.Location = new System.Drawing.Point(200, 224);
            this.waitControl1.Name = "waitControl1";
            this.waitControl1.Size = new System.Drawing.Size(257, 16);
            this.waitControl1.TabIndex = 5;
            this.waitControl1.Text = "Downloading site, please wait...";
            this.waitControl1.Visible = false;
            // 
            // WebSpider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.waitControl1);
            this.Controls.Add(this.tabParams);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnDownloadSite);
            this.Name = "WebSpider";
            this.Size = new System.Drawing.Size(470, 348);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabParams.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadDepth)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadSite;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotalFiles;
        private System.Windows.Forms.Label label5;
        private DownloadFolder folderBrowser1;
        private System.Windows.Forms.TabControl tabParams;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkRemoveCompleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDownloadDepth;
        private System.Windows.Forms.TextBox txtExcludeNames;
        private System.Windows.Forms.CheckBox chkExcludeNames;
        private System.Windows.Forms.TextBox txtExcludeExt;
        private System.Windows.Forms.CheckBox chkExcludeExtensions;
        private System.Windows.Forms.Label lblDownloadedFiles;
        private System.Windows.Forms.ProgressBar progDownload;
        private Location location1;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.CheckBox chkResourcesFromExternal;
        private System.Windows.Forms.CheckBox chkImagesFromExternal;
        private WaitControl waitControl1;
    }
}
