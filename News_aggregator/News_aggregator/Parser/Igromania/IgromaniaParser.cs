using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace News_aggregator.Parser
{
    class IgromaniaParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, int viewStandart, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            //дата публикации
            var dates = document.GetElementsByClassName("aubli_date").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("aubli_name")).OfType<IHtmlAnchorElement>();
            var links = htmlElements.Select(item => item.Href).ToList();
            //доп инфа
            var info = document.GetElementsByClassName("aubli_desc").ToList();
            //заголовок
            var titles = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("aubli_name")).ToList();
            //
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                titles_.Add(titles[i].TextContent);
                info_.Add(info[i].TextContent);
                dates_.Add(dates[i].TextContent);
                links_.Add(links[i].Replace("about:///", "https://www.igromania.ru/"));
            }
        }
    }
}
