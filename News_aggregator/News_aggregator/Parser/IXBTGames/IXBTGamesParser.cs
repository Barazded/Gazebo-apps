using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class IXBTGamesParser : IParser
    {
        //реализация метода интерфейса
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("card-link")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("card-link")).OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //доп инфа
            var info = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("d-flex d-sm-block my-2")).ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                var locTitle = titles[i].TextContent.Trim();
                titles_.Add(locTitle);
                links_.Add(links[i].Replace("about:///", "https://ixbt.games/"));
                //
                var locInfo = info[i].TextContent.Substring(0, 85);
                info_.Add($"{locInfo}...");
            }
        }
    }
}
