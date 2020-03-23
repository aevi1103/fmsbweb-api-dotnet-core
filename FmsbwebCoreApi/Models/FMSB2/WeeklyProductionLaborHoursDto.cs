using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class WeeklyProductionLaborHoursDto
    {
        public int WeekNumber { get; set; }
        public int Year { get; set; }
        public string YearWeekNumber => $"{Year}-WK{WeekNumber}";
        public ProductionLaborHoursDto Details { get; set; } = new ProductionLaborHoursDto();
    }
}
