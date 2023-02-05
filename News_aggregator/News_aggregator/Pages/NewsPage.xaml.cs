using Parser.Core;
using Parser.Core.Habra;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class NewsPage : ContentPage
    {
        readonly ParserWorker<string[]> parser;
        //G - global
        //public List<string> GTitles = new List<string>();
        //public List<string> GInfo = new List<string>();
        //public List<string> GDates = new List<string>();
        public NewsPage()
        {
            InitializeComponent();

            parser = new ParserWorker<string[]>(new IgromaniaParser());
            parser.OnNewData += Parser_OnNewData;
            //нужно создать отдельный класс карточки и передавать список экземпляров этого класса в ItemsSource
            //свойства id, title, date, info
        }
        protected async override void OnAppearing()
        {
            collectionResourses.ItemsSource = await App.DataBase.GetItemsAsync();
            parser.Settings = new IgromaniaSettings(0, 5);
            parser.Start();
        }
        private void Parser_OnNewData(object sender, List<string> titles, List<string> info, List<string> dates)
        {
            //урезание массива под нужный размер(мда)
            var endPoint = parser.Settings.EndPoint;
            titles.RemoveRange(5, titles.Count - 5);
            info.RemoveRange(5, info.Count - 5);
            dates.RemoveRange(5, dates.Count - 5);
            //
            //GTitles = titles;
            //await DisplayAlert("print", $"{GTitles[0]}", "ok");
            //GInfo = info;
            //GDates = dates;
        }
    }
}