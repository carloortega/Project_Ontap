using SQLite.Net.Attributes;
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

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string RouteName { get; set; }

        public string Date { get; set; }

        public string CompID { get; set; }

    }
}
