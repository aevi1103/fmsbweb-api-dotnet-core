using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DailyDepartmentKpiDto
    {
        public string Area { get; set; }
        public DateTime ShiftDate { get; set; }
        public int TotalAreaScrap { get; set; }
        public int TotalProduction { get; set; }
        public int TotalDowntime { get; set; }
        public int Target { get; set; }
        public int SapGross { get; set; }
        public decimal SapOae { get; set; }
        public decimal ScrapRate { get; set; }
        public decimal DowntimeRate { get; set; }
    }
}
