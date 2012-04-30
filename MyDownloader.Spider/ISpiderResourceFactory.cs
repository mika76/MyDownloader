using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider
{
    public interface ISpiderResourceFactory
    {
        ISpiderResource CreateSpider(SpiderContext cntx, ISpiderResource parent, string location);
    }
}
