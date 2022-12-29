using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News_aggregator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new SettingPage();
            MainPage = new TabPageControl();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
