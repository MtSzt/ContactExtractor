using HtmlAgilityPack;
using ContactExtractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ContactExtractor.Parsers
{
    public class PktParser
    {
        private readonly string _convertedNumbers = Environment.CurrentDirectory + ".\\Data\\convertedNumbers.txt";

        private readonly string _notInterested = Environment.CurrentDirectory + ".\\Data\\notInterested.txt";
        public List<WebSiteModel> ExtractData(string websiteContent)
        {
            List<string> listOfNumbers = File.ReadAllLines(_convertedNumbers).ToList();

            List<string> listOfNotInterested = File.ReadAllLines(_notInterested).ToList();

            List<WebSiteModel> outputList = new List<WebSiteModel>();

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(websiteContent);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            var mainBoxNodes = htmlBody.Descendants("div").Where(node => node.GetAttributeValue("class", String.Empty).Contains("box-content company-row list-free")).ToList();
            foreach (HtmlNode nodes in mainBoxNodes)
            {
                WebSiteModel companyDetails = new WebSiteModel();
                try
                {
                    //company Name
                    companyDetails.Company = nodes.Descendants("h2").Where(node => node.GetAttributeValue("class", String.Empty).Equals("company-name"))?.FirstOrDefault().InnerText;
                }
                catch (Exception)
                {
                    companyDetails.Company = "BRAK";
                }
                try
                {
                    //company Phone
                    companyDetails.PhoneNumber = nodes.Descendants("a").Where(node => node.GetAttributeValue("href", String.Empty).Equals("javascript:;"))?.FirstOrDefault().Attributes["data-phone"].Value;
                    if (listOfNumbers.Contains(companyDetails.PhoneNumber))
                        companyDetails.PhoneNumber = "CONVERTED";

                    if (listOfNotInterested.Contains(companyDetails.PhoneNumber))
                        companyDetails.PhoneNumber = "NOT INTERESTED";
                }
                catch (Exception)
                {
                    companyDetails.PhoneNumber = "BRAK";
                }
                try
                {
                    //company Email
                    HtmlNode emailNode = nodes.Descendants("div").Where(node => node.GetAttributeValue("class", String.Empty).Equals("call-cell call--email"))?.FirstOrDefault();
                    companyDetails.Email = emailNode.Descendants("span")?.FirstOrDefault().Attributes["title"].Value;
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
