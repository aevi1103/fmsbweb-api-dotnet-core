using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;

namespace FmsbwebCoreApi.Models
{
    public class SwotChartType
    {
        public string Key { get; set; }
        public dynamic ChartData { get; set; }
    }
}
