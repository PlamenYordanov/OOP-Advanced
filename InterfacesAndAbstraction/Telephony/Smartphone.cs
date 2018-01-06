using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowser
    {
        private List<string> phoneNumbers = new List<string>();
        private List<string> urls = new List<string>();

        public Smartphone(List<string> phoneNumbers, List<string> urls)
        {
            this.phoneNumbers = phoneNumbers;
            this.urls = urls;
        }
        public string CallNumbers => CallValidNumbers();
      
        public string BrowseUrls => BrowseValidUrls();

        private string BrowseValidUrls()
        {
            string urlPattern = @"^\D+$";
            var sb = new StringBuilder();

            foreach (var url in this.urls)
            {
                if (!Regex.IsMatch(url, urlPattern))
                {
                    if(string.IsNullOrEmpty(url))
                    {
                        sb.AppendLine($"Browsing: !");
                        continue;
                    }
                    sb.AppendLine("Invalid URL!");
                    continue;
                }
                sb.AppendLine($"Browsing: {url}!");
            }
            return sb.ToString().TrimEnd();
        }

        private string CallValidNumbers()
        {
            string phonePattern = @"^\d+$";
            var sb = new StringBuilder();

            foreach (var number in this.phoneNumbers)
            {
                if (!Regex.IsMatch(number, phonePattern))
                {
                    sb.AppendLine("Invalid number!");
                    continue;
                }
                sb.AppendLine($"Calling... {number}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
