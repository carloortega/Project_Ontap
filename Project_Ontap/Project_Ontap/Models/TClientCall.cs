using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tClientCall")]
    public class TClientCall
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ClientCallID { get; set; }

        public string ClientID { get; set; }

        public string ClientCallDate { get; set; }

        public string EmployeeID { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string ClientCallStatus { get; set; }

        public string ContactPerson { get; set; }

        public string ClientCallImage { get; set; }

        public string Remarks { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
