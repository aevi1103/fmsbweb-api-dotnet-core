using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxhProductionByProgramLineDto : HxhProductionDto
    {
        public string Program { get; set; }
        public string Line { get; set; }
    }
}
