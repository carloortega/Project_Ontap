using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string NationalID { get; set; }

        public string NationalName { get; set; }

        public string EmployeeID { get; set; }

        public string CompID { get; set; }

    }
}
