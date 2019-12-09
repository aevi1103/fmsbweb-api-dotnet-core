using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Helpers
{
    public class SafetyFormula
    {
        public double CalculateIncidentRates(int recordable, double manHours)
        {
            var rec = (recordable * 200000);
            var rate = manHours == 0 ? 0 : rec / manHours;
            return Math.Round(rate,2);
        }
    }
}
