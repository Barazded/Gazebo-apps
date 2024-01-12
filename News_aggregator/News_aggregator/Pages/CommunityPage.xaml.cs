using Xamarin.Forms;
using System;
using News_aggregator.Data;
using News_aggregator.Models;

namespace News_aggregator.Pages
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
        protected override async void OnAppearing()
        {
            //выгрузка БД
            var elements = await FirebaseInteraction.GetAllDataFromFirebase();
            collection_api.ItemsSource = elements;
            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        internal async void Ev_ApiInfoClicked(object sender, EventArgs e)
        {
            FirebaseDataModel api = (FirebaseDataModel)(sender as CollectionView).SelectedItem;
            if (api == null) 
            {
                await DisplayAlert("Недействительный API", "Обнаружена ошибка доступа", "продолжить");
                return;
            }
            await Navigation.PushAsync(new InfoApiPage(api));
        }
    }
}