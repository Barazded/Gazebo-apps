﻿using System;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
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
            App.Current.Properties.Remove("IsRegist");
        }
    }
}