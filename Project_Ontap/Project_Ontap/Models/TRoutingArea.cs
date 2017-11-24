using SQLite;
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

        [PrimaryKey, AutoIncrement, Column("ID")]
        public int ID { get; set; }

        [Column("RouteID")]
        public string RouteID { get; set; }

        [Column("TerritoryID")]
        public string TerritoryID { get; set; }

        [Column("RouteName")]
        public string RouteName { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("CompID")]
        public string CompID { get; set; }

        [Column("SyncDate")]
        public string SyncDate { get; set; }

        [Column("SyncDevice")]
        public string SyncDevice { get; set; }

        [Column("SyncStatus")]
        public string SyncStatus { get; set; }

    }
}
