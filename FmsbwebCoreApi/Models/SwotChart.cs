using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class SwotChart
    {
        public string Line { get; set; }
        public dynamic ScrapCharts { get; set; }
        public dynamic ProductionCharts { get; set; }
        public dynamic DowntimeCharts { get; set; }
    }
}
