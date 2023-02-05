using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace News_aggregator.Parser.Investing 
{
    class InvestingParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
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
            for (int i = 0; i < titles.Count(); i++)
            {
                titles_.Add(titles[i].TextContent);
                links_.Add(links[i]);
                //info_.Add(locDates[i].TextContent);
                dates_.Add(dates[i].TextContent);
            }
        }
    }
}
