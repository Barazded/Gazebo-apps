using News_aggregator.Parser;
using News_aggregator.Parser.Investing;
using News_aggregator.Models;
using News_aggregator.Parser.RBC;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Linq;

namespace News_aggregator.Pages
{
    public partial class NewsPage : ContentPage
    {
        private ParserWorker parser;
        private List<Card> cards = new List<Card>();
        private List<ResourseItem> resourses = new List<ResourseItem>();
        //через этот класс должен прогонять список выбранных ресурсов
        //при этом нет необходимости передавать списки в другие классы
        //ParserWorker и HtmlLoader должны прогонять по одному ресурсу
        //для хранения выбраных ресурсов
        private List<string> selctedItems = new List<string>();
        private List<IParser> selectedResoures = new List<IParser>();
        private List<IParserSettings> selectedResouresSett = new List<IParserSettings>();
        public NewsPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            //получение ресурсов из бд
            resourses = await App.DataBase.GetItemsAsync();
            for (int i = 0; i < resourses.Count; i++)
            {
                if (resourses[i].isChecked)
                    selctedItems.Add(resourses[i].NameItem);
                    
            }
            await DisplayAlert("Выбранные ресурсы", $"{selctedItems.Count}", "ok");
            //нужно передовать список экземпляров(пока это костыль)
            #region InitSelectRes
            selectedResoures.Add(new InvestingParser());
            selectedResoures.Add(new IgromaniaParser());
            selectedResoures.Add(new RbcParser());
            selectedResouresSett.Add(new InvestingSettings(0, 5));
            selectedResouresSett.Add(new IgromaniaSettings(0, 5));
            selectedResouresSett.Add(new RbcSettings(0,5));
            #endregion
            //
            for (int i = 0; i < selectedResoures.Count; i++)
            {
                //Свойство Settings из ParserWorker (данные для html loader)
                parser = new ParserWorker(selectedResoures[i]);
                parser.Settings = selectedResouresSett[i];
                parser.OnNewData += Parser_OnNewData;
                parser.Start();
            }
        }
        protected override void OnDisappearing()
        {
            //нужно для атоматического обновления
            cards.Clear();
        }
        //реализация события
        private async void Parser_OnNewData(object sender, List<string> titles, List<string> info, List<string> dates, List<string> links)
        {
            var endPoint = parser.Settings.EndPoint;
            //костыль
            if (cards.Count < 15)
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
                await DisplayAlert("Количество карточек", $"{cards.Count}", "ok");
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