using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters
{
    public class PlcDowntimeResourceParameter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TagName { get; set; } = "";
        public string Line { get; set; } = "";
    }
}
