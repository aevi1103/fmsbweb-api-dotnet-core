using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class LogisticsInventoryCostTarget
    {
        public int LogisticsInventoryCostTargetId { get; set; }
        public LogisticsInventoryCostType LogisticsInventoryCostType { get; set; }
        public int LogisticsInventoryCostTypeId { get; set; }
        public decimal Target { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
