using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapRatesParts
    {
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("pn")]
        public string Pn { get; set; }
        public int Gross { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("scrapRate", TypeName = "decimal(38, 20)")]
        public decimal? ScrapRate { get; set; }
    }
}
