using System;
using System.Collections.Generic;
using System.Text;
using MyDownloader.Core;

namespace MyDownloader.Spider.Web
{
    class DownloaderAsyncRetrive : IAsyncRetriver
    {
        Downloader downloader;
        ISpiderResource resource;

        internal DownloaderAsyncRetrive(ISpiderResource resource, Downloader d)
        {
            this.downloader = d;
            this.resource = resource;
        }

        #region IAsyncRetrive Members

        public ISpiderResource Resource
        {
            get { return resource; }
        }

        public bool IsCompleted
        {
            get { return !downloader.IsWorking() ; }
        }

        #endregion
    }
}
