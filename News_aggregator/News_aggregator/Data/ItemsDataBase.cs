﻿using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using News_aggregator.Models;

namespace News_aggregator.Data
{
    public class ItemsDataBase
    {
        readonly SQLiteAsyncConnection database;
        int maxID = 0;
        public ItemsDataBase(string connection)
        {
            database = new SQLiteAsyncConnection(connection);
            database.CreateTableAsync<ResourseItem>().Wait();
        }
        //список items которые выбрал пользователь
        public Task<List<ResourseItem>> GetItemsAsync()
        {
            return database.Table<ResourseItem>().ToListAsync();
        }
        //получение одного элемента по id
        public Task<ResourseItem> GetItemAsync(int id)
        {
            return database.Table<ResourseItem>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }
        //количество измененых данных
        public Task<int> SaveItemAsync(ResourseItem item)
        {
            //изменение уже внесенных данных
            if (item.ID <= maxID)
            {
                //изменение знач maxID
                if (item.ID > maxID)
                    maxID = item.ID;
                return database.UpdateAsync(item);
            }
            //новые элементы
            else
            {
                if (item.ID > maxID)
                    maxID = item.ID;
                return database.InsertAsync(item);
            }
        }
        //удаление элемента
        public Task<int> DeleteItemAsync(ResourseItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
