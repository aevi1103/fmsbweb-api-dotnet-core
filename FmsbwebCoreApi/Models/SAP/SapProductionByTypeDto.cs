using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class SapProductionByTypeDto
    {
        public int Total { get; set; }
        public IEnumerable<SapProductionTypeDetailsDto> Details { get; set; }
    }
}
