using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace MyDownloader.IEPlugin
{
    internal static class Settings
    {
        private const string ROOTREG = "SOFTWARE\\MyDownloader";

        public static string MyDownloaderPath
        {
            get
            {
                return GetValue("MyDownloaderPath");
            }
        }

        private static string GetValue(string Key)
        {
            using (RegistryKey RKey = Registry.LocalMachine.CreateSubKey(ROOTREG))
            {
                return RKey.GetValue(Key, "").ToString();
            }
        }
    }
}
