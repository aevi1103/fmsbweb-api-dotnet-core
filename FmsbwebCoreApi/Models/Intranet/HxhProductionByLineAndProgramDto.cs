using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxhProductionByLineAndProgramDto
    {
        public IEnumerable<HxHProductionByLineDto> LineDetails { get; set; }
        public IEnumerable<HxhProductionByProgramDto> ProgramDetails { get; set; }
        public IEnumerable<HxHProductionByShiftDto> LineShiftDetails { get; set; }
        public IEnumerable<HxhProductionByProgramLineDto> ProgramLineDetails { get; set; }
    }
}
