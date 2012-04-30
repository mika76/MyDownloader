using System;
using System.Collections.Generic;
using System.Text;
using MyDownloader.Spider.Parsers.Html;

namespace MyDownloader.Spider.Web.Rules
{
    public class BaseLocationNamingRule: INamingRule
    {
        private bool downloadImagesFromExternalSite;
        private bool downloadResourceFromExternalSite;

        public BaseLocationNamingRule(
            bool downloadImagesFromExternalSite,
            bool downloadResourceFromExternalSite)
        {
            this.downloadImagesFromExternalSite = downloadImagesFromExternalSite;
            this.downloadResourceFromExternalSite = downloadResourceFromExternalSite;
        }

        #region INamingRule Members

        public bool Accept(Uri location, SpiderContext context, ISpiderResource parentSpider)
        {
            UrlType urlType = ((WebSpiderResource)parentSpider).addingUrlType;
            
            if (
            !(urlType == UrlType.Img && this.downloadImagesFromExternalSite)
                &&
            !(urlType != UrlType.Img && this.downloadResourceFromExternalSite)
                )
            {
                string tempbase = context.BaseLocation;
                int i;

                if ((i = tempbase.LastIndexOf("/")) >= 0)
                {
                    tempbase = tempbase.Substring(0, i + 1);
                }

                if (!location.OriginalString.StartsWith(tempbase))
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
