using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string RegionID { get; set; }

        public string RegionName { get; set; }

        public string EmployeeID { get; set; }

        public string CompID { get; set; }

    }
}
