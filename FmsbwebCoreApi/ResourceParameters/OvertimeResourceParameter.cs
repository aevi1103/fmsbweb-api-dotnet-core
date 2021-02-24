using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Enums;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class OvertimeResourceParameter
    {
        public int Year { get; set; } = DateTime.Now.Year;
        public string TypeName { get; set; }
        public DateTime? Date { get; set; }
    }
}
