using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class BankiParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("lf473447f text-weight-medium")).ToList();
            //дата публикации
            var dates = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("l3a4b1a96")).ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("*").Where(item => item.ClassName != null && item.ClassName.Contains("lf473447f text-weight-medium")).OfType<IHtmlAnchorElement>();
            var links = htmlElements.Select(item => item.Href).ToList();
            //
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                var locTitles = titles[i].TextContent.Trim();
                titles_.Add(locTitles);
                links_.Add(links[i].Replace("about:///", "https://www.banki.ru/"));
                var locDates = dates[i].TextContent.Trim();
                dates_.Add(locDates);
            }
        }
    }
}
