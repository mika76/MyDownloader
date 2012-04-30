using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MyDownloader.Extension.Video;

namespace MyDownloader.Tests.Extension.Video
{
    [TestFixture]
    public class VideoConverterTest
    {
        [Test]
        public void ToMp3()
        {
            VideoConverter.Convert(@"C:\Temp\video.mp3", VideoFormat.MP3);
        }

        [Test]
        public void ToAVI()
        {
            VideoConverter.Convert(@"C:\Temp\video.avi", VideoFormat.AVI);
        }

        [Test]
        public void ToMPEG()
        {
            VideoConverter.Convert(@"C:\Temp\video.mpeg", VideoFormat.MPEG);
        }
    }
}
