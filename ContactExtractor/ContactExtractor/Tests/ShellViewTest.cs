using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ContactExtractor.Helpers;

using NUnit.Framework;

namespace ContactExtractor.Tests
{
    [TestFixture]
    class ShellViewTest
    {
        [TestCase]

        public void CreateLinkTest()
        {
            LinkHelper link = new LinkHelper();
            Assert.AreEqual("https://panoramafirm.pl/architekt/poznan/firmy,10.html", link.CreateLink("panorama", "Poznań", "Architekt", "10"));

            Assert.AreEqual("https://www.pkt.pl/szukaj/lekarz/szczecin/6", link.CreateLink("pkt", "SzCzeciŃ", "Lekarz", "6"));

            Assert.AreEqual("https://panoramafirm.pl/hydraulik/warszawa/firmy.html", link.CreateLink("panorama", "WArszawa", "hydraulik", string.Empty));

            Assert.AreEqual("https://www.pkt.pl/szukaj/hydraulik/warszawa", link.CreateLink("pkt", "WArszawa", "hydraulik", string.Empty));
        }


    }
}
