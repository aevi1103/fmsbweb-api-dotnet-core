using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.SAP
{
    public class StockSafetyDays
    {
        public int StockSafetyDaysId { get; set; }
        public string MaterialNumber { get; set; }
        public int Days { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
