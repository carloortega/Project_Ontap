using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tTerritoryStructure")]
    public class TTerritoryStructure
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string NationalID { get; set; }

        public string RegionID { get; set; }

        public string DistrictID { get; set; }

        public string TerritoryID { get; set; }

        public string CompID { get; set; }

    }
}
