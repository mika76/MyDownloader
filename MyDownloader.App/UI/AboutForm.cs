using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using MyDownloader.Core.UI;
using MyDownloader.Core.Extensions;
using System.Resources;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace MyDownloader.App.UI
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

            //  Initialize the AboutBox to display the product information from the assembly information.
            //  Change assembly information settings for your application through either:
            //  - Project->Properties->Application->Assembly Information
            //  - AssemblyInfo.cs
            this.Text = String.Format("About {0}", AssemblyTitle);


            for (int i = 0; i < AppManager.Instance.Application.Extensions.Count; i++)
            {
                IExtension ext = AppManager.Instance.Application.Extensions[i];

                ListViewItem item = new ListViewItem(ext.Name);
                item.SubItems.Add(AssemblyVersion(ext.GetType().Assembly));
                lvwPlugs.Items.Add(item);
            }

            using (Stream s = this.GetType().Assembly.GetManifestResourceStream("MyDownloader.App.UI.About.rtf"))
            {
                richTextBox1.LoadFile(s, RichTextBoxStreamType.RichText);
            }            
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }
                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion(Assembly a)
        {
            return a.GetName().Version.ToString();
        }

        //public string AssemblyDescription
        //{
        //    get
        //    {
        //        // Get all Description attributes on this assembly
        //        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        //        // If there aren't any Description attributes, return an empty string
        //        if (attributes.Length == 0)
        //            return "";
        //        // If there is a Description attribute, return its value
        //        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
        //    }
        //}

        //public string AssemblyProduct
        //{
        //    get
        //    {
        //        // Get all Product attributes on this assembly
        //        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        //        // If there aren't any Product attributes, return an empty string
        //        if (attributes.Length == 0)
        //            return "";
        //        // If there is a Product attribute, return its value
        //        return ((AssemblyProductAttribute)attributes[0]).Product;
        //    }
        //}

        //public string AssemblyCopyright
        //{
        //    get
        //    {
        //        // Get all Copyright attributes on this assembly
        //        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        //        // If there aren't any Copyright attributes, return an empty string
        //        if (attributes.Length == 0)
        //            return "";
        //        // If there is a Copyright attribute, return its value
        //        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        //    }
        //}

        //public string AssemblyCompany
        //{
        //    get
        //    {
        //        // Get all Company attributes on this assembly
        //        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        //        // If there aren't any Company attributes, return an empty string
        //        if (attributes.Length == 0)
        //            return "";
        //        // If there is a Company attribute, return its value
        //        return ((AssemblyCompanyAttribute)attributes[0]).Company;
        //    }
        //}
        #endregion

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start(e.LinkText);
        }
    }
}
