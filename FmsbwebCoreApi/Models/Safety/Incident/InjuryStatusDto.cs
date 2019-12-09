using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class InjuryStatusDto
    {
        public string InjuryStatus { get; set; }
        public int NumberOfIncidents { get; set; }
        public string ColorCode { get; set; }
    }
}
