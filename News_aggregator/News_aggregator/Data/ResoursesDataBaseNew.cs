using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using News_aggregator.Models;

namespace News_aggregator.Data
{
    public class ResoursesDataBaseNew
    {
        readonly SQLiteAsyncConnection databasenew;
        public ResoursesDataBaseNew(string connection)
        {
            databasenew = new SQLiteAsyncConnection(connection);
            databasenew.CreateTableAsync<ResourseSettings>().Wait();
        }
        //список items которые выбрал пользователь
        public Task<List<ResourseSettings>> GetItemsAsync()
        {
            return databasenew.Table<ResourseSettings>().ToListAsync();
        }
        //получение одного элемента по id
        public Task<ResourseSettings> GetItemAsync(int id)
        {
            return databasenew.Table<ResourseSettings>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        //количество измененых данных
        public Task<int> SaveItemAsync(ResourseSettings item)
        {
            var elements = GetItemsAsync().Result;
            int maxID = 0;
            foreach(var el in elements)
            {
                if (maxID < el.ID) { maxID = el.ID; }
            }
            //изменение уже внесенных данных (-1 позиция самоопределения ID)
            if (item.ID <= maxID && item.ID != -1)
            {
                //изменение знач maxID
                return databasenew.UpdateAsync(item);
            }
            //новые элементы
            else
            {
                if (item.ID == -1) { item.ID = maxID + 1; }
                return databasenew.InsertAsync(item);
            }
        }
        //удаление элемента
        public Task<int> DeleteItemAsync(ResourseSettings item)
        {
            return databasenew.DeleteAsync(item);
        }
    }
}
