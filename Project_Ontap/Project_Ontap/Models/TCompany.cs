using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tCompany")]
    public class TCompany
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string CompID { get; set; }

        public string CompName { get; set; }

        public string CompAddress { get; set; }

        public string CompStatus { get; set; }

    }
}
