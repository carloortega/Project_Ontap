using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tAttendance")]
    public class TAttendance
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("AttendanceDate")]
        public string AttendanceDate { get; set; }

        [Column("TimeIn")]
        public string TimeIn { get; set; }

        [Column("TimeOut")]
        public string TimeOut { get; set; }

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
