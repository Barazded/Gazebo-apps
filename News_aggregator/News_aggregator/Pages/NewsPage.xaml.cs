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
        private StartParser parser;
        private List<Card> parsedCards = new List<Card>();
        private List<List<Card>> listListCards = new List<List<Card>>();
        private List<ResourseSettings> allResourses = new List<ResourseSettings>();
        private List<ResourseSettings> selectedResourses = new List<ResourseSettings>();
        private Dictionary<string, ResourseType> filterDict = new Dictionary<string, ResourseType>();
        public NewsPage()
        {
            InitializeComponent();
            collectionResourses.ItemsSource = null;
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            filterDict = new Dictionary<string, ResourseType>()
            {
                {"игры", ResourseType.games },
                {"экономика", ResourseType.economyc },
                {"наука и технологии", ResourseType.tech },
                {"всё", ResourseType.all }
            };
            if (!Application.Current.Properties.ContainsKey("filterInx"))
                pickerFilter.SelectedIndex = 0;
            else
                pickerFilter.SelectedIndex = (int)Application.Current.Properties["filterInx"];
            collectionResourses.ItemsSource = null;
            //инициализация всех элементов из лбд
            allResourses = await App.DataBaseNew.GetItemsAsync();
            //получение выбранных ресурсов
            for (int i = 0; i < allResourses.Count; i++)
            {
                if (allResourses[i].isChecked)
                    selectedResourses.Add(allResourses[i]);
            }
            for (int i = 0; i < selectedResourses.Count; i++)
            {
                parser = new StartParser((ParserSettings)App.ByteArrayToObject(selectedResourses[i].ParserSettingsByte));
                parser.OnUpdateData += OnUpdateData;
                parser.Start();
            }
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            collectionResourses.ItemsSource = null;
            listListCards.Clear();
            parsedCards.Clear();
            allResourses.Clear();
            selectedResourses.Clear();
        }
        //реализация события
        private void OnUpdateData(object sender, List<Card> cardsToParse)
        {
            if (cardsToParse == null) { return; }
            collectionResourses.ItemsSource = null;
            listListCards.Clear();
            //получение стандарта вывода из локальных файлов приложения
            int viewStandart = int.Parse((string)Application.Current.Properties["curentStandart"]);
            //получение настроек фильтра
            string currentFilter = (string)Application.Current.Properties["currentFilter"];
            List<Card> filterCards = new List<Card>();
            var settings = (sender as StartParser).Settings;
            //создание карточек
            if (parsedCards.Count < selectedResourses.Count * viewStandart)
            {
                for (int i = 0; i < cardsToParse.Count; i++)
                {
                    var newCard = new Card()
                    {
                        //Обязательные поля
                        ID = parsedCards.Count + 1,
                        Title = cardsToParse[i].Title,
                        Link = cardsToParse[i].Link,
                        //Type = settings.TypeResourse,
                        NameResourse = settings.NameResourse,
                        //
                        Info = (cardsToParse[i].Info == null ? "" : cardsToParse[i].Info),
                        Date = (cardsToParse[i].Date == null ? "" : cardsToParse[i].Date)
                    };
                    parsedCards.Add(newCard);
                }
            }
            //если последный ресурс был распаршен запускается сортировка
            if (parsedCards.Count > viewStandart && parsedCards.Count/viewStandart == selectedResourses.Count)
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
                for (int i = 0; i < parsedCards.Count; i++)
                {
                    if (part > 0)
                    {
                        listListCards[flow].Add(parsedCards[i]);
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
                parsedCards = newCards;
            }
            collectionResourses.ItemsSource = parsedCards;
            //фильтровка карточек
            if (parsedCards.Count / viewStandart == selectedResourses.Count) { FilterCards(currentFilter, ref filterCards); }
            else { filterCards = parsedCards; }
            collectionResourses.ItemsSource = filterCards;
        }
        //вызывается при нажатии на элементъ collectionResourses
        private async void OnCardClick(object sender, EventArgs e)
        {
            StackLayout stack = (StackLayout)((Button)sender).Parent;
            string link = ((Label)stack.Children[0]).Text;
            await Navigation.PushAsync(new ViewPage(link));
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
            var currentFilterEnum = filterDict[currentFilter];
            if (currentFilter != "всё")
            {
                for (int i = 0; i < parsedCards.Count; i++)
                {
                    if (currentFilterEnum == parsedCards[i].Type)
                        _filterCards.Add(parsedCards[i]);
                }
            }
            else
                _filterCards = parsedCards;
        }
    }
}