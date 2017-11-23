using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{
    [Table("tClientClass")]
    public class TClientClass
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string ClientClassCode { get; set; }

        public string Description { get; set; }

        public string Frequency { get; set; }

        public string CompID { get; set; }

    }
}
