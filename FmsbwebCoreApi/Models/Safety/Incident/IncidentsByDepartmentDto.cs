using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class IncidentsByDepartmentDto : DepartmentDto
    {
        public IEnumerable<InjuryStatusDto> Injuries { get; set; }
        public int Total { get; set; }
    }


}
