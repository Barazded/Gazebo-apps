using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class StopGameParser : IParser
    {
        //реализация метода интерфейса
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("#w0 > div:nth-child(n) > div:nth-child(n) > div > div > a").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("#w0 > div:nth-child(n) > div:nth-child(n) > div > div > a").OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("#w0 > div:nth-child(n) > div:nth-child(n) > div > div > div > div._info-row_11mk8_121 > span").ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent.Trim(),
                    Link = links[i],
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
