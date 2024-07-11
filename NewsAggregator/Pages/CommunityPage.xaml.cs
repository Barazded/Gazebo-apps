﻿using NewsAggregator.Data;
using NewsAggregator.Models;

namespace NewsAggregator.Pages
{
    public partial class CommunityPage : ContentPage
    {
        public CommunityPage()
        {
            InitializeComponent();
        }
        
        public async void ConstructorButt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConstructorPage());
        }
        protected async override void OnAppearing()
        {
            await UpdateWindow(null);
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        internal async void Ev_ApiInfoClicked(object sender, EventArgs e)
        {
            Label label = (Label)((StackLayout)((Button)sender).Parent).Children[0];
            string id = label.Text;
            var api = await FirebaseInteraction.GetFirebaseData(id);
            //
            if (api == null) 
            {
                await DisplayAlert("Недействительный API", "Обнаружена ошибка доступа", "продолжить");
                return;
            }
            await Navigation.PushAsync(new InfoApiPage(api));
        }
        internal async void Ev_delitApi(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            StackLayout stackLayout = (StackLayout)butt.Parent.Parent;
            Label loginLable = (Label)stackLayout.Children.Last();
            var userLogin = (string)App.GetProp("Login", TypeProp.string_);
            var id = ((Label)stackLayout.Children[0]).Text;
            if (userLogin != loginLable.Text)
            {
                await DisplayAlert("Вы не являетесь владелцом API", "Ошибка доступа", "продолжить");
                return;
            }
            //удаление
            await DisplayAlert("API успешно удалён", "", "продолжить");
            FirebaseInteraction.DelitApiFromFirebase(id);
            //выгрузка БД
            await UpdateWindow(null);
        }
        internal async Task UpdateWindow(List<FirebaseDataModel>? data)
        {
            if (data == null)
            {
                data = await FirebaseInteraction.GetAllDataFromFirebase();
            }
            collection_api.ItemsSource = null;
            collection_api.ItemsSource = data;
            
        }
        internal async void Ev_FindApi(object sender, EventArgs e)
        {
            var data = await FirebaseInteraction.GetAllDataFromFirebase();
            var mask = finder.Text.ToLower();
            var selectData = new List<FirebaseDataModel>();
            foreach (var item in data) 
            {
                if (mask.Length > item.ApiSettings.NameResourse.Length) { continue; }
                if (mask == item.ApiSettings.NameResourse.ToLower().Substring(0, mask.Length))
                {
                    selectData.Add(item);
                }
            }
            await UpdateWindow(selectData);
        }
    }
}