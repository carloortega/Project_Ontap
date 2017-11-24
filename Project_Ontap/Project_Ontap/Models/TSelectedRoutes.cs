using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tSelectedRoutes")]
    public class TSelectedRoutes
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("RouteName")]
        public string RouteName { get; set; }

        [Column("Date")]
        public string Date { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
