using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.SAP
{
    public class SapResouceParameter
    {
        public DateTime Start { get; set; } = DateTime.Today.AddDays(-1);
        public DateTime End { get; set; } = DateTime.Today.AddDays(-1);
        public string Area { get; set; }
    }
}
