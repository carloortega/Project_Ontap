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

        public Task<TUserLogin> GetAccount(String username, String password)
        {
            return database.Table<TUserLogin>().Where(i => i.EmailAddress == username && i.Password == password).FirstOrDefaultAsync();
        }

        public Task<TEmployee> GetUserDetails(String username)
        {
            return database.Table<TEmployee>().Where(i => i.EmailAddress == username).FirstOrDefaultAsync();
        }

        public Task<List<TClient>> GetItemsAsync()
        {
            return database.Table<TClient>().ToListAsync();
        }

        public Task<List<TClientClass>> GetClientTarget()
        {
            return database.QueryAsync<TClientClass>("SELECT Frequency FROM [tClientClass] JOIN tClient ON tClientClass.ClientClassCode = tClient.ClientClassCode WHERE tClient.ClientID = " + 3 + "");
        }

        public Task<List<TClient>> GetClientName()
        {
            return database.QueryAsync<TClient>("SELECT ClientName FROM [tClient] WHERE ClientID = " + 3 + "");
        }

        public Task<List<TClientContacts>> GetClientContacts()
        {
            return database.QueryAsync<TClientContacts>("SELECT ContactPerson FROM [tClientContacts] WHERE ClientID = " + 3 + "");
        }

        public Task<List<TClientCall>> GetCompletedCallCount()
        {
            return database.QueryAsync<TClientCall>("SELECT * FROM [tClientCall] JOIN tClient ON tClientCall.ClientID = tClient.ClientID " +
                "WHERE tClientCall.ClientID = '3' AND tClientCall.ClientCallStatus = 'Completed'");
        }

        public Task<List<TClientCall>> GetMissedCallCount()
        {
            return database.QueryAsync<TClientCall>("SELECT * FROM [tClientCall] JOIN tClient ON tClientCall.ClientID = tClient.ClientID " +
                "WHERE tClientCall.ClientID = '3' AND tClientCall.ClientCallStatus = 'Missed'");
        }

        public Task<List<TClientCall>> GetMaxClientCall()
        {
            return database.QueryAsync<TClientCall>("SELECT ClientCallDate FROM [tClientCall] JOIN tClient ON tClientCall.ClientID = tClient.ClientID " +
                "WHERE tClientCall.ClientID = '3' AND tClientCall.ClientCallStatus = 'Completed' ORDER BY ClientCallDate DESC");
        }
    }
}
