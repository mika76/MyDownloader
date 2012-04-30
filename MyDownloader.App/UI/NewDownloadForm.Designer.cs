using MyDownloader.Core.UI;
namespace MyDownloader.App.UI
{
    partial class NewDownloadForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkChooseZIP = new System.Windows.Forms.CheckBox();
            this.pnlFileName = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.folderBrowser1 = new MyDownloader.Core.UI.DownloadFolder();
            this.chkStartNow = new System.Windows.Forms.CheckBox();
            this.pnlSegments = new System.Windows.Forms.Panel();
            this.numSegments = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.locationMain = new MyDownloader.App.UI.Location();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.locationAlternate = new MyDownloader.App.UI.Location();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwLocations = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.waitControl1 = new MyDownloader.Core.UI.WaitControl();
            this.backgroundWorkerRetriveZIPInformation = new System.ComponentModel.BackgroundWorker();
            this.checkableTreeView1 = new MyDownloader.App.Controls.CheckableTreeView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFileName.SuspendLayout();
            this.pnlSegments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(328, 589);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(409, 589);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 573);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.locationMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Controls.Add(this.chkChooseZIP);
            this.tableLayoutPanel1.Controls.Add(this.pnlFileName);
            this.tableLayoutPanel1.Controls.Add(this.checkableTreeView1);
            this.tableLayoutPanel1.Controls.Add(this.folderBrowser1);
            this.tableLayoutPanel1.Controls.Add(this.chkStartNow);
            this.tableLayoutPanel1.Controls.Add(this.pnlSegments);
            this.tableLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 88);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 456);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkChooseZIP
            // 
            this.chkChooseZIP.Location = new System.Drawing.Point(3, 3);
            this.chkChooseZIP.Name = "chkChooseZIP";
            this.chkChooseZIP.Size = new System.Drawing.Size(400, 20);
            this.chkChooseZIP.TabIndex = 0;
            this.chkChooseZIP.Text = "Choose files inside ZIP";
            this.chkChooseZIP.UseVisualStyleBackColor = true;
            this.chkChooseZIP.CheckedChanged += new System.EventHandler(this.chkChooseZIP_CheckedChanged);
            // 
            // pnlFileName
            // 
            this.pnlFileName.Controls.Add(this.label4);
            this.pnlFileName.Controls.Add(this.txtFilename);
            this.pnlFileName.Location = new System.Drawing.Point(3, 29);
            this.pnlFileName.Name = "pnlFileName";
            this.pnlFileName.Size = new System.Drawing.Size(448, 40);
            this.pnlFileName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "File name:";
            // 
            // txtFilename
            // 
            this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilename.Location = new System.Drawing.Point(0, 17);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(448, 20);
            this.txtFilename.TabIndex = 2;
            // 
            // folderBrowser1
            // 
            this.folderBrowser1.LabelText = "Save to:";
            this.folderBrowser1.Location = new System.Drawing.Point(3, 342);
            this.folderBrowser1.Name = "folderBrowser1";
            this.folderBrowser1.Size = new System.Drawing.Size(447, 42);
            this.folderBrowser1.TabIndex = 3;
            // 
            // chkStartNow
            // 
            this.chkStartNow.Location = new System.Drawing.Point(3, 390);
            this.chkStartNow.Name = "chkStartNow";
            this.chkStartNow.Size = new System.Drawing.Size(449, 17);
            this.chkStartNow.TabIndex = 4;
            this.chkStartNow.Text = "Start Now";
            this.chkStartNow.UseVisualStyleBackColor = true;
            // 
            // pnlSegments
            // 
            this.pnlSegments.Controls.Add(this.numSegments);
            this.pnlSegments.Controls.Add(this.label2);
            this.pnlSegments.Location = new System.Drawing.Point(3, 413);
            this.pnlSegments.Name = "pnlSegments";
            this.pnlSegments.Size = new System.Drawing.Size(448, 37);
            this.pnlSegments.TabIndex = 9;
            // 
            // numSegments
            // 
            this.numSegments.Location = new System.Drawing.Point(0, 16);
            this.numSegments.Name = "numSegments";
            this.numSegments.Size = new System.Drawing.Size(75, 20);
            this.numSegments.TabIndex = 1;
            this.numSegments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Segments";
            // 
            // locationMain
            // 
            this.locationMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.locationMain.Location = new System.Drawing.Point(8, 3);
            this.locationMain.Name = "locationMain";
            this.locationMain.Size = new System.Drawing.Size(453, 85);
            this.locationMain.TabIndex = 0;
            this.locationMain.UrlLabelTitle = "URL";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.locationAlternate);
            this.tabPage2.Controls.Add(this.btnRemove);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lvwLocations);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alternate URL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // locationAlternate
            // 
            this.locationAlternate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.locationAlternate.Location = new System.Drawing.Point(8, 3);
            this.locationAlternate.Name = "locationAlternate";
            this.locationAlternate.Size = new System.Drawing.Size(447, 98);
            this.locationAlternate.TabIndex = 0;
            this.locationAlternate.UrlLabelTitle = "URL";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(154, 107);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(142, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add / Update Selection";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwLocations
            // 
            this.lvwLocations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwLocations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwLocations.FullRowSelect = true;
            this.lvwLocations.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwLocations.HideSelection = false;
            this.lvwLocations.Location = new System.Drawing.Point(6, 130);
            this.lvwLocations.MultiSelect = false;
            this.lvwLocations.Name = "lvwLocations";
            this.lvwLocations.Size = new System.Drawing.Size(447, 388);
            this.lvwLocations.TabIndex = 3;
            this.lvwLocations.UseCompatibleStateImageBehavior = false;
            this.lvwLocations.View = System.Windows.Forms.View.Details;
            this.lvwLocations.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvwLocations_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "URL";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Authenticate?";
            this.columnHeader4.Width = 86;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Password";
            this.columnHeader3.Width = 83;
            // 
            // waitControl1
            // 
            this.waitControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.waitControl1.Location = new System.Drawing.Point(8, 592);
            this.waitControl1.Name = "waitControl1";
            this.waitControl1.Size = new System.Drawing.Size(232, 16);
            this.waitControl1.TabIndex = 3;
            this.waitControl1.Text = "Loading zip contents...";
            this.waitControl1.Visible = false;
            // 
            // checkableTreeView1
            // 
            this.checkableTreeView1.CheckBoxes = true;
            this.checkableTreeView1.Location = new System.Drawing.Point(3, 75);
            this.checkableTreeView1.Name = "checkableTreeView1";
            this.checkableTreeView1.Size = new System.Drawing.Size(449, 261);
            this.checkableTreeView1.TabIndex = 2;
            // 
            // NewDownloadForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 618);
            this.Controls.Add(this.waitControl1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDownloadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Download";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDownloadForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlFileName.ResumeLayout(false);
            this.pnlFileName.PerformLayout();
            this.pnlSegments.ResumeLayout(false);
            this.pnlSegments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private Location locationMain;
        private Location locationAlternate;
        private System.Windows.Forms.ListView lvwLocations;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private DownloadFolder folderBrowser1;
        private System.Windows.Forms.CheckBox chkChooseZIP;
        private System.Windows.Forms.FlowLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilename;
        private MyDownloader.App.Controls.CheckableTreeView checkableTreeView1;
        private System.Windows.Forms.Panel pnlSegments;
        private System.Windows.Forms.NumericUpDown numSegments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkStartNow;
        private WaitControl waitControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRetriveZIPInformation;
    }
}