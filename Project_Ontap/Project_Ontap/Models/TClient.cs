using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("ClientID")]
        public string ClientID { get; set; }

        [Column("ClientName")]
        public string ClientName { get; set; }

        [Column("ClientAddress")]
        public string ClientAddress { get; set; }

        [Column("ClientTypeID")]
        public string ClientTypeID { get; set; }

        [Column("ClientClassCode")]
        public string ClientClassCode { get; set; }

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
