using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("ScrapRatesbyDefect_Foundry_copy")]
    public partial class ScrapRatesbyDefectFoundryCopy
    {
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("defectName")]
        [StringLength(50)]
        public string DefectName { get; set; }
        public int? Gross { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("scrapRate", TypeName = "decimal(18, 5)")]
        public decimal? ScrapRate { get; set; }
    }
}
