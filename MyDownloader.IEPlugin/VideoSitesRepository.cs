using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace MyDownloader.IEPlugin
{
    internal class VideoSitesRepository
    {
        private List<Regex> videoSites = new List<Regex>();

        #region Constructor
        public VideoSitesRepository()
        {
            LoadVideoSites();
        } 
        #endregion

        #region Methods

        public bool IsVideoSite(string url)
        {
            for (int i = 0; i < videoSites.Count; i++)
            {
                if (videoSites[i].IsMatch(url))
                {
                    return true;
                }
            }

            return false;
        }

        private void LoadVideoSites()
        {
            try
            {
                using (StreamReader urlsStream = new StreamReader(this.GetType().Assembly.GetManifestResourceStream("MyDownloader.IEPlugin.VideoSitesURLPatterns.txt")))
                {
                    string line = urlsStream.ReadLine();
                    while (line != null || line.Length == 0)
                    {
                        RegexOptions options = ((RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline)
                                    | RegexOptions.IgnoreCase);
                        Regex reg = new Regex(line, options);
                        videoSites.Add(reg);

                        line = urlsStream.ReadLine();
                    }
                }
            }
            catch (Exception)
            {
            }
        } 
        #endregion
    }
}
