using System;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            username.Text = App.Current.Properties["Username"].ToString();
            base.OnAppearing();
        }
        //события нажатий
        private async void AverageButt_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert($"{(sender as Button).Text}", "don`t find propertie", "cancel");
        }
        public async void ResourseButt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResoursePage());
        }
        private async void Ev_ExitButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert($"Выход из аккаунта", "", "продолжить");
            App.SetMainPage(new EnterPage());
            App.Current.Properties["IsRegist"] = 0;
            App.Current.Properties["Username"] = "DefaulstUser";
            App.Current.Properties["Login"] = null;
        }
    }
}