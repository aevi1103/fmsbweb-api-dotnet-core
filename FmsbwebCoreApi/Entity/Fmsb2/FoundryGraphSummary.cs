using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryGraphSummary
    {
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("avgCavity")]
        public int? AvgCavity { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column("target", TypeName = "decimal(38, 5)")]
        public decimal? Target { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("warmer")]
        public int? Warmer { get; set; }
        [Column("visualScrap")]
        public int? VisualScrap { get; set; }
        [Column("alfinRingMachineScrap")]
        public int? AlfinRingMachineScrap { get; set; }
        [Column("totalScrap")]
        public int? TotalScrap { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Column("cycle", TypeName = "decimal(18, 2)")]
        public decimal Cycle { get; set; }
        [Column("toolingLoss_min", TypeName = "decimal(38, 2)")]
        public decimal ToolingLossMin { get; set; }
        [Column("otherLoss_min", TypeName = "decimal(38, 2)")]
        public decimal OtherLossMin { get; set; }
        [Column("toolingLoss_parts", TypeName = "decimal(38, 6)")]
        public decimal? ToolingLossParts { get; set; }
        [Column("otherLoss_parts", TypeName = "decimal(38, 6)")]
        public decimal? OtherLossParts { get; set; }
    }
}
