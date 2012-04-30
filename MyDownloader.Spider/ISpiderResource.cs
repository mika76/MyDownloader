using System;
using System.Collections.Generic;
using System.Text;
using MyDownloader.Core;
using System.Text.RegularExpressions;
using System.Net.Mime;
using System.IO;
using System.Threading;

namespace MyDownloader.Spider
{
    public interface ISpiderResource
    {
        string Location { get; }

        int Depth { get; }

        ISpiderResource ParentResource { get; }

        List<ISpiderResource> NextResources { get; }

        IAsyncRetriver BeginReceive();

        void EndReceive();
    }
}
