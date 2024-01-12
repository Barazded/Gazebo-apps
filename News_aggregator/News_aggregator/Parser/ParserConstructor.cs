using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class ParserConstructor
    {
        private IHtmlDocument globalDocument;
        public List<Card> Parse(IHtmlDocument document, string titleSelector, string linkSelector, string infoSelector, string dateSelector)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse(Application.Current.Properties["curentStandart"].ToString());
            globalDocument = document;
            //заголовок
            var titles = GetValue(titleSelector).ToList();
            //ссылка на публикации
            var htmlElements = GetValue(linkSelector).OfType<IHtmlAnchorElement>();
            var links = htmlElements.Select(item => item.Href).ToList();
            var info = GetValue(infoSelector).ToList();
            var dates = GetValue(dateSelector).ToList();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                var card = new Card();
                //критические ккомпоненты
                try
                {
                    card.Title = titles[i].TextContent.Trim();
                    card.Link = links[i];
                }
                catch 
                {
                    return null;
                }
                try
                {
                    card.Info = info[i].TextContent.Trim();
                }
                catch
                {
                    card.Info = "null";
                }
                try
                {
                    card.Date = dates[i].TextContent.Trim();
                }
                catch 
                {
                    card.Date = "null";
                }
                cards.Add(card);
            }
            return cards;
        }
        public List<IElement> GetValue(string selector)
        {
            var result = new List<IElement>();
            try
            {
                result = globalDocument.QuerySelectorAll($"{selector}").ToList();
            }
            catch 
            {
                Console.WriteLine("Error");
            }
            return result;
        }
    }
}