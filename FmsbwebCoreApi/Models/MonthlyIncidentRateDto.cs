using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class MonthlyIncidentRateDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string MonthName { get; set; }
        public int Recordables { get; set; } = 0;
        public decimal Hours { get; set; } = 0;
        public double Rate { get; set; } = 0;
    }
}
