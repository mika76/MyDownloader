using MyDownloader.Core.UI;
namespace MyDownloader.App.UI
{
    partial class CreateBatchDownloadForm
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
            this.numSegments = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoNumbers = new System.Windows.Forms.RadioButton();
            this.rdoLetters = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvwListPreview = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numWildcard = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.numTo = new System.Windows.Forms.NumericUpDown();
            this.folderBrowser1 = new MyDownloader.Core.UI.DownloadFolder();
            this.location1 = new MyDownloader.App.UI.Location();
            this.scheduledDownloadEnabler1 = new MyDownloader.Extension.AutoDownloads.UI.ScheduledDownloadEnabler();
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWildcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).BeginInit();
            this.SuspendLayout();
            // 
            // numSegments
            // 
            this.numSegments.Location = new System.Drawing.Point(401, 110);
            this.numSegments.Name = "numSegments";
            this.numSegments.Size = new System.Drawing.Size(75, 20);
            this.numSegments.TabIndex = 13;
            this.numSegments.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Segments";
            // 
            // rdoNumbers
            // 
            this.rdoNumbers.AutoSize = true;
            this.rdoNumbers.Checked = true;
            this.rdoNumbers.Location = new System.Drawing.Point(7, 95);
            this.rdoNumbers.Name = "rdoNumbers";
            this.rdoNumbers.Size = new System.Drawing.Size(45, 17);
            this.rdoNumbers.TabIndex = 1;
            this.rdoNumbers.TabStop = true;
            this.rdoNumbers.Text = "from";
            this.rdoNumbers.UseVisualStyleBackColor = true;
            this.rdoNumbers.CheckedChanged += new System.EventHandler(this.rdoNumbers_CheckedChanged);
            // 
            // rdoLetters
            // 
            this.rdoLetters.AutoSize = true;
            this.rdoLetters.Location = new System.Drawing.Point(7, 124);
            this.rdoLetters.Name = "rdoLetters";
            this.rdoLetters.Size = new System.Drawing.Size(45, 17);
            this.rdoLetters.TabIndex = 7;
            this.rdoLetters.TabStop = true;
            this.rdoLetters.Text = "from";
            this.rdoLetters.UseVisualStyleBackColor = true;
            this.rdoLetters.CheckedChanged += new System.EventHandler(this.rdoNumbers_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "to";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(139, 123);
            this.txtTo.MaxLength = 1;
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(52, 20);
            this.txtTo.TabIndex = 10;
            this.txtTo.TextChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "to";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(59, 123);
            this.txtFrom.MaxLength = 1;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(52, 20);
            this.txtFrom.TabIndex = 8;
            this.txtFrom.TextChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Download list preview:";
            // 
            // lvwListPreview
            // 
            this.lvwListPreview.FormattingEnabled = true;
            this.lvwListPreview.Location = new System.Drawing.Point(8, 208);
            this.lvwListPreview.Name = "lvwListPreview";
            this.lvwListPreview.Size = new System.Drawing.Size(468, 95);
            this.lvwListPreview.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(400, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(319, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Length of wildcard:";
            // 
            // numWildcard
            // 
            this.numWildcard.Location = new System.Drawing.Point(300, 94);
            this.numWildcard.Name = "numWildcard";
            this.numWildcard.Size = new System.Drawing.Size(75, 20);
            this.numWildcard.TabIndex = 6;
            this.numWildcard.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWildcard.ValueChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "(case sensitive)";
            // 
            // numFrom
            // 
            this.numFrom.Location = new System.Drawing.Point(59, 94);
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(52, 20);
            this.numFrom.TabIndex = 2;
            this.numFrom.ValueChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // numTo
            // 
            this.numTo.Location = new System.Drawing.Point(139, 94);
            this.numTo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numTo.Name = "numTo";
            this.numTo.Size = new System.Drawing.Size(52, 20);
            this.numTo.TabIndex = 4;
            this.numTo.ValueChanged += new System.EventHandler(this.numFrom_ValueChanged);
            // 
            // folderBrowser1
            // 
            this.folderBrowser1.LabelText = "Save to:";
            this.folderBrowser1.Location = new System.Drawing.Point(7, 149);
            this.folderBrowser1.Name = "folderBrowser1";
            this.folderBrowser1.Size = new System.Drawing.Size(468, 42);
            this.folderBrowser1.TabIndex = 14;
            // 
            // location1
            // 
            this.location1.Location = new System.Drawing.Point(7, 0);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(468, 87);
            this.location1.TabIndex = 0;
            this.location1.UrlLabelTitle = "URL (e.g http://download.microsoft.com/file(*).zip)";
            // 
            // scheduledDownloadEnabler1
            // 
            this.scheduledDownloadEnabler1.Location = new System.Drawing.Point(8, 304);
            this.scheduledDownloadEnabler1.Name = "scheduledDownloadEnabler1";
            this.scheduledDownloadEnabler1.Size = new System.Drawing.Size(468, 164);
            this.scheduledDownloadEnabler1.TabIndex = 17;
            // 
            // CreateBatchDownloadForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(482, 499);
            this.Controls.Add(this.scheduledDownloadEnabler1);
            this.Controls.Add(this.folderBrowser1);
            this.Controls.Add(this.location1);
            this.Controls.Add(this.numTo);
            this.Controls.Add(this.numFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numWildcard);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvwListPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdoLetters);
            this.Controls.Add(this.rdoNumbers);
            this.Controls.Add(this.numSegments);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateBatchDownloadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create batch download";
            this.Load += new System.EventHandler(this.CreateBatchDownloadForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWildcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSegments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNumbers;
        private System.Windows.Forms.RadioButton rdoLetters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lvwListPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWildcard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.NumericUpDown numTo;
        private Location location1;
        private DownloadFolder folderBrowser1;
        private MyDownloader.Extension.AutoDownloads.UI.ScheduledDownloadEnabler scheduledDownloadEnabler1;
	}
}