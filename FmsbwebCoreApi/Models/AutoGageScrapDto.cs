using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models
{
    public class AutoGageScrapDto
    {
        public string Part { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime ShiftDate { get; set; }
        public string Shift { get; set; }
        public int Line { get; set; }
        public string Defect { get; set; }

        public string Machine => $"Line {Line}";
    }
}
