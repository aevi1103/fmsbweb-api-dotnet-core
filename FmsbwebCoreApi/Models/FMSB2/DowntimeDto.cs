using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class DowntimeDto
    {
        public string Dept { get; set; }
        public string Line { get; set; }
        public DateTime ShifDate { get; set; }
        public string Shift { get; set; }
        public int Hour { get; set; }
        public string Machine { get; set; }
        public string Reason1 { get; set; }
        public string Reason2 { get; set; }
        public string Comments { get; set; }
        public decimal? DowntimeLoss { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Type { get; set; }
    }
}
