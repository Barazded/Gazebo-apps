using News_aggregator.Models;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class ViewPage : ContentPage
    {
        private Card card = new Card();
        public ViewPage(Card card)
        {
            InitializeComponent();
            this.card = card;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            webView.Source = card.Link;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            webView.Source = null;
        }
    }
}