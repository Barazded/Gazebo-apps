using Parser.Core;
using Parser.Core.Habra;
using System.Collections.Generic;
using Xamarin.Forms;
using News_aggregator.Parser;

namespace News_aggregator.Pages
{
    public partial class NewsPage : ContentPage
    {
        readonly ParserWorker<string[]> parser;
        private List<Card> resoursesList = new List<Card>();

        public NewsPage()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(new IgromaniaParser());
            parser.OnNewData += Parser_OnNewData;
            //нужно создать отдельный класс карточки и передавать список экземпляров этого класса в ItemsSource
            collectionResourses.ItemsSource = resoursesList;
        }
        protected override void OnAppearing()
        {
            parser.Settings = new IgromaniaSettings(0, 5);
            parser.Start();
        }
        private async void Parser_OnNewData(object sender, List<string> titles, List<string> info, List<string> dates)
        {
            //урезание массива под нужный размер(мда)
            var endPoint = parser.Settings.EndPoint;
            titles.RemoveRange(5, titles.Count - 5);
            info.RemoveRange(5, info.Count - 5);
            dates.RemoveRange(5, dates.Count - 5);

            for (int i = 0; i < 5; i++)
            {
                var newCard = new Card();
                newCard.Title = titles[i];
                newCard.Info = info[i];
                newCard.Date = dates[i];

                resoursesList.Add(newCard);
            }
            await DisplayAlert("", $"{resoursesList.Count}", "ok");
        }
    }
}