using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class IncidentsByDepartmentForChartDto
    {
        public IEnumerable<string> Categories { get; set; } = new List<string>();
        public IEnumerable<InjuryStatusDto> Series { get; set; } = new List<InjuryStatusDto>();
        public IEnumerable<IncidentsByDepartmentDto> Data { get; set; } = new List<IncidentsByDepartmentDto>();
    }
}
