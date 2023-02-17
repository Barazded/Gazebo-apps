using System.Linq;
using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace News_aggregator.Parser
{
    internal class RbcParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            //заголовок
            var titles = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("q-item__title js-rm-central-column-item-text")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("q-item__link js-yandex-counter js-index-central-column-io js-rm-central-column-item js-central-column-from-param")).OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList();
            //доп инфа
            var info = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("q-item__description")).ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("span").Where(item => item.ClassName != null && item.ClassName.Contains("q-item__date")).ToList();
            //
            //перебор всех элементов
            for (int i = 0; i < 5; i++)
            {
                var locTitle = titles[i].TextContent.Trim();
                titles_.Add(locTitle);
                links_.Add(links[i]);
                //срез строки
                var locInfo = info[i].TextContent.Substring(0,80);
                info_.Add($"{locInfo}...");
                //удаление лишних пробелов через регулярные выражения
                var locDate = Regex.Replace(dates[i].TextContent, @"\s+", " ");
                dates_.Add(locDate);
            }
        }
    }
}
