using AngleSharp;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class IXBTGamesParser : IParser
    {
        //реализация метода интерфейса
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) " +
                "> div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) " +
                "> div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a").OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //доп инфа
            var info = document.QuerySelectorAll("body > div > div.main.clearfix.m-wrap > div > section > " +
                "div:nth-child(n) > div:nth-child(n) > div > div > div.col.mx-3.d-flex.flex-column > " +
                "div.card-text.order-3.my-2.order-sm-1.mt-sm-0 > div.d-flex.d-sm-block.my-2").ToList();
            var st = document.ToHtml();
            var st1 = document.QuerySelectorAll("body");
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent.Trim(),
                    Link = links[i].Replace("http://localhost", "https://ixbt.games"),
                    Info = $"{info[i].TextContent.Substring(0, 85)}..."
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
