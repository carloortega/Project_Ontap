﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tNational")]
    public class TNational
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("NationalID")]
        public string NationalID { get; set; }

        [Column("NationalName")]
        public string NationalName { get; set; }

        [Column("EmployeeID")]
        public string EmployeeID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
