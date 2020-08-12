using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public class EndOfShiftReport
    {
        public int EndOfShiftReportId { get; set; }
        [Required]
        public DateTime ShiftDate { get; set; }
        [Required]
        public string Shift { get; set; }
        [Required]
        public int MachineId { get; set; }
        public virtual Machines Machine { get; set; }
        public string ScrapComment { get; set; }
        public string DowntimeComment { get; set; }
        [Required]
        public int Manning { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
