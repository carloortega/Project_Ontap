﻿using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("DistrictID")]
        public string DistrictID { get; set; }

        [Column("DistrictCode")]
        public string DistrictCode { get; set; }

        [Column("DistrictName")]
        public string DistrictName { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
