using System;
using News_aggregator;
using News_aggregator.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using SQLite;

namespace News_aggregator.Pages
{
    public partial class ResoursePage : ContentPage
    {
        public ResoursePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            collectionView.ItemsSource = await App.DataBase.GetItemsAsync();
            base.OnAppearing();
        }
        private  void OnSelectionChenged(object sender, SelectionChangedEventArgs e)
        {
            //await DisplayAlert($"{item.isChecked.ToString()}", "sd", "sd");
        }
        public  void ApplyButt_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Dont find", "checked", "ok");

        }
    }
}