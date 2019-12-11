using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Logistics
{
    public class StockOverviewResouceParameter
    {
        public DateTime Date { get; set; } = DateTime.Today;
        public DateTime Start { get; set; } = DateTime.Today;
        public DateTime End { get; set; } = DateTime.Today;
    }
}
