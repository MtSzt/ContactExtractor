using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactExtractor.Helpers
{
    public class LinkHelper
    {
        public string CreateLink(string website, string city, string job, string websiteNumber) 
        {
            string link;
            if (website.Contains("pkt")) 
            {
                if (!string.IsNullOrEmpty(websiteNumber))
                    link = string.Join("/", "https://www.pkt.pl/szukaj", job, city, websiteNumber);
                else
                    link = string.Join("/", "https://www.pkt.pl/szukaj", job, city);
            }   
            else 
            {
                if (!string.IsNullOrEmpty(websiteNumber))
                    link = string.Join("/", "https://panoramafirm.pl", job, city, $"firmy,{websiteNumber}.html");
                else
                    link = string.Join("/", "https://panoramafirm.pl", job, city, "firmy,1.html");
            }

            link = MakeAllLettersSmall(link);
            link = ChangePolishLetters(link);
                  
            return link;
        }

        private string ChangePolishLetters(string input)
        {
            string cleanInput = input
                .Replace("ą", "a")
                .Replace("ć", "c")
                .Replace("ę", "e")
                .Replace("ł", "l")
                .Replace("ó", "o")
                .Replace("ś", "s")
                .Replace("ń", "n")
                .Replace("ź", "z")
                .Replace("ż","z")
                .Replace(" ", string.Empty);

            return cleanInput;
        }

        private string MakeAllLettersSmall(string link) => link.ToLowerInvariant();
    }
}
