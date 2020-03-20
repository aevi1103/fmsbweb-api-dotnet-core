using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class KpiTarget
    {
        public int KpiTargetId { get; set; }
        public string TargetType { get; set; } // department, shift
        public string Department { get; set; }
        public string Shift { get; set; }
        public int MonthNumber { get; set; }
        public decimal OaeTarget { get; set; } = 0;
        public decimal ScrapRateTarget { get; set; } = 0;
        public decimal PpmhTarget { get; set; } = 0;
        public decimal DowntimeRateTarget { get; set; } = 0;
        public DateTime TimeStamp { get; set; }
        public int Year { get; set; }
    }
}
