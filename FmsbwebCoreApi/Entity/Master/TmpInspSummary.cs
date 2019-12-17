using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tmpInspSummary")]
    public partial class TmpInspSummary
    {
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InspDate { get; set; }
        [StringLength(1)]
        public string Line { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("RunID")]
        [StringLength(2)]
        public string RunId { get; set; }
        public int? GrossRun { get; set; }
        [Column("EOLFScrap")]
        public int? Eolfscrap { get; set; }
        [Column("MRRFScrap")]
        public int? Mrrfscrap { get; set; }
        [Column("TOTFdryScrap")]
        public int? TotfdryScrap { get; set; }
        [Column("EOLMScrap")]
        public int? Eolmscrap { get; set; }
        [Column("MRRMScrap")]
        public int? Mrrmscrap { get; set; }
        [Column("TOTMchnScrap")]
        public int? TotmchnScrap { get; set; }
        [Column("EOLLScrap")]
        public int? Eollscrap { get; set; }
        [Column("MRRLScrap")]
        public int? Mrrlscrap { get; set; }
        [Column("TOTLineScrap")]
        public int? TotlineScrap { get; set; }
        public int? OriginalHold { get; set; }
        public int? GoodHold { get; set; }
        public int? ScrapHold { get; set; }
        public int? HoldBalance { get; set; }
        public int? NetRun { get; set; }
    }
}
