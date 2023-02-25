using News_aggregator.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace News_aggregator.Pages
{
    public partial class ResoursePage : ContentPage
    {
        //для поиска по бд
        private List<ResourseItem> resourses = new List<ResourseItem>();
        //для сохранение в бд
        private List<ResourseItem> resoursesForSave = new List<ResourseItem>();
        //количество катрочек которое будут показанно пользователю(планируются 6 8 10 12 стандарты; будет выбиратся в настройках)
        public ResoursePage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            //выгрузка стандарта из локальных данных устройства
            pickerStandarts.SelectedIndex = (int)Application.Current.Properties["pickerInx"];
            //спавн объектов
            if (collectionView.ItemsSource == null)
            {
                //выгрузка данных из бд
                collectionView.ItemsSource = await App.DataBase.GetItemsAsync();
                resourses = await App.DataBase.GetItemsAsync();
            }
        }
        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            resoursesForSave = await App.DataBase.GetItemsAsync();
            await DisplayAlert("Сохранение", "Данные изменены", "ok");
            //сохранение изменений
            for (int i = 0; i < resoursesForSave.Count; i++)
            {
                await App.DataBase.SaveItemAsync(resoursesForSave[i]);
            }
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
        private void FindElement(List<ResourseItem> resourses_, string name_, ref ResourseItem item)
        {
            for (int i = 0; i < resourses_.Count; i++)
            {
                if (resourses_[i].Text == name_)
                    item = resourses_[i];
            }
        }
        private async void OnChangeSelectItem(object sender, EventArgs e)
        {
            //запись новых настроек в локальные файлы
            Application.Current.Properties["pickerInx"] = pickerStandarts.SelectedIndex;
            Application.Current.Properties["curentStandart"] = pickerStandarts.Items[pickerStandarts.SelectedIndex];
            await Application.Current.SavePropertiesAsync();
        }
    }
}