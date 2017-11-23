using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tClient")]
    public class TClient
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ClientID { get; set; }

        public string ClientName { get; set; }

        public string ClientAddress { get; set; }

        public string ClientTypeID { get; set; }

        public string ClientClassCode { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
