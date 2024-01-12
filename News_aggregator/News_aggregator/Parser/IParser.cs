using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using News_aggregator.Models;
using System.Collections.Generic;

namespace News_aggregator.Parser
{
    internal interface IParser
    {
        List<Card> Parse(IHtmlDocument document);
    }
}