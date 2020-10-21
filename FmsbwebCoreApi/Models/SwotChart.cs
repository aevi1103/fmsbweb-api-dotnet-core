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
        public decimal Target { get; set; }
        public int Gross { get; set; }
        public int Net { get; set; }
        public decimal Oae { get; set; }
        public int SbScrap { get; set; }
        public int PurchasedScrap { get; set; }
        public int Warmers { get; set; }
        public int TotalScrap { get; set; }
        public SwotTargetDto SwotTarget { get; set; }
        public dynamic ScrapRateByArea { get; set; }
        public dynamic ScrapCharts { get; set; }
        public dynamic ProductionCharts { get; set; }
        public dynamic DowntimeCharts { get; set; }
    }
}
