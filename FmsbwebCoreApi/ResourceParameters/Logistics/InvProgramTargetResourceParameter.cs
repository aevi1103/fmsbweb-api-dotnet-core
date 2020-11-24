using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.ResourceParameters.Logistics
{
    public class InvProgramTargetResourceParameter
    {
        public int Id { get; set; }
        public string Program { get; set; }
        public string Sloc { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public DateTime Stamp { get; set; } = DateTime.Now;
    }
}
