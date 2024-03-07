using Firebase.Database.Query;
using News_aggregator.Data;
using News_aggregator.Interfaces;
using System;
using System.Collections.Generic;
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
                var token = await firebase.SignInFirebase(login_enter.Text.ToLower(), password_enter.Text);
                var nickname = await FirebaseInteraction.GetNickname(login_enter.Text.Replace(".","!"));
                //указатель позиции пользователя: 1 - авторизован;
                Application.Current.Properties["IsRegist"] = 1;
                Application.Current.Properties["Username"] = nickname;
                App.Current.Properties["Login"] = login_enter.Text;
                await DisplayAlert($"Добро пожаловать {nickname}!", "", "спасибо");
                App.SetMainPage(new AppShell());
            }
			catch (Exception ex)
			{
                await DisplayAlert("Возникла ошибка", $"код ошибки {ex.Message}", "продолжить");
				return;
            }
        }
		internal async void Ev_RegistButtonClicked(object sender, EventArgs e)
		{
			var pos = await CheckEnter();
			if (!pos) { return; }
			if (nickname_enter.Text == "") { await DisplayAlert("Одно из полей не заполнено", "", "продолжить"); }
            var firebaseAuth = DependencyService.Resolve<IFirebaseAuthentication>();
            try
            {
                //создание новой записи в firebase
                var token = await firebaseAuth.CreateAccountFirebase(new_login_enter.Text.ToLower(), new_password_enter.Text);
                await DisplayAlert("Новый пользователь был зарегистрирован", "", "продолжить");
                var firebase = FirebaseInteraction.GetDataBase();
                var data = new Dictionary<string, string>()
                {
                    { new_login_enter.Text.Replace(".", "!"), nickname_enter.Text }
                };
                await firebase.Child("Nicknames").PatchAsync(data);
            }
            catch (Exception ex)
			{
				await DisplayAlert("Возникла ошибка", $"код ошибки {ex.Message}", "продолжить");
                return;
            }
        }
        internal void Ev_ChangeStackLayout(object sender, EventArgs e)
        {
            if (signin_stack.IsVisible)
            {
                signin_stack.IsVisible = false;
                createacc_stack.IsVisible = true;
            }
            else
            {
                signin_stack.IsVisible = true; 
                createacc_stack.IsVisible = false;
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