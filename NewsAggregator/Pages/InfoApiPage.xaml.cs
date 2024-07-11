using AngleSharp.Html.Dom;
using NewsAggregator.Models;
using NewsAggregator.Parser;

namespace NewsAggregator.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoApiPage : ContentPage
    {
        private StartParser parser = new StartParser(null);
        private ParserConstructor parserConstructor = new ParserConstructor();
        private FirebaseDataModel api = new FirebaseDataModel();
        public InfoApiPage(FirebaseDataModel api_)
        {
            InitializeComponent();
            //костыль
            List<FirebaseDataModel> list = new List<FirebaseDataModel>()
            {
                api_
            };
            collection_api.ItemsSource = list;
            api = api_;
        }
        private async void Ev_ParseButtonCliced(object sender, EventArgs e)
        {
            var document = await parser.RequestHtmlAsync(api.ApiSettings.UrlResourse);
            var cards = parserConstructor.Parse((IHtmlDocument)document, api.ApiSettings.TitleSelector, api.ApiSettings.LinkSelector,
                 api.ApiSettings.InfoSelector, api.ApiSettings.DateSelector);
            await Navigation.PushAsync(new OutputPage(cards));
        }
        private async void Ev_PublishButtonCliced(object sender, EventArgs e)
        {
            //проверка 
            var document = await parser.RequestHtmlAsync(api.ApiSettings.UrlResourse);
            var cards = parserConstructor.Parse((IHtmlDocument)document, api.ApiSettings.TitleSelector, api.ApiSettings.LinkSelector,
                 api.ApiSettings.InfoSelector, api.ApiSettings.DateSelector);
            if (cards == null || cards.Count == 0)
            {
                await DisplayAlert("Ошибка компиляции!", "API недействителен", "продолжить");
                return;
            };
            await App.DataBaseNew.SaveItemAsync(App.ConvertApiToResourseSettings(api.ApiSettings));
            await DisplayAlert("API был добавлен в ваш список", "", "продолжить");
        }
    }
}