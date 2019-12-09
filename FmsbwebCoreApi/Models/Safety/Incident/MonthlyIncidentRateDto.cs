using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Safety.Incident
{
    public class MonthlyIncidentRateDto
    {
        public int MonthNumber { get; set; }
        public string Month { get; set; }
        public int NumberOfRecordable { get; set; }
        public double ManHours { get; set; }
        public double IncidentRate { get; set; }   
    }
}
