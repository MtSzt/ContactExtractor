using HtmlAgilityPack;
using ContactExtractor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactExtractor.Parsers
{
    public class PktParser
    {
        public List<WebSiteModel> ExtractData(string websiteContent)
        {
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
