using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.SAP
{
    public class DepartmentScrapDto
    {
        public int Total { get; set; }
        public int SapGross { get; set; }
        public decimal ScrapRate { get; set; }
        public IEnumerable<DepartmentScrapDetailsDto> Details { get; set; }
    }
}
