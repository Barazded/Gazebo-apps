
namespace NewsAggregator.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            username.Text =$"#{(string)App.GetProp("Username", TypeProp.string_)}";
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
            App.SetProp("IsRegist", "0");
            App.SetProp("Username", "DefaulstUser");
            App.SetProp("Login", "defultUser");
            await DisplayAlert($"Выход из аккаунта", "", "продолжить");
            App.SetMainPage(new EnterPage());
        }
    }
}