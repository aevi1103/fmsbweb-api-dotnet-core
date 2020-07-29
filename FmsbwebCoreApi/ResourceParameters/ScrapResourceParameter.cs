using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class ScrapResourceParameter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? IsPurchasedScrap { get; set; }
        public string Area { get; set; } = "";
        public string ScrapCode { get; set; } = "";
        public string Department { get; set; } = "";
        public string Line { get; set; } = "";
        public string Program { get; set; } = "";
        public string Shift { get; set; } = "";
        public List<string> WorkCenters { get; set; } = new List<string>();
    }
}
