using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class EndOfShiftReport
    {
        public int EndOfShiftReportId { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public int MachineId { get; set; }
        public virtual Machines Machine { get; set; }
        public string ScrapComment { get; set; }
        public string DowntimeComment { get; set; }
        public int Manning { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
