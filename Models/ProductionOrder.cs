using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB.Models
{
    public class ProductionOrder
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Partnumber { get; set; }

        public int RoutingMapID { get; set; }

        public RoutingMap RoutingMap { get; set; }

        public ICollection<SN> SNs { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
