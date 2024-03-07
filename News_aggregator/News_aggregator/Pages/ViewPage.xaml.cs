using News_aggregator.Models;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class ViewPage : ContentPage
    {
        private string link = "";
        public ViewPage(string link)
        {
            InitializeComponent();
            this.link = link;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            webView.Source = link;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            webView.Source = null;
        }
    }
}