using Firebase.Database;
using Firebase.Database.Query;
using News_aggregator.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace News_aggregator.Data
{
    internal class FirebaseInteraction
    {
        internal static FirebaseClient GetDataBase()
        {
            var firebase = new FirebaseClient("https://gzebo-news-aggregator-apis-default-rtdb.europe-west1.firebasedatabase.app/");
            return firebase;
        }
        internal static async void SaveDataFirebase(ParserSettings data)
        {
            var firebase = GetDataBase();
            await firebase.Child("APIs").PostAsync(data);
        }
        internal static async Task<List<FirebaseDataModel>> GetAllDataFromFirebase()
        {
            var firebase = GetDataBase();
            IReadOnlyCollection<FirebaseObject<ParserSettings>> elements = new List<FirebaseObject<ParserSettings>>();
            try
            {
                elements = await firebase.Child("APIs").OrderByKey().OnceAsync<ParserSettings>();
            }
            catch
            {
                return null;
            }
            List<FirebaseDataModel> data = new List<FirebaseDataModel>();
            foreach(var el in elements)
            {
                FirebaseDataModel firebaseDataModel = new FirebaseDataModel()
                {
                    Id = el.Key,
                    ApiSettings = el.Object
                };
                data.Add(firebaseDataModel);
            }
            return data;
        }
        internal static async Task<string> GetNickname(string login)
        {
            var firebase = GetDataBase();
            var allData = await firebase.Child("Nicknames").OrderByKey().OnceSingleAsync<Dictionary<string,string>>();
            var data = new Dictionary<string,string>();
            foreach(var el in allData)
            {
                data.Add(el.Key, el.Value);
            }
            foreach (var element in data)
            {
                if (element.Key == login) { return element.Value; }
            }
            return null;
        }
        internal static void DelitApiFromFirebase(string id)
        {
            var firebase = GetDataBase();
            firebase.Child("APIs").Child(id).DeleteAsync();
        }
        internal async static Task<FirebaseDataModel> GetFirebaseData(string id)
        {
            var data = await GetAllDataFromFirebase();
            foreach (FirebaseDataModel el in data)
            {
                if (el.Id == id)
                {
                    return el;
                }
            }
            return null;
        }
    }
}
