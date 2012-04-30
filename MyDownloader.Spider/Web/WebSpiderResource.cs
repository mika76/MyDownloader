using System;
using System.Collections.Generic;
using MyDownloader.Core;
using System.IO;
using MyDownloader.Spider.Parsers.Html;

namespace MyDownloader.Spider.Web
{
    public class WebSpiderResource : ISpiderResource
    {
        private string location;
        internal UrlType addingUrlType;
        private int depth;
        private ISpiderResource parent;
        private SpiderContext context;
        private Downloader download;
        private List<ISpiderResource> nextResources = new List<ISpiderResource>();

        public WebSpiderResource(SpiderContext context, ISpiderResource parent, string location)
        {
            this.context = context;
            this.location = location;
            this.parent = parent;

            UpdateDepth();

            string localFile = GetLocalFile();

            download = DownloadManager.Instance.Add(
                    ResourceLocation.FromURL(this.Location),
                    null,
                    localFile,
                    1,
                    false);

            download.StateChanged += new EventHandler(download_StateChanged);
        }

        private void UpdateDepth()
        {
            if (this.parent == null)
            {
                this.depth = 0;
            }
            else
            {
                ISpiderResource tmpParent = this.parent;
                while (tmpParent != null)
                {
                    this.depth++;
                    tmpParent = tmpParent.ParentResource;
                }
            }
        }

        void download_StateChanged(object sender, EventArgs e)
        {
            switch (download.State)
            {
                case DownloaderState.Ended:
                    LoadData();
                    goto case DownloaderState.EndedWithError;
                case DownloaderState.EndedWithError:
                    context.NotifyCompletion(this);
                    break;
            }
        }

        private void LoadData()
        {
            nextResources.Clear();

            if (download.RemoteFileInfo.MimeType.IndexOf("text/html", StringComparison.OrdinalIgnoreCase) < 0)
            {
                return;
            }

            try
            {
                DownloadManager.Instance.OnBeginAddBatchDownloads();

                using (Stream htmlStream = File.OpenRead(download.LocalFile))
                {
                    using (HtmlParser parser = new HtmlParser(htmlStream))
                    {
                        AddUrls(parser.GetHrefs(context.BaseLocation), UrlType.Href);
                        AddUrls(parser.GetImages(context.BaseLocation), UrlType.Img);
                        AddUrls(parser.GetFrames(context.BaseLocation), UrlType.Frame);
                        AddUrls(parser.GetIFrames(context.BaseLocation), UrlType.IFrame);
                    }
                }
            }
            finally
            {
                DownloadManager.Instance.OnEndAddBatchDownloads();
            }
        }

        private void AddUrls(IEnumerable<Uri> uris, UrlType type)
        {
            this.addingUrlType = type;

            IEnumerator<Uri> enumUri = uris.GetEnumerator();

            while (enumUri.MoveNext())
            {
                AddUrl(enumUri.Current);
            }
        }

        private void AddUrl(Uri uri)
        {
            if (this.context.AddURIToVisit(uri, this))
            {
                System.Diagnostics.Debug.WriteLine(uri.OriginalString);

                nextResources.Add(
                    new WebSpiderResource(this.context, this, uri.OriginalString));
            }
        }

        private string GetLocalFile()
        {
            Uri uri = new Uri(this.Location);

            string dirSep = Path.DirectorySeparatorChar.ToString();

            string fileName = String.Concat(uri.Host, string.Join("", uri.Segments));

            string dir =
                this.context.BaseDirectory + 
                dirSep +
                fileName.Replace("/", dirSep);

            if (dir.EndsWith(dirSep))
            {
                dir += "default.html";
            }

            return dir;
        }

        #region ISpiderResource Members

        public IAsyncRetriver BeginReceive()
        {
            download.Start();

            return new DownloaderAsyncRetrive(this, download);
        }

        public void EndReceive()
        {
            download.WaitForConclusion();
        }

        public string Location
        {
            get { return location; }
        }

        public int Depth 
        {
            get { return this.depth; }    
        }

        public ISpiderResource ParentResource
        {
            get
            {
                return this.parent;
            }
        }

        public List<ISpiderResource> NextResources
        {
            get
            {
                return this.nextResources;
            }
        }

        #endregion
    }
}
