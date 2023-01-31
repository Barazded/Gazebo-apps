using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Parser_html.Core
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}/";
        }
        public async Task<string> GetSoureByPageId()
        {
            //var currentUrl = url.Replace("{CurrentId}", id.ToString());
            var currentUrl = url;
            var response = await client.GetAsync(currentUrl);
            //исходный код страницы
            string sourse = "";

            if (response != null && response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            return sourse;
        }
    }
}
