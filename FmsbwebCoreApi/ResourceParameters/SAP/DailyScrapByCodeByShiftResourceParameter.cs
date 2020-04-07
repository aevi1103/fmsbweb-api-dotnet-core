using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.SAP
{
    public class DailyScrapByCodeByShiftResourceParameter
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string ScrapCode { get; set; } = "";
        public bool IsPurchasedScrap { get; set; } = false;
        public bool IsTotalScrap { get; set; }
    }
}
