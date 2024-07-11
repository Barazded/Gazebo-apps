using NewsAggregator.Models;
using NewsAggregator.Data;
using NewsAggregator.Pages;
using Newtonsoft.Json;
using System.Text;
[assembly: ExportFont("Inter.ttf", Alias = "Inter")]

namespace NewsAggregator
{
    public enum ResourseType { economyc, games, tech, all }
    public enum TypeProp { string_, int_ }
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
                    databasenew = new ResoursesDataBaseNew(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ResourseNew10.db3"));
                }
                return databasenew;
            }
        }

        public App()
        {
            InitializeComponent();
            int pos = (int)GetProp("IsRegist", TypeProp.int_);
            if (pos == 0) { SetMainPage(new EnterPage()); }
            else { SetMainPage(new AppShell()); }
            //если приложение открылось в первый раз
            if (!Preferences.ContainsKey("curentStandart"))
            {
                SetProp("pickerInx", 0);
                SetProp("curentStandart", 6);
                SetProp("filterInx", 0);
                SetProp("currentFilter", "всё");
            }
        }

        protected override void OnStart()
        {
            ResourseSettings Banki = new()
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
            ResourseSettings Investing = new()
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
            ResourseSettings StopGame = new()
            {
                ID = 3,
                canDelit = false,
                TextName = "IXBTgames",
                ParserSettingsByte = ObjectToByteArray(new ParserSettings
                {
                    NameResourse = "IXBTgames",
                    UrlResourse = "https://ixbt.games/news/",
                    TypeResourse = "игры",
                    TitleSelector = "body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) > div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a",
                    LinkSelector = "body > div > div.main.clearfix.m-wrap > div > section > div:nth-child(n) > div:nth-child(n) > div > div > div.col.mx-3.d-flex.flex-column > div.card-title.my-2.order-1.order-sm-0 > a",
                })
            };
            ResourseSettings rbkEconomyc = new()
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
            ResourseSettings IXBTtech = new()
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
            List<ResourseSettings> listResourse = new()
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
        public static byte[] ObjectToByteArray(object obj)
        {
            return System.Text.Json.JsonSerializer.SerializeToUtf8Bytes(obj);
        }
        public static TData ByteArrayToObject<TData>(byte[] byteArray)
        {
            var res = JsonConvert.DeserializeObject<TData>(Encoding.UTF8.GetString(byteArray));
            return res;
        }
        public static ResourseSettings ConvertApiToResourseSettings(ParserSettings apiSettings)
        {
            ResourseSettings newResourse = new()
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
        public static object GetProp(string name, TypeProp typeProp)
        {
            if (typeProp == TypeProp.int_)
            {
                return int.Parse(Preferences.Get(name, "0").ToString());
            }
            else
            {
                return Preferences.Get(name, "").ToString();
            }
        }
        public static void SetProp(string name, object val)
        {
            Preferences.Set(name, val.ToString());
        }
    }
}
