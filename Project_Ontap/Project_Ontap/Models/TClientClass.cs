using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("ClientClassCode")]
        public string ClientClassCode { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Frequency")]
        public string Frequency { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
