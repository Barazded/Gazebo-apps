using System;
using System.IO;
using Xamarin.Forms;
using News_aggregator.Models;
using News_aggregator.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using News_aggregator.Pages;
[assembly: ExportFont("Inter.ttf", Alias = "Inter")]

namespace News_aggregator
{
    public enum ResourseType { economyc, games, tech, all }
    public partial class App : Application
    {
        public static ResoursesDataBaseNew databasenew;
        //доступен из любой страницы(свойство)
        public static ResoursesDataBaseNew DataBaseNew
        {
            get
            {
                if (databasenew == null)
                {
                    databasenew = new ResoursesDataBaseNew(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ResourseNew0.db3"));
                }
                return databasenew;
            }
        }
        
        public App()
        {
            InitializeComponent();
            int pos = 0;
            try 
            { 
                pos = (int)App.Current.Properties["IsRegist"]; 
            }
            catch 
            { 
                pos = 0; 
            }
            if (pos == 0) { SetMainPage(new EnterPage()); }
            else { SetMainPage(new AppShell()); }
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
            ResourseSettings Banki = new ResourseSettings
            {
                ID = 1,
                canDelit = false,
                TextName = "Banki",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "Banki",
                    UrlResourse = "https://www.banki.ru/news/lenta/",
                    TypeResourse = "экономика",
                    TitleSelector = "body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > div.lbb023d8c.l0a493b73 > " +
                    "div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div:nth-child(n) > div > div.lf4cbd87d.ld6d46e58.lb47af913 > a",
                    LinkSelector = "body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > " +
                    "div.lbb023d8c.l0a493b73 > div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div:nth-child(n) > div > div.lf4cbd87d.ld6d46e58.lb47af913 > a",
                    DateSelector = "body > div.page-container > main > div > div:nth-child(n) > div.bg-minor-black-lighten2 > div > div > " +
                    "div.lbb023d8c.l0a493b73 > div.lf4cbd87d.ld6d46e58.lfd76152f > div:nth-child(n) > div > div.l795320b7 > h2",
                })
                
            };
            ResourseSettings Investing = new ResourseSettings
            {
                ID = 2,
                canDelit = false,
                TextName = "Investing",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "Investing",
                    UrlResourse = "https://ru.investing.com/news/",
                    TypeResourse = "экономика",
                    TitleSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a",
                    LinkSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a",
                    InfoSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > p"
                })
            };
            ResourseSettings StopGame = new ResourseSettings
            {
                ID = 3,
                canDelit = false,
                TextName = "IXBTgames",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "StopGame",
                    UrlResourse = "https://ixbt.games/news/",
                    TypeResourse = "игры",
                    TitleSelector = "body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) > div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a",
                    LinkSelector = "body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) > div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a",
                })
            };
            ResourseSettings rbkEconomyc = new ResourseSettings
            {
                ID = 4,
                canDelit = false,
                TextName = "RBKEconomyc",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "RBKEconomyc",
                    UrlResourse = "https://www.rbc.ru/economics/",
                    TypeResourse = "экономика",
                    TitleSelector = "#maincontent > div > div.l-row.js-load-container > div:nth-child(n) > div > a > span.item__title-wrap > span > span > span",
                    LinkSelector = "#maincontent > div > div.l-row.js-load-container > div:nth-child(n) > div > div > span",
                })
            };
            ResourseSettings IXBTtech = new ResourseSettings
            {
                ID = 5,
                canDelit = false,
                TextName = "IXBTtech",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "IXBTtech",
                    UrlResourse = "https://www.ixbt.com/news/",
                    TypeResourse = "экономика",
                    TitleSelector = "b-content__pagecontent > div > div > div.g-grid_column.g-grid_column__big > div > ul:nth-child(n) > li:nth-child(n) > a > strong",
                    LinkSelector = "b-content__pagecontent > div > div > div.g-grid_column.g-grid_column__big > div > ul:nth-child(n) > li:nth-child(n) > a > strong",
                })
            };
            List<ResourseSettings> listResourse = new List<ResourseSettings>()
            {
                Banki,Investing,StopGame,rbkEconomyc,IXBTtech
            };
            foreach (var item in listResourse)
            {
                var tryGetItem = DataBaseNew.GetItemAsync(item.ID).Result;
                if (tryGetItem == null) { DataBaseNew.SaveItemAsync(item); }
            }
            base.OnStart();
        }
        //
        public static byte[] ObjectToByteArray(object obj)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }
        //
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                var obj = binForm.Deserialize(memStream);
                return obj;
            }
        }
        public static ResourseSettings ConvertApiToResourseSettings(ParserSettings apiSettings)
        {
            ResourseSettings newResourse = new ResourseSettings()
            {
                ID = -1,
                TextName = apiSettings.NameResourse,
                isChecked = false,
                canDelit = true,
                ParserSettingsByte = ObjectToByteArray(apiSettings)
            };
            return newResourse;
        }
        public static void SetMainPage(Page page)
        {
            if (page == null) { return; }
            Current.MainPage = page;
        }
    }
}
