using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Models
{
    public class SwotChart
    {
        public string Line { get; set; }
        public SwotResourceParameter Filters { get; set; }
        public SwotTargetDto SwotTarget { get; set; }
        public dynamic ScrapCharts { get; set; }
        public dynamic ProductionCharts { get; set; }
        public dynamic DowntimeCharts { get; set; }
    }
}
