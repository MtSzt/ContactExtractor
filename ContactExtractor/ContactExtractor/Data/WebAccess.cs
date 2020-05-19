using ContactExtractor.Models;
using ContactExtractor.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ContactExtractor.Data
{
    public class WebAccess
    {
        public WebAccess()
        {
        }

        public List<WebSiteModel> GetListOfWebsiteModels(string link)
        {
            List<WebSiteModel> output = ListOfCompaniesFromPage(link);
            return output;
        }

        private List<WebSiteModel> ListOfCompaniesFromPage(string link) 
        {
            List<WebSiteModel> webContentList;
            string webPageContent = ExtractPageContent(link);

            if (link.Contains("panorama"))
            {
                PanoramaParser panorama = new PanoramaParser();
                webContentList = panorama.ExtractData(webPageContent);
            }
            else
            {
                PktParser pkt = new PktParser();
                webContentList = pkt.ExtractData(webPageContent);
            }

            return webContentList;   
        }

        private string ExtractPageContent(string link)
        { 
            string website = string.Empty;
            using (WebClient web = new WebClient())
                website = web.DownloadString(link);

            return website;
        }
    }
}
