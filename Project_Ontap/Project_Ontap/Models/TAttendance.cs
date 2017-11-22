using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string EmployeeID { get; set; }

        public string AttendanceDate { get; set; }

        public string TimeIn { get; set; }

        public string TimeOut { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
