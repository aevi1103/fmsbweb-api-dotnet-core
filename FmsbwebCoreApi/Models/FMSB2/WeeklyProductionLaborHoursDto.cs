using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class WeeklyProductionLaborHoursDto
    {
        public DateTime WeekStart { get; set; }
        public DateTime WeekEnd { get; set; }
        public int WeekNumber { get; set; }
        public int Year { get; set; }
        public string YearWeekNumber => $"{Year}-WK{WeekNumber}";
        public ProductionLaborHoursDto Details { get; set; } = new ProductionLaborHoursDto();
    }
}
