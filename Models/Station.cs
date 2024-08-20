using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB.Models
{
    public class Station
    {
        public int ID { get; set; }
        public string Name { get; set; }

       // public int ResourceGroupId { get; set; }

       // public ResourceGroup ResourceGroup { get; set; }

       // public ICollection<Operation> Operations { get; set; }

        public ICollection<RoutingMap> RoutingMaps { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
