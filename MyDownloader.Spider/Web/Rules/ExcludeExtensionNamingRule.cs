using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MyDownloader.Spider.Web.Rules
{
    public class ExcludeExtensionNamingRule: INamingRule
    {
        string[] extensionsToExclude;

        public ExcludeExtensionNamingRule(string[] extensionsToExclude)
        {
            for (int i = 0; i < extensionsToExclude.Length; i++)
            {
                extensionsToExclude[i] = extensionsToExclude[i].ToLower();
            }

            this.extensionsToExclude = extensionsToExclude;
        }

        #region INamingRule Members

        public bool Accept(Uri location, SpiderContext context, ISpiderResource parentSpider)
        {
            string ext = Path.GetExtension(location.Segments[location.Segments.Length-1]).ToLower();

            int index = Array.IndexOf<string>(this.extensionsToExclude, ext);

            return index < 0;
        }

        #endregion
    }
}
