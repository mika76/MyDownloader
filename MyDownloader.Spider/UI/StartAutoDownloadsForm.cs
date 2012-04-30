using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Extension.AutoDownloads;
using MyDownloader.Extension.AutoDownloads.UI;

namespace MyDownloader.Spider.UI
{
    public partial class StartAutoDownloadsForm : Form
    {
        public StartAutoDownloadsForm()
        {
            InitializeComponent();
        }

        public ScheduledDownloadEnabler ScheduledDownloadEnabler
        {
            get
            {
                return scheduledDownloadEnabler1;
            }
        }
    }
}