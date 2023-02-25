using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class StopGameParser : IParser
    {
        //реализация метода интерфейса
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("caption caption-bold")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("*").Where(item => item.ParentElement != null && item.ParentElement.ClassName != null && item.ParentElement.ClassName.Contains("caption caption-bold")).OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("info-item timestamp")).ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                var locTitles = titles[i].TextContent.Trim();
                titles_.Add(locTitles);
                links_.Add(links[i].Replace("about:///", "https://stopgame.ru/"));
                var locDate = dates[i].TextContent.Trim();
                dates_.Add(locDate);
            }
        }
    }
}
