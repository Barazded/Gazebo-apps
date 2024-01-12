using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    class IgromaniaParser : IParser
    {
        //реализация метода интерфейса (для каждого ресурса своя реализация парсера)
        public List<Card> Parse(IHtmlDocument document)
        {
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            List<Card> cards = new List<Card>();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("#__next > div > div.app-wrapper > div.app-main > main > section > div.InfiniteScrollWrap_content__7x55W > " +
                "div:nth-child(n) > div.knb-list.HeadingPage_list__aSQ0P.knb-list--gap20.knb-list--row2.knb-list--columns4 > div:nth-child(n) > a").OfType<IHtmlAnchorElement>();
            var links = htmlElements.Select(item => item.Href).ToList();
            //заголовок
            var titles = document.QuerySelectorAll("#__next > div > div.app-wrapper > div.app-main > main > section > div.InfiniteScrollWrap_content__7x55W > " +
                "div:nth-child(n) > div.knb-list.HeadingPage_list__aSQ0P.knb-list--gap20.knb-list--row2.knb-list--columns4 > div:nth-child(n) > a").ToList();
            var st = document.QuerySelectorAll("Body").ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                cards.Add(new Card
                {
                    Title = (titles[i].TextContent != "" ? titles[i].TextContent : "Что-то пошло не так"),
                    Link = links[i].Replace("about:///", "https://www.igromania.ru/"),
                });
            }
            return cards;
        }
    }
}
