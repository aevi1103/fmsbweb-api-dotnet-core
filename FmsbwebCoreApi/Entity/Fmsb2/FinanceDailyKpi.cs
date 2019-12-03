using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_DailyKPI")]
    public partial class FinanceDailyKpi
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Column("mtd_cost", TypeName = "decimal(18, 2)")]
        public decimal MtdCost { get; set; }
        [Column("daily_avg_cost", TypeName = "decimal(18, 2)")]
        public decimal DailyAvgCost { get; set; }
        [Column("unitsProduced")]
        public int UnitsProduced { get; set; }
        [Column("actual_cost_absorption", TypeName = "decimal(18, 2)")]
        public decimal ActualCostAbsorption { get; set; }
        [Column("target_cost_absorption", TypeName = "decimal(18, 2)")]
        public decimal TargetCostAbsorption { get; set; }
        [Column("reach_percent_absorption", TypeName = "decimal(18, 5)")]
        public decimal ReachPercentAbsorption { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime? Stamp { get; set; }
        [Column("comment")]
        [StringLength(500)]
        public string Comment { get; set; }
    }
}
