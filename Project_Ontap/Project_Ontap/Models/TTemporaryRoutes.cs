using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tTemporaryRoutes")]
    public class TTemporaryRoutes
    {

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("RouteName")]
        public string RouteName { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

    }
}
