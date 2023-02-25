using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class IXBTParser : IParser
    {
        //реализация метода интерфейса
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("no-margin")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("*").Where(item => item.ParentElement != null && item.ParentElement.ClassName != null && item.ParentElement.ClassName.Contains("no-margin")).OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //доп инфа
            var info = document.QuerySelectorAll("h4").ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("time_iteration_icon")).ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                titles_.Add(titles[i].TextContent);
                links_.Add(links[i].Replace("about:///", "https://www.ixbt.com/"));
                info_.Add(info[i].TextContent);
                dates_.Add(dates[i].TextContent);
            }
        }
    }
}
