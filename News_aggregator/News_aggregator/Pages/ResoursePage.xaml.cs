using System;
using News_aggregator.Models;
using Xamarin.Forms;
using System.Collections.Generic;

namespace News_aggregator.Pages
{
    public partial class ResoursePage : ContentPage
    {
        //для поиска по бд
        public List<ResourseItem> resourses = new List<ResourseItem>();
        //для сохранение в бд
        public List<ResourseItem> resoursesForSave = new List<ResourseItem>();
        public ResoursePage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            //спавн объектов
            if (collectionView.ItemsSource == null)
            {
                //выгрузка данных из бд
                collectionView.ItemsSource = await App.DataBase.GetItemsAsync();
                resourses = await App.DataBase.GetItemsAsync();
            }
            base.OnAppearing();
        }
        protected async override void OnDisappearing()
        {
            resoursesForSave = await App.DataBase.GetItemsAsync();
            await DisplayAlert("Сохранение", "Данные изменены", "ok");
            //сохранение изменений
            for (int i = 0; i < resoursesForSave.Count; i++)
            {
                await App.DataBase.SaveItemAsync(resoursesForSave[i]);
            }
            base.OnDisappearing();
        }
        private async void CheckedCheckBox(object sender, CheckedChangedEventArgs e)
        {
            ResourseItem item = new ResourseItem();
            CheckBox box = (sender as CheckBox);
            StackLayout sl = (StackLayout)box.Parent;
            Label label = (Label)sl.Children[1];

            //изсключение ненужных исполнений
            if (label.Text != null)
            {
                //поиск элемента
                FindElement(resourses, label.Text, ref item);
                item.isChecked = box.IsChecked;
                //сохранение состояния
                await App.DataBase.SaveItemAsync(item);
            }
        }
        protected async void OnApplyButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Сохранение", "Данные изменены(это кнопка заглушка P.S не забудь убрать если добавишь функционал)", "ok");
        }
        private void FindElement(List<ResourseItem> resourses_, string name_, ref ResourseItem item)
        {
            for (int i = 0; i < resourses_.Count; i++)
            {
                if (resourses_[i].Text == name_)
                {
                    item = resourses_[i];
                }
            }
        }
    }
}