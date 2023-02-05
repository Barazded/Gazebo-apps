using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;

namespace News_aggregator.Parser
{
    class ParserWorker
    {
        IParser parser;
        IParserSettings parserSettings;

        HtmlLoader loader;

        #region Properties
        public IParser Parser { get => parser; set => parser = value; }


        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                //передача данных для получения кода страницы
                loader = new HtmlLoader(value);
            }
        }
        #endregion

        public event Action<object, List<string>, List<string>, List<string>, List<string> > OnNewData;
        //должен получать список
        public ParserWorker(IParser parser)
        {
            this.parser = parser;
        }
        //запускается через бекенд страницы
        public void Start()
        {
            Worker();
        }
        //создает списки, получает код страницы
        //Settings передаются через страницу
        private async void Worker()
        {
            var titles = new List<string>();
            var info = new List<string>();
            var dates = new List<string>();
            var links = new List<string>();
            //
            var source = await loader.GetSoureByPageId();
            var domParser = new HtmlParser();
            var document = await domParser.ParseDocumentAsync(source);
            //
            parser.Parse(document, ref titles, ref info, ref dates, ref links);
            //вызов события
            OnNewData.Invoke(this, titles, info, dates, links);
        }
    }
}
