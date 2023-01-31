using AngleSharp.Html.Parser;
using Parser_html.Core;
using System;
using System.Collections.Generic;

namespace Parser.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        bool isActive;

        #region Properties
        public IParser<T> Parser { get => parser; set => parser = value; }


        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive { get => isActive; }
        #endregion

        public event Action<object, List<string>, List<string>, List<string>> OnNewData;
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public void Start()
        {
            isActive = true;
            Worker();
        }

        public void Abort()
        {
            isActive = false;
        }

        private async void Worker()
        {
            var titles = new List<string>();
            var info = new List<string>();
            var dates = new List<string>();
            //
            var source = await loader.GetSoureByPageId();
            var domParser = new HtmlParser();
            var document = await domParser.ParseDocumentAsync(source);
            parser.Parse(document, ref titles, ref info, ref dates);

            //вызов события
            OnNewData.Invoke(this, titles, info, dates);
            isActive = false;
        }
    }
}
