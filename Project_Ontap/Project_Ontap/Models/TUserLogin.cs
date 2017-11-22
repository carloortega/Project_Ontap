using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{
    [Table("tUserLogin")]
    public class TUserLogin
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Email_Address { get; set; }

        public string Password { get; set; }

        public string EmployeeID { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
