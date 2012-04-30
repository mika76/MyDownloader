using System;
using System.Collections.Generic;
using System.Text;

namespace MyDownloader.Spider
{
    public interface IAsyncRetriver
    {
        ISpiderResource Resource { get; }

        bool IsCompleted { get; }
    }
}
