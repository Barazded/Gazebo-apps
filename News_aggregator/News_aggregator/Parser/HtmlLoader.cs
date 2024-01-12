using AngleSharp;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace News_aggregator.Parser
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        //получчение кода страницы
        public async Task<string> GetHtmlSourse()
        {
            var currentUrl = url;
            var response = await client.GetAsync(currentUrl, HttpCompletionOption.ResponseHeadersRead);
            //исходный код страницы
            var sourse = "";
            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            return sourse;
        }
    }
}