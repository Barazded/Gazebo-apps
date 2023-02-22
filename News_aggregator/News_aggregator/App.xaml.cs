using System;
using System.IO;
using Xamarin.Forms;
using News_aggregator.Models;
using News_aggregator.Data;

namespace News_aggregator
{
    public partial class App : Application
    {
        public static ResoursesDataBase database;
        
        //доступен из любой страницы(свойство)
        public static ResoursesDataBase DataBase
        {
            get
            {
                if(database == null)
                {
                    database = new ResoursesDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Resourse.db3"));
                }
                return database;
            }
        }
        
        public App()
        {
            InitializeComponent();
            MainPage = new CustomTabbedPage();
            //если приложение открылось в первый раз
            if (!Current.Properties.ContainsKey("curentStandart"))
            {
                Current.Properties["curentStandart"] = 6;
            }
            if (!Current.Properties.ContainsKey("pickerInx"))
            {
                Current.Properties["pickerInx"] = 0;
            }
            Current.SavePropertiesAsync();
        }

        protected override void OnStart()
        {
            //инициализация доступных ресурсов
            ResourseItem RBC = new ResourseItem
            {
                ID = 1,
                Text = "RBC(economic)",
                NameItem = "RBC"
            };
            ResourseItem Igromania = new ResourseItem
            {
                ID = 2,
                Text = "Igromania(games)",
                NameItem = "Igromania"
            };
            ResourseItem Investing = new ResourseItem
            {
                ID = 3,
                Text = "Investing(economic)",
                NameItem = "Investing"
            };
            DataBase.SaveItemAsync(RBC);
            DataBase.SaveItemAsync(Igromania);
            DataBase.SaveItemAsync(Investing);
        }
    }
}
