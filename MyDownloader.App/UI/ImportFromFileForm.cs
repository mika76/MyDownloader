using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyDownloader.Core;
using System.IO;
using System.Text.RegularExpressions;
using MyDownloader.Spider.Parsers.Html;
using MyDownloader.Core.UI;

namespace MyDownloader.App.UI
{
    public partial class ImportFromFileForm : Form
    {
        public ImportFromFileForm()
        {
            InitializeComponent();
        }

        public string DownloadPath
        {
            get
            {
                return downloadFolder1.Folder;
            }
        }

        public ResourceLocation[] URLs
        {
            get
            {
                List<ResourceLocation> urls = new List<ResourceLocation>();

                if (rdoTextFile.Checked)
                {
                    FillListFromTextFile(urls);               
                }
                else
                {
                    FillListFromHtmlFile(urls);
                }

                return urls.ToArray();
            }
        }

        private void FillListFromHtmlFile(List<ResourceLocation> urls)
        {
            using (Stream htmlStream = File.OpenRead(txtFileName.Text))
            {
                using (HtmlParser parser = new HtmlParser(htmlStream))
                {
                    IEnumerator<Uri> enumUri = parser.GetHrefs(this.location1.ResourceLocation.URL).GetEnumerator();

                    while (enumUri.MoveNext())
                    {
                        ResourceLocation newRl = location1.ResourceLocation;
                        newRl.URL = enumUri.Current.OriginalString;
                        urls.Add(newRl);
                    }
                }
            }
        }

        private void FillListFromTextFile(List<ResourceLocation> urls)
        {
            string[] lines = File.ReadAllLines(txtFileName.Text);

            for (int i = 0; i < lines.Length; i++)
            {
                string url = lines[i].Trim();

                if (!String.IsNullOrEmpty(url) && ResourceLocation.IsURL(url))
                {
                    urls.Add(ResourceLocation.FromURL(url));
                }
            }
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }            
        }

        public void ApplySettings()
        {
            scheduledDownloadEnabler1.ApplySettings();
        }

        /*private void CreateBatchDownloadForm_DragEnter(object sender, DragEventArgs e)
        {
            if (!string.IsNullOrEmpty(downloadFolder1.Folder))
            {
                if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
                {
                    object data = ((IDataObject)e.Data).GetData("HTML Format", true);
                    if (data != null)
                    {
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        private string GetBaseFolder(string url)
        {
            Uri uri = new Uri(url);
            return string.Format("{0}://{1}{2}", uri.Scheme, uri.Host, string.Join("", uri.Segments, 0, uri.Segments.Length - 1));
        }

        private void CreateBatchDownloadForm_DragDrop(object sender, DragEventArgs e)
        {
            //numFrom.Value = 0;
            //numTo.Value = 0;
            //location1.Clear();
            string html = GetDroppedHtmlSnippet(e);
            string url = GetDroppedHtmlUrl(e);
            string baseuri = GetBaseFolder(url);
            List<string> links = RetrieveLinks(html, url);

            dragdropURLs = ResourceLocation.FromURLArray(links.ToArray());
            //PreviewURLs();
        }

        private string GetDroppedHtmlSnippet(DragEventArgs e)
        {
            string text = ((DataObject)e.Data).GetData(DataFormats.Html) as string;
            if (string.IsNullOrEmpty(text))
            {
                text = ((DataObject)e.Data).GetData(DataFormats.Text) as string;
            }
            else
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                text = Encoding.UTF8.GetString(buffer);
            }
            if (!string.IsNullOrEmpty(text))
            {
                int startPos = text.IndexOf("<!--StartFragment-->");
                int endPos = text.IndexOf("<!--EndFragment-->");
                if (startPos != -1)
                {
                    startPos += 20;
                }
                if (startPos != -1 && endPos != -1)
                {
                    text = text.Substring(startPos, endPos - startPos);
                }
                if (string.IsNullOrEmpty(text))
                {
                    text = ((DataObject)e.Data).GetData(DataFormats.Rtf) as string;
                    if (string.IsNullOrEmpty(text))
                    {
                        text = ((DataObject)e.Data).GetData(DataFormats.Text) as string;
                    }
                }
            }
            text = text.Replace("Â", " "); // &nbsp;
            return text;
        }

        private string GetDroppedHtmlUrl(DragEventArgs e)
        {
            string text = ((DataObject)e.Data).GetData(DataFormats.Html) as string;
            if (!string.IsNullOrEmpty(text))
            {
                int startPos = text.IndexOf("SourceURL:");
                int endPos = text.IndexOf("\r\n", startPos);
                if (startPos != -1)
                {
                    startPos += 10;
                }
                if (startPos != -1 && endPos != -1)
                {
                    text = text.Substring(startPos, endPos - startPos);
                }
                if (string.IsNullOrEmpty(text))
                {
                    text = ((DataObject)e.Data).GetData(DataFormats.Rtf) as string;
                    if (string.IsNullOrEmpty(text))
                    {
                        text = ((DataObject)e.Data).GetData(DataFormats.Text) as string;
                    }
                }
            }
            return text;
        }

        private List<string> RetrieveLinks(string html, string baseUrl)
        {
            List<string> tbl = new List<string>();

            if (html == null || html.Length == 0)
                return tbl;

            for (Match m = RegExFindHref.Match(html); m.Success; m = m.NextMatch())
            {

                string href = m.Groups[1].ToString();	// filter non-real relation urls:
                if (href.StartsWith("mailto:") || href.StartsWith("javascript:") ||
                    href.EndsWith(".gif") || href.EndsWith(".jpg") || href.EndsWith(".png"))
                {
                    continue;
                }
                href = ConvertToAbsoluteUrl(href, baseUrl);
                if (href == null || href.Length == 0)
                    continue;

                string linkText = m.Groups[2].ToString();

                if (!tbl.Contains(href))
                    tbl.Add(href);
            }

            return tbl;
        }

        private string ConvertToAbsoluteUrl(string url, string baseUrl)
        {
            // we try to prevent the exception caused in the case the url is relative
            // (no scheme info) just for speed
            if (url.IndexOf(Uri.SchemeDelimiter) < 0 && baseUrl != null)
            {
                try
                {
                    Uri baseUri = new Uri(baseUrl);
                    return (new Uri(baseUri, url).ToString());
                }
                catch
                {
                    return null;
                }
            }

            try
            {
                Uri uri = new Uri(url);
                return uri.ToString();
            }
            catch (Exception)
            {

                if (baseUrl != null)
                {
                    try
                    {
                        Uri baseUri = new Uri(baseUrl);
                        return (new Uri(baseUri, url).ToString());
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
        }*/

        private void rdoDownloadMode_Changed(object sender, EventArgs e)
        {
            location1.Enabled = rdoHTML.Checked;
        }

        private bool IsValid()
        {
            if (!File.Exists(txtFileName.Text))
            {
                MessageBox.Show("Invalid file name.",
                    AppManager.Instance.Application.MainForm.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                using (ImportFromFilePreviewForm preview = new ImportFromFilePreviewForm(this.URLs))
                {
                    preview.ShowDialog();
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (! IsValid())
            {
                DialogResult = DialogResult.None;
                return;
            }
        }
    }
}