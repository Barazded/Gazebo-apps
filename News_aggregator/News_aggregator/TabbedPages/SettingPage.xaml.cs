using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace News_aggregator
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            //
        }
        //событие нажатия нажатия 
        private async void AverageButt_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert($"{(sender as Button).Text}", "don`t find propertie", "cancel");
        }
        private void TabButt_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new TabPageControl());
        }
    }
}
