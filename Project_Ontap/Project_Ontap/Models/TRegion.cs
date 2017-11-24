using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tRegion")]
    public class TRegion
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("RegionID")]
        public string RegionID { get; set; }

        [Column("RegionName")]
        public string RegionName { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
