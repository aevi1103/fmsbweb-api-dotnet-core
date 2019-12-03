using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("ScrapRatesParts_Foundry_copy")]
    public partial class ScrapRatesPartsFoundryCopy
    {
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("shiftdate")]
        [StringLength(50)]
        public string Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        public int? Gross { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("scrapRate", TypeName = "decimal(18, 5)")]
        public decimal? ScrapRate { get; set; }
    }
}
