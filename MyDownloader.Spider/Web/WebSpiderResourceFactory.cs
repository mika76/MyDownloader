using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider.Web
{
    public class WebSpiderResourceFactory: ISpiderResourceFactory
    {
        #region ISpiderResourceFactory Members

        public ISpiderResource CreateSpider(SpiderContext cntx, ISpiderResource parent, string location)
        {
            return new WebSpiderResource(cntx, parent, location);
        }

        #endregion
    }
}
