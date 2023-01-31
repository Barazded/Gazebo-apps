using AngleSharp.Html.Dom;
using System.Collections.Generic;

namespace Parser_html.Core
{
    internal interface IParser<T> where T : class
    {
        void Parse(IHtmlDocument document, ref List<string> titles_, ref List<string> info_, ref List<string> dates_);
    }
}