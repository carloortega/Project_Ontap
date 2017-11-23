using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string RouteName { get; set; }

        public string CompID { get; set; }

    }
}
