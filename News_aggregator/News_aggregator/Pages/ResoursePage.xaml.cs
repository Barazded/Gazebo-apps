using System;
using News_aggregator.Models;
using Xamarin.Forms;
using System.Linq;

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
        private void OnSelectionChenged(object sender, SelectionChangedEventArgs e)
        {
            //
            if (e.CurrentSelection != null)
            {
                ResourseItem item = (ResourseItem)e.CurrentSelection.FirstOrDefault();
                App.DataBase.SaveItemAsync(item);
            }
        }
        private void CheckedCheckBox(object sender, CheckedChangedEventArgs e)
        {

        }
    }
}