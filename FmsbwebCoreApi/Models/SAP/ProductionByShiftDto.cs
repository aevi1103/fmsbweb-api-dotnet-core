using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ProductionByShiftDto : ProductionDetailsDto
    {
        public string Shift { get; set; }
    }
}
