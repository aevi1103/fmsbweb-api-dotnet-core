using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Models.Intranet
{
    public class HxhProductionDto
    {
        public string Department { get; set; }
        public string Area { get; set; }

        public SwotTargetDto SwotTarget { get; set; }

        public decimal Target { get; set; }
        public int Gross { get; set; }
        public int GrossWithWarmers { get; set; }
        public int Net { get; set; }

        public int Warmers { get; set; }
        public int Sol { get; set; }
        public int GageScrap { get; set; }
        public int VisualScrap { get; set; }
        public int Eol { get; set; }
        public int TotalScrap { get; set; }

        public int MachiningEosScrap { get; set; } //total scrap linked to mach. eos report

        public List<Scrap2> WarmersDefects { get; set; } = new List<Scrap2>();
        public List<Scrap2> SolDefects { get; set; } = new List<Scrap2>();
        public List<Scrap2> GageScrapDefects { get; set; } = new List<Scrap2>();
        public List<Scrap2> VisualScrapDefects { get; set; } = new List<Scrap2>();
        public List<Scrap2> EolDefects { get; set; } = new List<Scrap2>();
        public List<Scrap2> TotalScrapDefects { get; set; } = new List<Scrap2>();
    }
}
