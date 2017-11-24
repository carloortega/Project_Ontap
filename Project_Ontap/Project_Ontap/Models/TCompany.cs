using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

        [Column("CompName")]
        public string CompName { get; set; }

        [Column("CompAddress")]
        public string CompAddress { get; set; }

        [Column("CompStatus")]
        public string CompStatus { get; set; }

    }
}
