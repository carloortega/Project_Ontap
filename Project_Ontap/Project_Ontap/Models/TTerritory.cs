using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string TerritoryID { get; set; }

        public string TerritoryCode { get; set; }

        public string TerritoryName { get; set; }

        public string EmployeeID { get; set; }

        public string Status { get; set; }

        public string CompID { get; set; }


    }
}
