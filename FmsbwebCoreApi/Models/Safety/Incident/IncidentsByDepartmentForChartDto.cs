using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class IncidentsByDepartmentForChartDto
    {
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<InjuryStatusDto> Series { get; set; }
        public IEnumerable<IncidentsByDepartmentDto> Data { get; set; }
    }
}
