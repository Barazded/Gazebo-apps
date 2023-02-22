using News_aggregator.Models;
using News_aggregator.Parser;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class NewsPage : ContentPage
    {
        private ParserWorker parser;
        private List<Card> cards = new List<Card>();
        private List<List<Card>> listListCards = new List<List<Card>>();
        private List<ResourseItem> resoursesBd = new List<ResourseItem>();
        //ParserWorker и HtmlLoader должны прогонять по одному ресурсу
        //для хранения имен выбраных ресурсов
        private List<string> selctedItemsNames = new List<string>();
        //кортежи всех ресурсов
        private List<(IParserSettings settings, IParser parser)> resoursesTupleList = new List<(IParserSettings settings, IParser parser)>();
        //кортежи выбранных ресурсов
        private List<(IParserSettings settings, IParser parser)> selectedResoursesTupleList = new List<(IParserSettings settings, IParser parser)>();
        public NewsPage()
        {
            InitializeComponent();
            collectionResourses.ItemsSource = null;
            //инициализация всех ресурсов
            resoursesTupleList = new List<(IParserSettings settings, IParser parser)>
            {
                (new InvestingSettings(), new InvestingParser()),
                (new IgromaniaSettings(), new IgromaniaParser()),
                (new RbcSettings(), new RbcParser())
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            collectionResourses.ItemsSource = null;
            #region Get Selected Resourses
            //получение ресурсов из бд
            resoursesBd = await App.DataBase.GetItemsAsync();
            //получение имен выбранных ресурсов
            for (int i = 0; i < resoursesTupleList.Count; i++)
            {
                if (resoursesBd[i].isChecked)
                    selctedItemsNames.Add(resoursesBd[i].NameItem);
            }
            //добавление выбранных ресурсов
            for (int i = 0; i < selctedItemsNames.Count; i++)
            {
                for (int z = 0; z < resoursesTupleList.Count; z++)
                    if (selctedItemsNames[i] == resoursesTupleList[z].settings.Name)
                        selectedResoursesTupleList.Add(resoursesTupleList[z]);
            }
            #endregion
            //
            for (int i = 0; i < selectedResoursesTupleList.Count; i++)
            {
                //Свойство Settings из ParserWorker (данные для html loader)
                parser = new ParserWorker(selectedResoursesTupleList[i].parser);
                parser.Settings = selectedResoursesTupleList[i].settings;
                parser.OnNewData += Parser_OnNewData;
                parser.Start();
            }
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            collectionResourses.ItemsSource = null;
            listListCards.Clear();
            cards.Clear();
            selectedResoursesTupleList.Clear();
            selctedItemsNames.Clear();
        }
        //реализация события
        private void Parser_OnNewData(object sender, List<string> titles, List<string> info, List<string> dates, List<string> links)
        {
            collectionResourses.ItemsSource = null;
            listListCards.Clear();
            //получение стандарта вывода из локальных файлов приложения
            var viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //
            if (cards.Count < selectedResoursesTupleList.Count * viewStandart)
            {
                for (int i = 0; i < viewStandart; i++)
                {
                    var newCard = new Card();
                    #region Get Properties
                    newCard.ID = cards.Count + 1;
                    newCard.Title = titles[i];
                    newCard.Link = links[i];
                    //получение названия ресурса
                    newCard.NameResourse = (sender as ParserWorker).Settings.Name;
                    if (info.Count != 0)
                        newCard.Info = info[i];
                    if (dates.Count != 0)
                        newCard.Date = dates[i];
                    #endregion
                    cards.Add(newCard);
                }
            }
            //если последный ресурс был распаршен запускается сортировка
            if (cards.Count > viewStandart && cards.Count/viewStandart == selectedResoursesTupleList.Count)
            {
                //выделение памяти
                for (int i = 0; i < viewStandart / 2; i++)
                    listListCards.Add(new List<Card>());
                //потоки(в какой поток попадет карточка)
                int counter = 0;
                //отрезки
                int slice = 2;
                //для вычета
                int part = slice;
                for (int i = 0; i < cards.Count; i++)
                {
                    if (part > 0)
                    {
                        listListCards[counter].Add(cards[i]);
                        part--;
                        if (part == 0)
                        {
                            part = slice;
                            if (counter == (viewStandart / 2) - 1)
                                counter = 0;
                            else
                                counter++;
                        }
                    }
                }
                var newCards = new List<Card>();
                //выбор данных из двумерного списка
                for (int i = 0; i < listListCards.Count; i++)
                {
                    for (int x = 0; x < listListCards[i].Count; x++)
                        newCards.Add(listListCards[i][x]);
                }
                cards = newCards;
            }
            collectionResourses.ItemsSource = cards;
        }
        //вызывается при нажатии на элементъ collectionResourses
        private async void OnCardClick(object sender, SelectionChangedEventArgs e)
        {
            //срабатывает при нажатии на элемент collectonView
            await Navigation.PushAsync(new ViewPage(e.CurrentSelection.FirstOrDefault() as Card));
        }
    }
}