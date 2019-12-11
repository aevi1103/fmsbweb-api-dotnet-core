using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Safety
{
    public class IncidentByDepartmentResouceParameter
    {
        public DateTime Start { get; set; } = new DateTime(DateTime.Today.Year, 1, 1);
        public DateTime End { get; set; } = DateTime.Today;
    }
}
