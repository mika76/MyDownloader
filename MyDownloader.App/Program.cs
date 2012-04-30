using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using MyDownloader.Core;
using System.Diagnostics;
using System.Windows.Forms;
using MyDownloader.App.UI;
using MyDownloader.Extension.Protocols;
using MyDownloader.Extension.Video;
using MyDownloader.Extension.Video.Impl;

namespace MyDownloader.App
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            App.Instance.Start(args);
        }
    }
}
