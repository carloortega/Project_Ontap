using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{
    [Table("tClientType")]
    public class TClientType
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ClientTypeID { get; set; }

        public string Desciption { get; set; }

        public string CompID { get; set; }

    }
}
