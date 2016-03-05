using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UrlSharer;

namespace UrlSharer.Tests
{
    [TestClass]
    public class UrlShareTest
    {
        [TestMethod]
        public void GetTwitterInfo()
        {
            UrlInfo info = UrlSharer.GetUrlInfo("http://twitter.com/");
            Assert.AreEqual(info.Title, "Twitter");
        }

        [TestMethod]
        public void GetTwitterUserInfo()
        {
            UrlInfo info = UrlSharer.GetUrlInfo("http://twitter.com/xingh/");
            Assert.AreEqual(info.Title.Contains("xingh"), true);
        }

        [TestMethod]
        public void GetWikipediaInfo()
        {
            UrlInfo info = UrlSharer.GetUrlInfo("https://en.wikipedia.org/wiki/Electrical_network");
            Assert.AreEqual(info.Images[0].Contains(".png"), true);
        }


    }
}
