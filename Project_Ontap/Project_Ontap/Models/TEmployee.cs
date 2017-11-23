using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tEmployee")]
    public class TEmployee
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string EmployeeID { get; set; }

        public string EmailAddress { get; set; }

        public string Role { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumber { get; set; }

        public string UserImage { get; set; }

        public string MobileAppVersion { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
