using AngleSharp.Html.Dom;
using Firebase.Database.Query;
using News_aggregator.Data;
using News_aggregator.Models;
using News_aggregator.Parser;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class ConstructorPage : ContentPage
    {
        private ParserConstructor parserConstructor = new ParserConstructor();
        private StartParser parser = new StartParser(null);
        public ConstructorPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            type_picker.SelectedIndex = 0;
        }
        private async void Ev_ParseButtonCliced(object sender, EventArgs e)
        {
            //проверка 
            if (!CheckEntry())
            {
                await DisplayAlert("Entry error", "Check data", "ok");
                return;
            }
            string format = "dd.MM.yyyy";
            var currientDate = DateTime.Now.ToString(format);
            var document = await parser.RequestHtmlAsync(link_resource.Text);
            var cards = parserConstructor.Parse((IHtmlDocument)document, title_selector.Text, link_selector.Text, info_selector.Text, date_selector.Text);

            await Navigation.PushAsync(new OutputPage(cards));
            var api = new ParserSettings()
            {
                NameResourse = name_resourse.Text,
                UrlResourse = link_resource.Text,
                TitleSelector = title_selector.Text,
                LinkSelector = link_selector.Text,
                DateSelector = date_selector.Text,
                InfoSelector = info_selector.Text,
                AboutResourse = about_resourse.Text,
                UsernameCreator = (App.Current.Properties["Username"].ToString(), App.Current.Properties["Login"].ToString()),
                TypeResourse = type_picker.Items[type_picker.SelectedIndex].ToString(),
                DateCreate = currientDate
            };
        }
        private async void Ev_PublishButtonCliced(object sender, EventArgs e)
        {
            //проверка 
            if (!CheckEntry())
            {
                await DisplayAlert("Entry error", "Check data", "ok");
                return;
            }
            string format = "dd.MM.yyyy";
            var currientDate = DateTime.Now.ToString(format);
            var document = await parser.RequestHtmlAsync(link_resource.Text);
            var api = new ParserSettings()
            {
                NameResourse = name_resourse.Text,
                UrlResourse = link_resource.Text,
                TitleSelector = title_selector.Text,
                LinkSelector = link_selector.Text,
                DateSelector = date_selector.Text,
                InfoSelector = info_selector.Text,
                AboutResourse = about_resourse.Text,
                UsernameCreator = (App.Current.Properties["Username"].ToString(), App.Current.Properties["Login"].ToString()),
                TypeResourse = type_picker.Items[type_picker.SelectedIndex].ToString(),
                DateCreate = currientDate
            };
            var cards = parserConstructor.Parse((IHtmlDocument)document, api.TitleSelector, api.LinkSelector, api.InfoSelector, api.DateSelector);
            if (cards == null || cards.Count == 0) 
            {
                await DisplayAlert("Ошибка компиляции!", "API недействителен", "продолжить");
                return;
            };
            //сохранение в firebase
            var firebase = FirebaseInteraction.GetDataBase();
            await firebase.Child("APIs").PostAsync(api);
            //сохранение в локальную бд
            await App.DataBaseNew.SaveItemAsync(App.ConvertApiToResourseSettings(api));
            await DisplayAlert("API был опубликован и добавлен в ваш список", "Ошибки не найдены", "продолжить");
        }
        private void Ev_TestApiData(object sender, EventArgs e)
        {
            name_resourse.Text = "test";
            link_resource.Text = "https://ru.investing.com/news/";
            title_selector.Text = "#latestNews > div > article:nth-child(n) > div.textDiv > a";
            link_selector.Text = "#latestNews > div > article:nth-child(n) > div.textDiv > a";
            date_selector.Text = "#latestNews > div > article:nth-child(n) > div.textDiv > p";
            info_selector.Text = "null";
        }
        private void Ev_TestClearData(object sender, EventArgs e)
        {
            List<Entry> pols = new List<Entry>()
            {
                name_resourse,
                link_resource,
                title_selector,
                link_selector,
                date_selector,
                info_selector,
            };
            for (int i = 0; i < pols.Count; i++) { pols[i].Text = null; }
        }
        private bool CheckEntry()
        {
            List<Entry> pols = new List<Entry>()
            {
                name_resourse,
                link_resource,
                title_selector,
                link_selector,
            };
            for (int i = 0; i < pols.Count; i++) 
            {
                if (pols[i].Text == null) 
                { 
                    return false; 
                }
            }
            return true;
        }
    }

}