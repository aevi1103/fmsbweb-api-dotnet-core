using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FoundryDefectRates2
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Required]
        [StringLength(10)]
        public string Department { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        public string DefectName { get; set; }
        [Column("Scrap_Qty")]
        public int? ScrapQty { get; set; }
        public int? Gross { get; set; }
        [Column("count_Def")]
        public int? CountDef { get; set; }
        [Column("Gross_D", TypeName = "decimal(29, 16)")]
        public decimal? GrossD { get; set; }
        [Column(TypeName = "decimal(29, 11)")]
        public decimal? Rates { get; set; }
    }
}
