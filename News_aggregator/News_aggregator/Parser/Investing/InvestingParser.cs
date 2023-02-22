using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    class InvestingParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("title")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("title")).OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(m => m.Href).ToList().ToList();
            //доп инфа
            //var info = document.QuerySelectorAll("div").Where(item => item.LastChild.LastChild.LastChild != null);
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("p");
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                titles_.Add(titles[i].TextContent);
                links_.Add(links[i].Replace("about:///", "https://ru.investing.com/"));
                //info_.Add(locDates[i].TextContent);
                dates_.Add(dates[i].TextContent);
            }
        }
    }
}
