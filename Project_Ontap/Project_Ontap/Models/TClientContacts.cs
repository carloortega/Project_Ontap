using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("ClientID")]
        public string ClientID { get; set; }

        [Column("Department")]
        public string Department { get; set; }

        [Column("Designation")]
        public string Designation { get; set; }

        [Column("ContactPerson")]
        public string ContactPerson { get; set; }

        [Column("ContactNumber")]
        public string ContactNumber { get; set; }

        [Column("ContactPersonStatus")]
        public string ContactPersonStatus { get; set; }

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
