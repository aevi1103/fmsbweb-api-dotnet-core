using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MrrscrapView
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Dte { get; set; }
        [Required]
        [Column("SAP")]
        [StringLength(50)]
        public string Sap { get; set; }
        [Column("FMPart")]
        [StringLength(7)]
        public string Fmpart { get; set; }
        [Required]
        [StringLength(9)]
        public string Category { get; set; }
        [Required]
        [StringLength(50)]
        public string Batch { get; set; }
        [Required]
        [Column("SLOC")]
        [StringLength(50)]
        public string Sloc { get; set; }
        [StringLength(12)]
        public string CostCenter { get; set; }
        [StringLength(50)]
        public string CostDesc { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("mrrNum")]
        [StringLength(50)]
        public string MrrNum { get; set; }
        [Column("com")]
        public string Com { get; set; }
        [Column("docNum")]
        [StringLength(50)]
        public string DocNum { get; set; }
        [Column("lead")]
        [StringLength(50)]
        public string Lead { get; set; }
        [StringLength(14)]
        public string Program { get; set; }
        [Column("weekNum")]
        public int? WeekNum { get; set; }
    }
}
