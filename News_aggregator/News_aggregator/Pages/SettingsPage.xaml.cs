using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        //событие нажатия нажатия 
        private async void AverageButt_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert($"{(sender as Button).Text}", "don`t find propertie", "cancel");
        }
        public async void ResourseButt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResoursePage());
        }
        public async void GeneralSettingButt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralSettingPage());
        }

    }
}