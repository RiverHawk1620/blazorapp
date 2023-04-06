using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;
using BlazorApp.Data.SharedDataServices;

//uses data available a wmclub.org to populate entites
namespace BlazorApp.Data.WMC {
    public class WMCDataService {
        private static HTMLDataService _htmlDataService;

        //WmcRawDataUrl
        //WmcResultsDataUrl
        //WmcPaxDataUrl
        private static string WmcRawDataUrl = "http://www.wmclub.org/wp-content/uploads/2023/03/2023event1results.htm";
        private static string WmcResultsDataUrl = "";
        private static string WmcPaxDataUrl = "";

        private string pageHtml;

        public WMCDataService(HTMLDataService htmlDataService)
        {
            _htmlDataService = htmlDataService;
        }

        public List<string> ParseHtml(string html)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var programmerLinks = htmlDoc.DocumentNode.Descendants("li")
                .Where(node => !node.GetAttributeValue("class", "").Contains("tocsection"))
                .ToList();

            List<string> wikiLink = new List<string>();

            foreach (var link in programmerLinks)
            {
                if (link.FirstChild.Attributes.Count > 0) wikiLink.Add("https://en.wikipedia.org/" + link.FirstChild.Attributes[0].Value) ;
            }

            return wikiLink;
        }
    }
}