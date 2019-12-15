using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.FMSB
{
    public class FmsbResourceParameter
    {
        public DateTime Start { get; set; } = DateTime.Today.AddDays(-1);
        public DateTime End { get; set; } = DateTime.Today.AddDays(-1);
        public string Area { get; set; }
    }
}
