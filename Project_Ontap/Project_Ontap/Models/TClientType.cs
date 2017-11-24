using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("ClientTypeID")]
        public string ClientTypeID { get; set; }

        [Column("Description")]
        public string Desciption { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
