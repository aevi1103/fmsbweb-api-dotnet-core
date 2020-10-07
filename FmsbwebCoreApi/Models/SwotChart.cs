using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class SwotChart
    {
        public string Line { get; set; }
        public List<SwotChartType> Charts { get; set; } = new List<SwotChartType>();
    }
}
