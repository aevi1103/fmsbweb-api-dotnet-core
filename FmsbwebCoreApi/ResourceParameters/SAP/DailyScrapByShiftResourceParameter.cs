using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.SAP
{
    public class DailyScrapByShiftResourceParameter
    {
        public DateTime Start { get; set; } 
        public DateTime End { get; set; }
        public string Line { get; set; }
        public string Program { get; set; }
        public string ScrapCode { get; set; }
        public bool IsPurchasedScrap { get; set; } = false;
    }
}
