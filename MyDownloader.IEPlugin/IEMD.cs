using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using BandObjectLib;
using System.Runtime.InteropServices;
using SHDocVw;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading;

namespace MyDownloader.IEPlugin
{
    [Guid("3F93D37D-54B8-4d5d-92CB-6F5644E7A65F")]
	[BandObject("MyDownloader", BandObjectStyle.Horizontal | BandObjectStyle.ExplorerToolbar | BandObjectStyle.TaskbarToolBar)]
	public class IEMD : BandObject
	{
        private System.Windows.Forms.Button btnDownload;
        private IContainer components;
		private const int IE_TRUE = 1;
        private const int IE_FALSE = 0;
        private ToolTip toolTips;
        VideoSitesRepository videoSites;

        DateTime lastDownload = DateTime.Now;
        private Button btnOpenDownloader;
        string lastUrl = "";

        public IEMD()
		{			
			InitializeComponent();
			
            btnDownload.Enabled = false;

            videoSites = new VideoSitesRepository();
		}

        #region Component Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IEMD));
            this.btnDownload = new System.Windows.Forms.Button();
            this.toolTips = new System.Windows.Forms.ToolTip(this.components);
            this.btnOpenDownloader = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownload.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(0, 0);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(24, 21);
            this.btnDownload.TabIndex = 1;
            this.toolTips.SetToolTip(this.btnDownload, "Download video using MyDownloader");
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnOpenDownloader
            // 
            this.btnOpenDownloader.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenDownloader.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnOpenDownloader.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDownloader.Image")));
            this.btnOpenDownloader.Location = new System.Drawing.Point(26, 0);
            this.btnOpenDownloader.Name = "btnOpenDownloader";
            this.btnOpenDownloader.Size = new System.Drawing.Size(24, 21);
            this.btnOpenDownloader.TabIndex = 2;
            this.toolTips.SetToolTip(this.btnOpenDownloader, "Lauch MyDownloader");
            this.btnOpenDownloader.Click += new System.EventHandler(this.btnOpenDownloader_Click);
            // 
            // IEMD
            // 
            this.Controls.Add(this.btnOpenDownloader);
            this.Controls.Add(this.btnDownload);
            this.MinSize = new System.Drawing.Size(52, 21);
            this.Name = "IEMD";
            this.Size = new System.Drawing.Size(52, 21);
            this.Title = "";
            this.ResumeLayout(false);

        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        public SHDocVw.WebBrowser GetIEDocument()
        {
            return (SHDocVw.WebBrowser) this.Explorer;
        }

		protected override void OnExplorerAttached(EventArgs ea)
		{
			SHDocVw.WebBrowser IEDocument = this.GetIEDocument();
			IEDocument.BeforeNavigate2 +=new DWebBrowserEvents2_BeforeNavigate2EventHandler(BeforeNavigate);
			IEDocument.NavigateComplete2 +=new DWebBrowserEvents2_NavigateComplete2EventHandler(AfterNavigate);
            IEDocument.FileDownload += new DWebBrowserEvents2_FileDownloadEventHandler(IEDocument_FileDownload);
				
			base.OnExplorerAttached (ea);			
		}

        void IEDocument_FileDownload(bool ActiveDocument, ref bool Cancel)
        {
            if (!ActiveDocument)
            {
                if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
                {
                    Cancel = true;

                    if ((DateTime.Now - lastDownload).TotalSeconds >= 1.9)
                    {
                        ThreadPool.QueueUserWorkItem(
                            delegate(object state)
                            {
                                DownloadURL(lastUrl);
                            });

                        lastDownload = DateTime.Now;
                    }
                }
            }
        }

        private void DownloadURL(string url)
        {
            try
            {
                Process p;
                if (url != null)
                {
                    p = Process.Start(Settings.MyDownloaderPath, String.Format("/sw {0}", url));
                }
                else
                {
                    p = Process.Start(Settings.MyDownloaderPath);
                }
                p.WaitForInputIdle(5000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void MakeVisible()
		{
			if(GetIEDocument().ToolBar == IE_FALSE)
				//if(Configuration.AlwaysShow)
				{
					this.Visible = true;
                    GetIEDocument().ToolBar = IE_TRUE;
				}
		}

		public void AfterNavigate(object iDisp, ref object URL)
		{
            SHDocVw.WebBrowser IEDocument = GetIEDocument();			
			MakeVisible();
			
			//mshtml.HTMLDocument HTML = (mshtml.HTMLDocument) IEDocument.Document;
            //HTML.cookie
			//HTML.attachEvent(iDisp)

            btnDownload.Enabled = videoSites.IsVideoSite(IEDocument.LocationURL);
		}

		public void BeforeNavigate(object iDisp, ref object URL, ref object Flags, ref object TargetFrameName, ref object PostData, ref object Headers, ref bool Cancel)
		{
            lastUrl = URL.ToString();
		}	
     	
		private void btnDownload_Click(object sender, System.EventArgs e)
		{
			try
			{		
				SHDocVw.WebBrowser IEDocument = GetIEDocument();

                DownloadURL(IEDocument.LocationURL);
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void btnOpenDownloader_Click(object sender, EventArgs e)
        {
            DownloadURL(null);
        }
	}
}