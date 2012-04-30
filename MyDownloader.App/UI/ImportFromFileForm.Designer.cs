namespace MyDownloader.App.UI
{
    partial class ImportFromFileForm
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
            this.btnSelFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTextFile = new System.Windows.Forms.RadioButton();
            this.rdoHTML = new System.Windows.Forms.RadioButton();
            this.btnPreview = new System.Windows.Forms.Button();
            this.location1 = new MyDownloader.App.UI.Location();
            this.downloadFolder1 = new MyDownloader.Core.UI.DownloadFolder();
            this.scheduledDownloadEnabler1 = new MyDownloader.Extension.AutoDownloads.UI.ScheduledDownloadEnabler();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(429, 65);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(26, 23);
            this.btnSelFile.TabIndex = 4;
            this.btnSelFile.Text = "...";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(5, 68);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(422, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File to import:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(383, 408);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.AllowDrop = true;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(302, 408);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "HTML Files (*.html;*.htm)|*.html;*.htm|Text Files (*.txt)|*.txt|All File (*.*)|*." +
                "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTextFile);
            this.groupBox1.Controls.Add(this.rdoHTML);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import from";
            // 
            // rdoTextFile
            // 
            this.rdoTextFile.AutoSize = true;
            this.rdoTextFile.Checked = true;
            this.rdoTextFile.Location = new System.Drawing.Point(6, 19);
            this.rdoTextFile.Name = "rdoTextFile";
            this.rdoTextFile.Size = new System.Drawing.Size(65, 17);
            this.rdoTextFile.TabIndex = 0;
            this.rdoTextFile.TabStop = true;
            this.rdoTextFile.Text = "Text File";
            this.rdoTextFile.UseVisualStyleBackColor = true;
            this.rdoTextFile.CheckedChanged += new System.EventHandler(this.rdoDownloadMode_Changed);
            // 
            // rdoHTML
            // 
            this.rdoHTML.AutoSize = true;
            this.rdoHTML.Location = new System.Drawing.Point(172, 19);
            this.rdoHTML.Name = "rdoHTML";
            this.rdoHTML.Size = new System.Drawing.Size(74, 17);
            this.rdoHTML.TabIndex = 1;
            this.rdoHTML.Text = "HTML File";
            this.rdoHTML.UseVisualStyleBackColor = true;
            this.rdoHTML.CheckedChanged += new System.EventHandler(this.rdoDownloadMode_Changed);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(8, 408);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 23);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview URLs";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // location1
            // 
            this.location1.Enabled = false;
            this.location1.Location = new System.Drawing.Point(5, 142);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(449, 89);
            this.location1.TabIndex = 1;
            this.location1.UrlLabelTitle = "Base URL:";
            // 
            // downloadFolder1
            // 
            this.downloadFolder1.LabelText = "Save to:";
            this.downloadFolder1.Location = new System.Drawing.Point(5, 94);
            this.downloadFolder1.Name = "downloadFolder1";
            this.downloadFolder1.Size = new System.Drawing.Size(450, 42);
            this.downloadFolder1.TabIndex = 5;
            // 
            // scheduledDownloadEnabler1
            // 
            this.scheduledDownloadEnabler1.Location = new System.Drawing.Point(5, 237);
            this.scheduledDownloadEnabler1.Name = "scheduledDownloadEnabler1";
            this.scheduledDownloadEnabler1.Size = new System.Drawing.Size(450, 164);
            this.scheduledDownloadEnabler1.TabIndex = 6;
            // 
            // ImportFromFileForm
            // 
            this.AcceptButton = this.btnOK;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(463, 437);
            this.Controls.Add(this.location1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scheduledDownloadEnabler1);
            this.Controls.Add(this.downloadFolder1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSelFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportFromFileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import from file";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MyDownloader.Core.UI.DownloadFolder downloadFolder1;
        private MyDownloader.Extension.AutoDownloads.UI.ScheduledDownloadEnabler scheduledDownloadEnabler1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.RadioButton rdoTextFile;
        private System.Windows.Forms.RadioButton rdoHTML;
        private Location location1;
    }
}