using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class ScrapByCodeDto
    {
        public int Total { get; set; }
        public int SapGross { get; set; }
        public decimal ScrapRate { get; set; }
        public IEnumerable<ScrapByCodeDetailsDto> Details { get; set; }
    }
}
