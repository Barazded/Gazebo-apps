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
        }

        protected override void OnStart()
        {
            ResourseItem RBC = new ResourseItem();
            RBC.ID = 1;
            RBC.Text = "RBC(economic)";
            RBC.UriResourse = "null";
            //
            ResourseItem Igromania = new ResourseItem();
            Igromania.ID = 2;
            Igromania.Text = "Igromania(games)";
            Igromania.UriResourse = "null";
            //
            ResourseItem Investing = new ResourseItem();
            Investing.ID = 3;
            Investing.Text = "Investing(economic)";
            Investing.UriResourse = "null";
            //
            DataBase.SaveItemAsync(RBC);
            DataBase.SaveItemAsync(Igromania);
            DataBase.SaveItemAsync(Investing);
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
