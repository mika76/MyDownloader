using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;

namespace MyDownloader.Spider.Parsers.Html
{
    public class HtmlParser: IDisposable
    {
        private static string RegExprHREF = @"(?<=a\s+([^>]+\s+)?href\=[\x27\x22])(?<1>[^\x27\x22]*)(?=[\x27\x22])";

        //private static string RegExprIMG = @"<img\s+([^>]+\s+)?src\s*=\s*(?:""(?<1>[/\a-z0-9_][^""\/]*)""|'(?<1>[/\a-z0-9_][^'']*)''|(?<1>[/\a-z0-9_]\S*))(\s?[^>]*/)?>";
        private static string RegExprIMG = @"(?<=img\s+([^>]+\s+)?src\=[\x27\x22])(?<1>[^\x27\x22]*)(?=[\x27\x22])";

        private static string RegExprIFrame = @"(?<=iframe\s+src\=[\x27\x22])(?<1>[^\x27\x22]*)(?=[\x27\x22])";

        private static string RegExprFrame = @"(?<=frame\s+src\=[\x27\x22])(?<1>[^\x27\x22]*)(?=[\x27\x22])";

        private static Regex RegExFindHref = new Regex(RegExprHREF, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static Regex RegExFindImg = new Regex(RegExprIMG, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static Regex RegExFindIFrame = new Regex(RegExprIFrame, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private static Regex RegExFindFrame = new Regex(RegExprFrame, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);

        private static Regex[] regs =  { RegExFindHref, RegExFindImg, RegExFindIFrame, RegExFindFrame };

        private string htmlData;

        public HtmlParser(Stream htmlStream)
        {
            using (StreamReader sw = new StreamReader(htmlStream))
            {
                htmlData = sw.ReadToEnd();
            }
        }

        public IEnumerable<Uri> GetResources(UrlType urlType, string baseUri)
        {
            return GetEnumerator(regs[(int)urlType], baseUri, this.htmlData);
        }

        public IEnumerable<Uri> GetHrefs(string baseUri)
        {
            return GetEnumerator(RegExFindHref, baseUri, this.htmlData);
        }

        public IEnumerable<Uri> GetImages(string baseUri)
        {
            return GetEnumerator(RegExFindImg, baseUri, this.htmlData);
        }

        public IEnumerable<Uri> GetFrames(string baseUri)
        {
            return GetEnumerator(RegExFindFrame, baseUri, this.htmlData);
        }

        public IEnumerable<Uri> GetIFrames(string baseUri)
        {
            return GetEnumerator(RegExFindIFrame, baseUri, this.htmlData);
        }

        private static IEnumerable<Uri> GetEnumerator(Regex regExpr, string baseUrl, string html)
        {
            for (Match m = regExpr.Match(html); m.Success; m = m.NextMatch())
            {
                string href = m.Groups[1].ToString();

                // filter non-real relation urls:
                if (String.IsNullOrEmpty(href) ||
                    href.StartsWith("#") ||
                    href.StartsWith("mailto:") ||
                    href.StartsWith("javascript:"))
                {
                    continue;
                }

                href = System.Web.HttpUtility.HtmlDecode(href);

                Uri uri = null;
                try
                {
                    uri =  ConvertToAbsoluteUrl(href, baseUrl);
                }
                catch (Exception)
                {
                }

                if (uri != null)
                {
                    yield return uri;
                }
            }
        }

        private static Uri ConvertToAbsoluteUrl(string url, string baseUrl)
        {
            // we try to prevent the exception caused in the case the url is relative
            // (no scheme info) just for speed
            if (url.IndexOf(Uri.SchemeDelimiter) < 0 && baseUrl != null)
            {
                try
                {
                    Uri baseUri = new Uri(baseUrl);
                    return new Uri(baseUri, url);
                }
                catch
                {
                    return null;
                }
            }

            try
            {
                Uri uri = new Uri(url);
                return uri;
            }
            catch (Exception)
            {
                if (baseUrl != null)
                {
                    try
                    {
                        Uri baseUri = new Uri(baseUrl);
                        return new Uri(baseUri, url);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        #region IDisposable Members

        public void Dispose()
        {
            this.htmlData = null;
        }

        #endregion
    }
}
