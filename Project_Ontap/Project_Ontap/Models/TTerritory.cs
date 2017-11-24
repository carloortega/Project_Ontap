using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tTerritory")]
    public class TTerritory
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("TerritoryID")]
        public string TerritoryID { get; set; }

        [Column("TerritoryCode")]
        public string TerritoryCode { get; set; }

        [Column("TerritoryName")]
        public string TerritoryName { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }


    }
}
