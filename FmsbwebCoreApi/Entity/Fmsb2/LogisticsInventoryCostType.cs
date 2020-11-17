using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class LogisticsInventoryCostType
    {
        public int LogisticsInventoryCostTypeId { get; set; }
        public string Type { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public int Order { get; set; } = 1;
    }
}
