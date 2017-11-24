using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("ClientCallID")]
        public string ClientCallID { get; set; }

        [Column("ClientID")]
        public string ClientID { get; set; }

        [Column("ClientCallDate")]
        public string ClientCallDate { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("StartTime")]
        public string StartTime { get; set; }

        [Column("EndTime")]
        public string EndTime { get; set; }

        [Column("ClientCallStatus")]
        public string ClientCallStatus { get; set; }

        [Column("ContactPerson")]
        public string ContactPerson { get; set; }

        [Column("ClientCallImage")]
        public string ClientCallImage { get; set; }

        [Column("Remarks")]
        public string Remarks { get; set; }

        [Column("Latitude")]
        public string Latitude { get; set; }

        [Column("Longitude")]
        public string Longitude { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

        [Column("SyncDate")]
        public string SyncDate { get; set; }

        [Column("SyncDevice")]
        public string SyncDevice { get; set; }

        [Column("SyncStatus")]
        public string SyncStatus { get; set; }

    }
}
