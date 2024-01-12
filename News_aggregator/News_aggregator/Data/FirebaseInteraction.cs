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
            var elements = await firebase.Child("APIs").OrderByKey().OnceAsync<ParserSettings>();
            List<FirebaseDataModel> data = new List<FirebaseDataModel>();
            foreach(var el in elements)
            {
                FirebaseDataModel firebaseDataModel = new FirebaseDataModel()
                {
                    id = el.Key,
                    apiSettings = el.Object
                };
                data.Add(firebaseDataModel);
            }
            return data;
        }
    }
}
