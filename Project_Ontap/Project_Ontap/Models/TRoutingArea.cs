using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ontap.Models
{

    [Table("tRoutingArea")]
    public class TRoutingArea
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string RouteID { get; set; }

        public string TerritoryID { get; set; }

        public string RouteName { get; set; }

        public string Status { get; set; }

        public string CompID { get; set; }

        public string SyncDate { get; set; }

        public string SyncDevice { get; set; }

        public string SyncStatus { get; set; }

    }
}
