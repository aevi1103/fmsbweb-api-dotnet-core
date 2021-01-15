using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Logistics
{
    public class SafetyStockDaysResourceParameter
    {
        public int StockSafetyDaysId { get; set; } = 0;
        public string MaterialNumber { get; set; }
        public int Days { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
