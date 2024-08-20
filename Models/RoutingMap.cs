using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB.Models
{
    public class RoutingMap
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int ResourceGroupID { get; set; }

        public int StationID { get; set; }

        public int OperationID { get; set; }

        public int Step { get; set; } = 0;

        public ResourceGroup ResourceGroup { get; set; }
        public Station Station { get; set; }
        public Operation Operation { get; set; }

        public ICollection<ProductionOrder> ProductionOrders { get; set; }

     

        public DateTime UpdateDate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
