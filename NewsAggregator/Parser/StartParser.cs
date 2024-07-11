using NewsAggregator.Models;
using System;
using System.Collections.Generic;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using System.Threading.Tasks;

namespace NewsAggregator.Parser
{
    class StartParser
    {
        private ParserSettings parserS;
        private ParserConstructor parser = new ParserConstructor();
        private HtmlLoader loader;
        //должен получать список
        public StartParser(ParserSettings parserS)
        {
            if (parserS != null) { this.parserS = parserS; }
        }
        public ParserSettings Settings
        {
            get
            {
                return parserS;
            }
        }

        public event Action<object, List<Card>> OnUpdateData;
        //создает списки, получает код страницы
        internal void Start()
        {
            _ = Worker();
        }
        private async Task Worker()
        {
            if (parserS == null) { return; }
            List<Card> cards = new List<Card>();
            //получение html
            var document = await RequestHtmlAsync(Settings.UrlResourse);
            //new parser
            cards = parser.Parse((IHtmlDocument)document, parserS.TitleSelector, parserS.LinkSelector, parserS.InfoSelector, parserS.DateSelector);
            //вызов события
            OnUpdateData.Invoke(this, cards);
        }
        internal async Task<IDocument> RequestHtmlAsync(string url)
        {
            //дефолтные настройки для angleSharp
            var config = Configuration.Default.WithDefaultLoader();
            //создание контекса по умолчанию
            IBrowsingContext context = BrowsingContext.New(config);
            IDocument document = await context.OpenAsync(url);
            //
            if (document.StatusCode != System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("error, try get again");
                //попытка получить документ через лоадер
                var source = await loader.GetHtmlSourse();
                document = await context.OpenAsync(req => req.Content(source));
                //
                if (document.StatusCode != System.Net.HttpStatusCode.OK) { Console.WriteLine("success!"); }
                else { Console.WriteLine("fail!"); }
            }
            return document;
        }
    }
}
