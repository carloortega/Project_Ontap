using Project_Ontap.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Data
{
    public class RecordsDatabase
    {
        readonly SQLiteAsyncConnection database;

        public RecordsDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
        }

        public Task<TUserLogin> GetEmailAddress(string username)
        {
            return database.Table<TUserLogin>().Where(i => i.EmailAddress == username).FirstOrDefaultAsync();
        }

        public Task<TUserLogin> GetPassword(string password)
        {
            return database.Table<TUserLogin>().Where(i => i.Password == password).FirstOrDefaultAsync();
        }
    }
}
