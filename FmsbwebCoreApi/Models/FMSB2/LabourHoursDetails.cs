using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class LabourHoursDetails
    {
        public decimal? Regular { get; set; }
        public decimal? Overtime { get; set; }
        public decimal? DoubleTime { get; set; }
        public decimal? Orientation { get; set; }
        public decimal? OverAll { get; set; }
    }
}
