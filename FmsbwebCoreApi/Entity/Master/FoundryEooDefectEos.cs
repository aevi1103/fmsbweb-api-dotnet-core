using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FoundryEooDefectEos
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectAreaName { get; set; }
        [Required]
        public string DefectName { get; set; }
        [Column("ScrapQTy")]
        public int? ScrapQty { get; set; }
        [Column("TotalGross_Shift")]
        public int? TotalGrossShift { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? ScrapRate { get; set; }
    }
}
