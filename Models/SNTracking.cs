using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB.Models
{
    public class SNTracking
    {
        public int ID { get; set; }

        public string SNName { get; set; }

        public int SNID { get; set; }

        public SN SN { get; set; }

        public int RoutingMapID { get; set; }

        public int RoutingMapStep { get; set; }

        public RoutingMap RoutingMap { get; set; }




        public DateTime UpdateDate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
