using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("Sequence")]
        public int Sequence { get; set; }

        [Column("Year")]
        public int Year { get; set; }

        [Column("Month")]
        public int Month { get; set; }

        [Column("NumOfDays")]
        public int NumOfDays { get; set; }

        [Column("TerritoryID")]
        public string TerritoryID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
