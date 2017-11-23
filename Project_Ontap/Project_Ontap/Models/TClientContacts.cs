using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tClientContacts")]
    public class TClientContacts
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ClientID { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public string ContactPerson { get; set; }

        public string ContactNumber { get; set; }

        public string ContactPersonStatus { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
