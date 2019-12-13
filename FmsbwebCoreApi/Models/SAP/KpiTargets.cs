using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class KpiTargets
    {
        public string Area { get; set; }
        public string Kpi { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
    }
}
