using System.Linq;
using AngleSharp.Html.Dom;
using AngleSharp.Dom;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using News_aggregator.Models;

namespace News_aggregator.Parser
{
    internal class RbcParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("#maincontent > div > div > div:nth-child(n) > div > a > span.q-item__title.js-rm-central-column-item-text").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("#maincontent > div > div > div:nth-child(n) > div > a").OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList();
            //доп инфа
            var info = document.QuerySelectorAll("#maincontent > div > div > div:nth-child(n) > div > a > span.q-item__description").ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("#maincontent > div > div > div:nth-child(n) > div > span > span").ToList();
            //
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent.Trim(),
                    Link = links[i],
                    Info = $"{info[i].TextContent.Substring(0, 80)}...",
                    //удаление лишних пробелов через регулярные выражения
                    Date = Regex.Replace(dates[i].TextContent, @"\s+", " ")
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
