using AngleSharp.Html.Dom;
using System.Collections.Generic;

namespace News_aggregator.Parser
{
    internal interface IParser
    {
        void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_, ref List<string> links_);
    }
}