using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider
{
    public interface INamingRule
    {
        bool Accept(Uri location, SpiderContext context, ISpiderResource parentSpider);
    }
}
