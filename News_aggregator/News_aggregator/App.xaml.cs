using News_aggregator.Pages;
using System;
using System.IO;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using News_aggregator.Data;
using News_aggregator.Models;

namespace News_aggregator
{
    public partial class App : Application
    {
        public static ItemsDataBase database;
        //доступен из любой страницы 
        public static ItemsDataBase DataBase
        {
            get
            {
                if(database == null)
                {
                    database = new ItemsDataBase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Resourse.db3"));
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
            RBC.NameItem = "RBC";
            RBC.UriResourse = "null";
            //
            ResourseItem Igromania = new ResourseItem();
            Igromania.ID = 2;
            Igromania.Text = "Igromania(games)";
            Igromania.NameItem = "Igromania";
            Igromania.UriResourse = "null";
            //
            ResourseItem Investing = new ResourseItem();
            Investing.ID = 3;
            Investing.Text = "Investing(economic)";
            Investing.NameItem = "Investing";
            Investing.UriResourse = "null";
            //
            DataBase.SaveItemAsync(RBC);
            DataBase.SaveItemAsync(Igromania);
            DataBase.SaveItemAsync(Investing);
            ResourseItem RB = new ResourseItem();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
