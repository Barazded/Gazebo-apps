using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace News_aggregator.Parser
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;
        //настройки передаются из бекенда страницы
        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            url = $"{settings.BaseUrl}";
        }
        //получчение кода страницы
        public async Task<string> GetSoureByPageId()
        {
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
