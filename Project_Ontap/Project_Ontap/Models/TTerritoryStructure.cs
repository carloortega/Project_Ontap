﻿using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("NationalID")]
        public string NationalID { get; set; }

        [Column("RegionID")]
        public string RegionID { get; set; }

        [Column("DistrictID")]
        public string DistrictID { get; set; }

        [Column("TerritoryID")]
        public string TerritoryID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
