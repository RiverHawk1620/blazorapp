using HtmlAgilityPack;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;

namespace BlazorApp.Data.SharedDataServices {
    public class HTMLDataService {
        public HTMLDataService()
        {
            
        }   

        /// <summary>
        /// Calls the full url given (no assumptions about http, ect. made!)
        /// </summary>
        /// <param name="fullUrl">FULL URL</param>
        /// <returns>the response as a string</returns>
        public static async Task<string> CallUrl(string fullUrl)
        {
	        HttpClient client = new HttpClient();
	        var response = await client.GetStringAsync(fullUrl);
	        return response;
        } 
    }
}