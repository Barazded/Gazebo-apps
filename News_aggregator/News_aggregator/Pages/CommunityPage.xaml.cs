using Xamarin.Forms;
using System;
using News_aggregator.Data;
using News_aggregator.Models;
using System.Linq;

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
        protected override void OnAppearing()
        {
            UpdateWindow();
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
        internal async void Ev_delitApi(object sender, EventArgs e)
        {
            Button butt = (Button)sender;
            StackLayout stackLayout = (StackLayout)butt.Parent.Parent;
            Label loginLable = (Label)stackLayout.Children.Last();
            var userLogin = App.Current.Properties["Login"].ToString();
            var id = ((Label)stackLayout.Children[0]).Text;
            if (userLogin != loginLable.Text)
            {
                await DisplayAlert("Вы не являетесь владелцом API", "Ошибка доступа", "продолжить");
                return;
            }
            //удаление
            await DisplayAlert("API успешно удалён", "", "продолжить");
            FirebaseInteraction.DelitApiFromFirebase(id);
            UpdateWindow();
        }
        internal async void UpdateWindow()
        {
            collection_api.ItemsSource = null;
            //выгрузка БД
            var elements = await FirebaseInteraction.GetAllDataFromFirebase();
            collection_api.ItemsSource = elements;
        }
    }
}