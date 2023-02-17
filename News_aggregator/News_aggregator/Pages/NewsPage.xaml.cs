using News_aggregator.Parser;
using News_aggregator.Models;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace News_aggregator.Pages
{
    public partial class NewsPage : ContentPage
    {
        private ParserWorker parser;
        private List<Card> cards = new List<Card>();
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
                (new InvestingSettings(0, 5), new InvestingParser()),
                (new IgromaniaSettings(0, 5), new IgromaniaParser()),
                (new RbcSettings(0, 5), new RbcParser())
            };
        }
        protected async override void OnAppearing()
        {
            collectionResourses.ItemsSource = null;
            #region GetSelectedResourses
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
            collectionResourses.ItemsSource = null;
            cards.Clear();
            selectedResoursesTupleList.Clear();
            selctedItemsNames.Clear();
        }
        //реализация события
        private void Parser_OnNewData(object sender, List<string> titles, List<string> info, List<string> dates, List<string> links)
        {
            collectionResourses.ItemsSource = null;
            var endPoint = parser.Settings.EndPoint;
            //костыль
            if (cards.Count < selectedResoursesTupleList.Count * 5)
            {
                for (int i = 0; i < endPoint; i++)
                {
                    var newCard = new Card();
                    #region Get Properties
                    newCard.ID = cards.Count + 1;
                    newCard.Title = titles[i];
                    newCard.Link = links[i];
                    if (info.Count != 0)
                        newCard.Info = info[i];
                    if (dates.Count != 0)
                        newCard.Date = dates[i];
                    #endregion
                    cards.Add(newCard);
                }
                //здесь нужно поставить ожидание
                collectionResourses.ItemsSource = cards;
            }
        }
        //вызывается при нажатии на элементъ collectionResourses
        async void OnCardClick(object sender, SelectionChangedEventArgs e)
        {
            //срабатывает при нажатии на элемент collectonView
            await DisplayAlert($"{(e.CurrentSelection.FirstOrDefault() as Card).Link}","","ok");
        }
    }
}