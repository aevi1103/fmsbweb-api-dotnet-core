using FmsbwebCoreApi.Models.SAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Models.FMSB2
{
    public class ProdScrapForLaborHours
    {
        public IEnumerable<SapProdDto> Prod { get; set; }
        public IEnumerable<Scrap> Scrap { get; set; }
    }
}
