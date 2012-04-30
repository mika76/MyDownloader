using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Spider.Web.Rules;
using MyDownloader.Core;
using MyDownloader.Extension.AutoDownloads;
using MyDownloader.Core.UI;
using MyDownloader.Spider.Web;

namespace MyDownloader.Spider.UI
{
    public partial class WebSpider : UserControl
    {
        public WebSpider()
        {
            InitializeComponent();

            EnterDownloadMode(false);

            UpdateInputBasesOnCheckBoxes();
        }

        Spider siteSpider;

        private void btnDownloadSite_Click(object sender, EventArgs e)
        {
            ResourceLocation rl = this.location1.ResourceLocation;

            rl.BindProtocolProviderType();

            if (rl.ProtocolProviderType == null)
            {
                MessageBox.Show("Invalid URL format, please check the location field.",
                    AppManager.Instance.Application.MainForm.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AutoDownloadsExtension scheduler;

            scheduler = (AutoDownloadsExtension)AppManager.Instance.Application.GetExtensionByType(typeof(AutoDownloadsExtension));

            if (! scheduler.Active)
            {
                using (StartAutoDownloadsForm startAd = new StartAutoDownloadsForm())
                {
                    if (startAd.ShowDialog() == DialogResult.Yes)
                    {
                        startAd.ScheduledDownloadEnabler.ApplySettings();
                    }
                }

                if (!scheduler.Active)
                {
                    return;
                }
            }

            SpiderContext spiderCntx = new SpiderContext(
                folderBrowser1.Folder,
                rl.URL);

            spiderCntx.NamingRules.Add(
                new BaseLocationNamingRule(chkImagesFromExternal.Checked, chkResourcesFromExternal.Checked));

            if (chkExcludeExtensions.Checked)
            {
                spiderCntx.NamingRules.Add(new ExcludeExtensionNamingRule(txtExcludeExt.Text.Split(',')));
            }
            if (chkExcludeNames.Checked)
            {
                spiderCntx.NamingRules.Add(new ExcludeNameNamingRule(txtExcludeNames.Text.Split(',')));
            }
            if (numDownloadDepth.Value > 0)
            {
                spiderCntx.NamingRules.Add(new MaxDepthNamingRule((int)numDownloadDepth.Value));
            }
            if (chkRemoveCompleted.Checked)
            {
                spiderCntx.ResourceCompleted += delegate(SpiderContext cntx, ISpiderResource resource)
                {
                    DownloadManager.Instance.ClearEnded();
                };
            }

            siteSpider = new Spider(spiderCntx, new WebSpiderResourceFactory());
            siteSpider.Completed += new CompletedEventHandler(siteSpider_Completed);
            siteSpider.Aborted += new EventHandler(siteSpider_Aborted);
            siteSpider.BeginLookup();

            EnterDownloadMode(true);
        }

        private void EnterDownloadMode(bool downloading)
        {
            RefreshStatus();

            progDownload.Value = 0;
            tabParams.Enabled = !downloading;
            btnAbort.Enabled = downloading;
            btnDownloadSite.Enabled = !downloading;
            waitControl1.Visible = downloading;
            tmrRefresh.Enabled = downloading;
        }

        void siteSpider_Aborted(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate() { EnterDownloadMode(false); });
        }

        void siteSpider_Completed(SpiderContext cntx)
        {
            this.BeginInvoke((MethodInvoker)delegate() { EnterDownloadMode(false); });
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            siteSpider.Abort();            
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            float totalVisited; 
            float totalDownloaded;

            if (siteSpider != null)
            {
                totalVisited = siteSpider.Context.VisitedLocations.Count;
                totalDownloaded = siteSpider.Context.CompletedResources.Count;
            }
            else
            {
                totalVisited = totalDownloaded = 0;
            }

            lblTotalFiles.Text = totalVisited.ToString();
            lblDownloadedFiles.Text = totalDownloaded.ToString();

            try
            {
                if (totalVisited != 0)
                {
                    progDownload.Value = (int)((totalDownloaded / totalVisited) * 100);
                }
                else
                {
                    progDownload.Value = 0;
                }
            }
            catch (Exception)
            {
            }
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInputBasesOnCheckBoxes();
        }

        private void UpdateInputBasesOnCheckBoxes()
        {
            txtExcludeExt.Enabled = chkExcludeExtensions.Checked;
            txtExcludeNames.Enabled = chkExcludeNames.Checked;
        }
    }
}