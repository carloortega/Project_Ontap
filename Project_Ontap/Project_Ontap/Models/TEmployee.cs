using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("EmailAddress")]
        public string EmailAddress { get; set; }

        [Column("Role")]
        public string Role { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("ContactNumber")]
        public string ContactNumber { get; set; }

        [Column("UserImage")]
        public string UserImage { get; set; }

        [Column("MobileAppVersion")]
        public string MobileAppVersion { get; set; }

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
