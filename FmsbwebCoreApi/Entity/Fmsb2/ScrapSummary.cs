using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapSummary
    {
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string DeptRef { get; set; }
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [StringLength(50)]
        public string GrossScrapRef { get; set; }
        public int? Gross { get; set; }
        [Column(TypeName = "decimal(37, 19)")]
        public decimal? ScrapRate { get; set; }
    }
}
