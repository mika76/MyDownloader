using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider.Web.Rules
{
    class ExcludeNameNamingRule: INamingRule
    {
        string[] namesToExclude;

        public ExcludeNameNamingRule(string[] namesToExclude)
        {
            for (int i = 0; i < namesToExclude.Length; i++)
            {
                namesToExclude[i] = namesToExclude[i].ToLower();
            }

            this.namesToExclude = namesToExclude;
        }

        #region INamingRule Members

        public bool Accept(Uri uri, SpiderContext context, ISpiderResource parentSpider)
        {
            string fileName = uri.Segments[uri.Segments.Length - 1];

            for (int i = 0; i < namesToExclude.Length; i++)
            {
                if (fileName.IndexOf(namesToExclude[i]) >= 0)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}
