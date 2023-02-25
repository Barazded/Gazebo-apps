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
                Current.Properties["pickerInx"] = 0;
                Current.Properties["curentStandart"] = 6;
                Current.Properties["filterInx"] = 0;
                Current.Properties["currentFilter"] = "всё";
            }
            Current.SavePropertiesAsync();
        }

        protected override void OnStart()
        {
            //инициализация доступных ресурсов
            ResourseItem RBC = new ResourseItem
            {
                ID = 1,
                Text = "RBC(economy)",
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
            ResourseItem IXBT = new ResourseItem
            {
                ID = 4,
                Text = "IXBT(tech)",
                NameItem = "IXBT"
            };
            ResourseItem IXBTGames = new ResourseItem
            {
                ID = 5,
                Text = "IXBT(games)",
                NameItem = "IXBTGames"
            };
            ResourseItem StopGame = new ResourseItem
            {
                ID = 6,
                Text = "StopGame(games)",
                NameItem = "StopGame"
            };
            ResourseItem Banki = new ResourseItem
            {
                ID = 7,
                Text = "Banki(economic)",
                NameItem = "Banki"
            };
            DataBase.SaveItemAsync(RBC);
            DataBase.SaveItemAsync(Igromania);
            DataBase.SaveItemAsync(Investing);
            DataBase.SaveItemAsync(IXBT);
            DataBase.SaveItemAsync(IXBTGames);
            DataBase.SaveItemAsync(StopGame);
            DataBase.SaveItemAsync(Banki);
        }
    }
}
