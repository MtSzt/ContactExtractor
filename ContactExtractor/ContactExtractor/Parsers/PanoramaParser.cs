using ContactExtractor.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactExtractor.Parsers
{
    public class PanoramaParser
    {
        private readonly string _convertedNumbers = Environment.CurrentDirectory + ".\\Data\\convertedNumbers.txt";
        
        public List<WebSiteModel> ExtractData(string websiteContent) 
        {
            List<string> listOfNumbers = File.ReadAllLines(_convertedNumbers).ToList();

            List<WebSiteModel> outputList = new List<WebSiteModel>();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(websiteContent);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            var mainBoxNodes = htmlBody.Descendants("div").Where(node => node.GetAttributeValue("class", String.Empty).Contains("row bottom-content px-3")).ToList();
            foreach (HtmlNode nodes in mainBoxNodes)
            {
                WebSiteModel companyDetails = new WebSiteModel();
                try
                {
                    //company Name
                    string linkToClean = nodes.Descendants("a").Where(node => node.GetAttributeValue("class", String.Empty).Equals("icon-telephone  addax addax-cs_hl_phonenumber_click"))?.FirstOrDefault().Attributes["href"].Value;
                    string[] splitLink = linkToClean.Split('/');
                    companyDetails.Company = splitLink.Last().Replace(".html", string.Empty);
                }
                catch (Exception)
                {
                    companyDetails.Company = "BRAK";
                }
                try
                {
                    //company Phone
                    companyDetails.PhoneNumber = nodes.Descendants("a").Where(node => node.GetAttributeValue("class", String.Empty).Contains("icon-telephone  addax addax-cs_hl_phonenumber_click"))?.FirstOrDefault().Attributes["title"].Value;
                    if (listOfNumbers.Contains(companyDetails.PhoneNumber))
                    {
                        companyDetails.PhoneNumber = "CONVERTED";
                    }
                }
                catch (Exception)
                {
                    companyDetails.PhoneNumber = "BRAK";
                }
                try
                {
                    //company Email
                    companyDetails.Email = nodes.Descendants("div").Where(node => node.GetAttributeValue("data-toggle", String.Empty).Contains("tooltip"))?.FirstOrDefault().Attributes["title"].Value.Trim();
                }
                catch (Exception)
                {
                    companyDetails.Email = "BRAK";
                }

                outputList.Add(companyDetails);
            }

            return outputList;
        }
    }
}
