using AngleSharp;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class BankiParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > " +
                "div.lbb023d8c.l0a493b73 > div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div:nth-child(n) " +
                "> div > div.lf4cbd87d.ld6d46e58.lb47af913 > a").ToList();
            //дата публикации
            var date = document.QuerySelector("body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > " +
                "div.lbb023d8c.l0a493b73 > div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div.l795320b7 > h2");
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > " +
                "div.lbb023d8c.l0a493b73 > div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div:nth-child(n) > div > " +
                "div.lf4cbd87d.ld6d46e58.lb47af913 > a").OfType<IHtmlAnchorElement>();
            var links = htmlElements.Select(item => item.Href).ToList();
            var st = document.ToHtml();
            //
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent.Trim(),
                    Link = links[i],
                    Date = date.TextContent.Trim()
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
