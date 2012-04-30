using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider.Parsers.Html
{
    public enum UrlType : int
    {
        Href = 0,
        Img = 1,
        IFrame = 2,
        Frame = 3,
    }
}
