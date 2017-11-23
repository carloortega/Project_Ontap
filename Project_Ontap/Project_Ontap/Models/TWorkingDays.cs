using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tWorkingDays")]
    public class TWorkingDays
    {

        [PrimaryKey, AutoIncrement]
        public int Sequence { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int NumOfDays { get; set; }

        public string TerritoryID { get; set; }

        public string CompID { get; set; }

    }
}
