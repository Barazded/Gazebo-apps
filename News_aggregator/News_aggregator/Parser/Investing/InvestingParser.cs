using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    class InvestingParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("#latestNews > div > article:nth-child(n) > div.textDiv > a").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("#latestNews > div > article:nth-child(n) > div.textDiv > a").OfType<IHtmlAnchorElement>().ToList();
            var info = document.QuerySelectorAll("#latestNews > div > article:nth-child(n) > div.textDiv > p").ToList();
            var links = htmlElements.Select(m => m.Href).ToList().ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent,
                    Link = links[i].Replace("about:///", "https://ru.investing.com/"),
                    Info = info[i].TextContent
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}