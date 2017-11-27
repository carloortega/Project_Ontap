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

        //public Task<TUserLogin> GetEmailAddress(String username)
        //{
        //    return database.Table<TUserLogin>().Where(i => i.EmailAddress == username).FirstAsync();
        //}

        public Task<TUserLogin> GetAccount(String username, String password)
        {
            return database.Table<TUserLogin>().Where(i => i.EmailAddress == username && i.Password == password).FirstOrDefaultAsync();
        }

    }
}
