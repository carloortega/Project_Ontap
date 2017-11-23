using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tDistrict")]
    public class TDistrict
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string DistrictID { get; set; }

        public string DistrictCode { get; set; }

        public string DistrictName { get; set; }

        public string EmployeeID { get; set; }

        public string CompID { get; set; }

    }
}
