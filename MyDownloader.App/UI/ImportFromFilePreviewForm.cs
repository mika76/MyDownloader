using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Core;

namespace MyDownloader.App.UI
{
    public partial class ImportFromFilePreviewForm : Form
    {
        public ImportFromFilePreviewForm(ResourceLocation[] locations)
        {
            InitializeComponent();

            lslUrls.DataSource = locations;
        }
    }
}