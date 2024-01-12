using System;
using System.IO;
using Xamarin.Forms;
using News_aggregator.Models;
using News_aggregator.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using News_aggregator.Pages;

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
            //MainPage = new CustomTabbedPage();
            //new_TEST
            if (!Current.Properties.ContainsKey("IsRegist")) { SetMainPage(new EnterPage()); }
            else { SetMainPage(new CustomTabbedPage()); }
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
                    TypeResourse = ResourseType.economyc,
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
                    TypeResourse = ResourseType.economyc,
                    TitleSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a",
                    LinkSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > a",
                    InfoSelector = "#latestNews > div > article:nth-child(n) > div.textDiv > p"
                })
            };
            ResourseSettings StopGame = new ResourseSettings
            {
                ID = 3,
                canDelit = false,
                TextName = "StopGame",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "StopGame",
                    UrlResourse = "https://stopgame.ru/news",
                    TypeResourse = ResourseType.games,
                    TitleSelector = "#w0 > div:nth-child(n) > div:nth-child(n) > div > div > a",
                    LinkSelector = "#w0 > div:nth-child(n) > div:nth-child(n) > div > div > a",
                    DateSelector = "#w0 > div:nth-child(n) > div:nth-child(n) > div > div > div > div._info-row_11mk8_121 > span"
                })
            };
            List<ResourseSettings> listResourse = new List<ResourseSettings>()
            {
                Banki,Investing,StopGame
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
