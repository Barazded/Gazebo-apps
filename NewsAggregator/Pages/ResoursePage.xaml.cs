using NewsAggregator.Models;

namespace NewsAggregator.Pages
{
    public partial class ResoursePage : ContentPage
    {
        //для поиска по бд
        private List<ResourseSettings> resourses = new List<ResourseSettings>();
        //для сохранение в бд
        private List<ResourseSettings> resoursesForSave = new List<ResourseSettings>();
        //количество катрочек которое будут показанно пользователю(планируются 6 8 10 12 стандарты; будет выбиратся в настройках)
        public ResoursePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            UpdateWindow();
            base.OnAppearing();
        }
        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            resoursesForSave = await App.DataBaseNew.GetItemsAsync();
            await DisplayAlert("Сохранение", "Данные изменены", "продолжить");
            //сохранение изменений
            for (int i = 0; i < resoursesForSave.Count; i++)
            {
                await App.DataBaseNew.SaveItemAsync(resoursesForSave[i]);
            }
        }
        private async void Ev_CheckedCheckBox(object sender, CheckedChangedEventArgs e)
        {
            ResourseSettings item = new ResourseSettings();
            CheckBox box = (sender as CheckBox);
            StackLayout sl = (StackLayout)box.Parent;
            string id = ((Label)sl.Children[1]).Text;
            if (id == null) { return; }
            //поиск элемента
            item = FindElement(int.Parse(id));
            if (item == null) { return; }
            item.isChecked = box.IsChecked;
            //сохранение состояния
            await App.DataBaseNew.SaveItemAsync(item);
        }
        private ResourseSettings FindElement(int id)
        {
            for (int i = 0; i < resourses.Count; i++)
            {
                if (resourses[i].ID == id) { return resourses[i]; }
            }
            return null;
        }
        private async void OnChangeSelectItem(object sender, EventArgs e)
        {
            //запись новых настроек в локальные файлы
            App.SetProp("pickerInx", pickerStandarts.SelectedIndex);
            App.SetProp("curentStandart", pickerStandarts.Items[pickerStandarts.SelectedIndex]);
            //
            //Application.Current.Properties["pickerInx"] = pickerStandarts.SelectedIndex;
            //Application.Current.Properties["curentStandart"] = pickerStandarts.Items[pickerStandarts.SelectedIndex];
            //await Application.Current.SavePropertiesAsync();
        }
        private async void Ev_DelitButtonClicked(object sender, EventArgs e)
        {
            Button delitButton = (Button)sender;
            StackLayout sl = (StackLayout)delitButton.Parent;
            string id = ((Label)sl.Children[1]).Text;
            if (id == null) { return; }
            var item = FindElement(int.Parse(id));
            if (item == null) { return; }
            //удаление из ЛБД
            await App.DataBaseNew.DeleteItemAsync(item);
            UpdateWindow();
            await DisplayAlert("API удалён", "", "продолжить");
        }
        private async void UpdateWindow()
        {
            collectionView.ItemsSource = null;
            //выгрузка стандарта из локальных данных устройства
            pickerStandarts.SelectedIndex = (int)App.GetProp("pickerInx", TypeProp.int_);
            //выгрузка данных из бд
            collectionView.ItemsSource = await App.DataBaseNew.GetItemsAsync();
            resourses = await App.DataBaseNew.GetItemsAsync();
        }
    }
}