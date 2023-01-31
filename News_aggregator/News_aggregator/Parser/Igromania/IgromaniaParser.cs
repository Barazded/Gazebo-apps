using AngleSharp.Html.Dom;
using Parser_html.Core;
using System.Collections.Generic;
using System.Linq;

namespace Parser.Core.Habra
{
    class IgromaniaParser : IParser<string[]>
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_)
        {
            //дата публикации
            var dates = document.GetElementsByClassName("aubli_date");
            //доп инфа
            var info = document.GetElementsByClassName("aubli_desc");
            //заголовок
            var titles = document.QuerySelectorAll("a").Where(item => item.ClassName != null && item.ClassName.Contains("aubli_name"));
            //
            var locTitles = titles.ToList();
            //перебор всех элементов
            for(int i = 0; i < titles.Count(); i++)
            {
                titles_.Add(locTitles[i].TextContent);
                info_.Add(info[i].TextContent);
                dates_.Add(dates[i].TextContent);
            }
        }
    }
}
