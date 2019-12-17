using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FoundryEoodefectHistory
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectAreaName { get; set; }
        [Required]
        public string DefectName { get; set; }
        [Column("ScrapQTy")]
        public int? ScrapQty { get; set; }
        [Column("TotalGross_Shift")]
        public int? TotalGrossShift { get; set; }
        [Column("countG")]
        public int? CountG { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? GrossD { get; set; }
    }
}
