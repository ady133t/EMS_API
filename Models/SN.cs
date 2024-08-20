using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEETEK_EMS_DB.Models
{
    public class SN
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public int ProductionOrderID { get; set; }

        public ProductionOrder ProductionOrder { get; set; } //navigation properties

        public DateTime UpdateDate { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
