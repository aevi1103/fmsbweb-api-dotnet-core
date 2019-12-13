using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class LaborHoursDetailsByType
    {
        public string Type { get; set; }
        public string Role { get; set; }
        public decimal? Hours { get; set; }
    }
}
