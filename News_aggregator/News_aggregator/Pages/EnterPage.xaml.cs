using News_aggregator.Interfaces;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News_aggregator.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EnterPage : ContentPage
	{
		public EnterPage()
		{
			InitializeComponent();
		}
		internal async void Ev_EnterButtonClicked(object sender, EventArgs e)
		{
			var pos = await CheckEnter();
			if (!pos) { return; }
            //проверка существования 
            var firebase = DependencyService.Resolve<IFirebaseAuthentication>();
            try
			{
                var token = await firebase.SignInFirebase(login_enter.Text, password_enter.Text);
                await DisplayAlert("Добро пожаловать!", "", "спасибо");
            }
			catch (Exception ex)
			{
                await DisplayAlert("Возникла ошибка", $"код ошибки {ex.Message}", "продолжить");
				return;
            }
            //указатель позиции пользователя: 1 - авторизован;
            Application.Current.Properties["IsRegist"] = 1;
			//Application.Current.Properties["Username"] = 
			App.SetMainPage(new CustomTabbedPage());
        }
		internal async void Ev_RegistButtonClicked(object sender, EventArgs e)
		{
			var pos = await CheckEnter();
			if (!pos) { return; }
			//создание новой записи в firebase
            var firebase = DependencyService.Resolve<IFirebaseAuthentication>();
            try
            {
				var token = await firebase.CreateAccountFirebase(login_enter.Text, password_enter.Text);
                await DisplayAlert("Новый пользователь был зарегистрирован", "", "продолжить");
            }
            catch (Exception ex)
			{
				await DisplayAlert("Возникла ошибка", $"код ошибки {ex.Message}", "продолжить");
                return;
            }
        }
		private async Task<bool> CheckEnter()
		{
			if (login_enter.Text == "" || password_enter.Text == "")
			{
				await DisplayAlert("Одно из полей не заполнено", "", "продолжить");
				return false;
			}
			return true;
		}
	}
}