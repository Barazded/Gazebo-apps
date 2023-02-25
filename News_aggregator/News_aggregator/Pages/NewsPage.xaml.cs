using News_aggregator.Models;
using News_aggregator.Parser;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System;

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
                (new RbcSettings(), new RbcParser()),
                (new IXBTSettings(), new IXBTParser()),
                (new IXBTGamesSettings(), new IXBTGamesParser()),
                (new StopGameSettings(), new StopGameParser()),
                (new BankiSettings(), new BankiParser())
            };
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            if (!Application.Current.Properties.ContainsKey("filterInx"))
                pickerFilter.SelectedIndex = 0;
            else
                pickerFilter.SelectedIndex = (int)Application.Current.Properties["filterInx"];
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
                parser = new ParserWorker(selectedResoursesTupleList[i].parser)
                {
                    Settings = selectedResoursesTupleList[i].settings
                };
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
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //получение настроек фильтра
            string currentFilter = (string)Application.Current.Properties["currentFilter"];
            List<Card> filterCards = new List<Card>();
            var settings = (sender as ParserWorker).Settings;
            //создание карточек
            if (cards.Count < selectedResoursesTupleList.Count * viewStandart)
            {
                for (int i = 0; i < viewStandart; i++)
                {
                    var newCard = new Card();
                    #region Get Properties
                    newCard.ID = cards.Count + 1;
                    newCard.Title = titles[i];
                    newCard.Link = links[i];
                    newCard.Type = settings.Type;
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
            //если последный ресурс был распаршен запускается сортировка и фильтровка
            if (cards.Count > viewStandart && cards.Count/viewStandart == selectedResoursesTupleList.Count)
            {
                //выделение памяти
                for (int i = 0; i < viewStandart / 2; i++)
                    listListCards.Add(new List<Card>());
                //потоки(в какой поток попадет карточка)
                int flow = 0;
                //отрезки
                int slice = 2;
                //для вычета
                int part = slice;
                for (int i = 0; i < cards.Count; i++)
                {
                    if (part > 0)
                    {
                        listListCards[flow].Add(cards[i]);
                        part--;
                        if (part == 0)
                        {
                            part = slice;
                            if (flow == (viewStandart / 2) - 1)
                                flow = 0;
                            else
                                flow++;
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
            //фильтровка карточек
            if(cards.Count/viewStandart == selectedResoursesTupleList.Count)
                FilterCards(currentFilter, ref filterCards);
            else
                filterCards = cards;
            collectionResourses.ItemsSource = filterCards;
        }
        //вызывается при нажатии на элементъ collectionResourses
        private async void OnCardClick(object sender, SelectionChangedEventArgs e)
        {
            //срабатывает при нажатии на элемент collectonView
            await Navigation.PushAsync(new ViewPage(e.CurrentSelection.FirstOrDefault() as Card));
        }

        private async void FilterChanged(object sender, EventArgs e)
        {
            List<Card> filterCards = new List<Card>();
            Application.Current.Properties["filterInx"] = pickerFilter.SelectedIndex;
            Application.Current.Properties["currentFilter"] = pickerFilter.Items[pickerFilter.SelectedIndex];
            //фильтровка
            FilterCards((string)Application.Current.Properties["currentFilter"], ref filterCards);
            collectionResourses.ItemsSource = filterCards;
            await Application.Current.SavePropertiesAsync();
            
        }
        private void FilterCards(string currentFilter, ref List<Card> _filterCards)
        {
            if (currentFilter != "всё")
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    if (currentFilter == cards[i].Type)
                        _filterCards.Add(cards[i]);
                }
            }
            else
                _filterCards = cards;
        }
    }
}