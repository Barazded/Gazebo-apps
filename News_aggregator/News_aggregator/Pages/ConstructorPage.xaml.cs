using AngleSharp.Html.Dom;
using Firebase.Database.Query;
using News_aggregator.Data;
using News_aggregator.Models;
using News_aggregator.Parser;
using System;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class ConstructorPage : ContentPage
    {
        private ParserConstructor parserConstructor = new ParserConstructor();
        private StartParser parser = new StartParser(null);
        //настройки ресурса
        internal string nameWebResourсe;
        internal string linkOnWebResourсe;
        internal string typeOfResource;
        //настройки парсера
        internal string titleSelector;
        internal string linkSelector;
        internal string infoSelector;
        internal string dateSelector;
        public ConstructorPage()
        {
            InitializeComponent();
        }

        private async void Ev_ParseButtonCliced(object sender, EventArgs e)
        {
            //настройки ресурса
            //nameWebResourсe = name_resourse.Text;
            nameWebResourсe = "Test_API";
            //linkOnWebResourсe = link_resource.Text;
            linkOnWebResourсe = "https://ru.investing.com/news/";
            typeOfResource = type_resource.Text;
            //настройки парсера
            //titleSelector = title_selector.Text;
            //linkSelector = link_selector.Text;
            //dateSelector = date_selector.Text;
            //infoSelector = info_selector.Text;
            titleSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a";
            linkSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a";
            dateSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > p";
            //infoSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > p";
            infoSelector = "";
            var document = await parser.RequestHtmlAsync(linkOnWebResourсe);
            var cards = parserConstructor.Parse((IHtmlDocument)document, titleSelector, linkSelector, infoSelector, dateSelector);

            await Navigation.PushAsync(new OutputPage(cards));
            var api = new ParserSettings()
            {
                NameResourse = nameWebResourсe,
                UrlResourse = linkOnWebResourсe,
                TitleSelector = titleSelector,
                LinkSelector = linkSelector,
                DateSelector = dateSelector,
                InfoSelector = infoSelector
            };
            var firebase = FirebaseInteraction.GetDataBase();
            await firebase.Child("APIs").PostAsync(api);
        }
        private async void Ev_PublishButtonCliced(object sender, EventArgs e)
        {
            //проверка 
            var document = await parser.RequestHtmlAsync(linkOnWebResourсe);
            var api = new ParserSettings()
            {
                NameResourse = nameWebResourсe,
                UrlResourse = linkOnWebResourсe,
                TitleSelector = titleSelector,
                LinkSelector = linkSelector,
                DateSelector = dateSelector,
                InfoSelector = infoSelector
            };
            var cards = parserConstructor.Parse((IHtmlDocument)document, api.TitleSelector, api.LinkSelector, api.InfoSelector, api.DateSelector);
            if (cards == null || cards.Count == 0) 
            {
                await DisplayAlert("Ошибка компиляции!", "API недействителен", "продолжить");
                return;
            };
            await App.DataBaseNew.SaveItemAsync(App.ConvertApiToResourseSettings(api));
            await DisplayAlert("API был опубликован и добавлен в ваш список", "Ошибки не найдены", "продолжить");
        }
    }

}