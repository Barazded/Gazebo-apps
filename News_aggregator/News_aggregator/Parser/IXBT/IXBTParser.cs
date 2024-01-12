using AngleSharp;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Parser
{
    internal class IXBTParser : IParser
    {
        //реализация метода интерфейса
        public List<Card> Parse(IHtmlDocument document)
        {
            List<Card> cards = new List<Card>();
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //заголовок
            var titles = document.QuerySelectorAll("#pagebody > div.b-content.b-content__pagecontent > div > " +
                "div > div.g-grid_column.g-grid_column__big > div.b-block.block__newslistbig > div.newslistbig__items > div:nth-child(n) > div.b-article__header > h2 > a").ToList();
            //ссылка на публикации
            var htmlElements = document.QuerySelectorAll("#pagebody > div.b-content.b-content__pagecontent > div > " +
                "div > div.g-grid_column.g-grid_column__big > div.b-block.block__newslistbig > div.newslistbig__items > div:nth-child(n) > div.b-article__header > h2 > a").OfType<IHtmlAnchorElement>().ToList();
            var links = htmlElements.Select(item => item.Href).ToList().ToList();
            //доп инфа
            var info = document.QuerySelectorAll("#pagebody > div.b-content.b-content__pagecontent > div >" +
                " div > div.g-grid_column.g-grid_column__big > div.b-block.block__newslistbig > div.newslistbig__items > div:nth-child(n) > div.b-article__header > h4").ToList();
            //дата публикации(костыль)
            var dates = document.QuerySelectorAll("#pagebody > div.b-content.b-content__pagecontent > div > div > " +
                "div.g-grid_column.g-grid_column__big > div.b-block.block__newslistbig > div.newslistbig__items > div:nth-child(n) > div.b-article__tags > span").ToList();
            var st = document.ToHtml();
            //перебор всех элементов
            for (int i = 0; i < viewStandart; i++)
            {
                if (i >= titles.Count) { break; }
                Card card = new Card()
                {
                    Title = titles[i].TextContent,
                    Link = links[i].Replace("about:///", "https://www.ixbt.com/"),
                    Info = info[i].TextContent,
                    Date = dates[i].TextContent
                };
                cards.Add(card);
            }
            return cards;
        }
    }
}
