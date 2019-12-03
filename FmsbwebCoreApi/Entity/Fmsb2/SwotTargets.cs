using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("SWOT_Targets")]
    public partial class SwotTargets
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Column("oaeTarget", TypeName = "decimal(18, 5)")]
        public decimal OaeTarget { get; set; }
        [Column("targetPartsPerHour")]
        public int TargetPartsPerHour { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [Column("foundryScrapTarget", TypeName = "decimal(18, 5)")]
        public decimal FoundryScrapTarget { get; set; }
        [Column("machineScrapTarget", TypeName = "decimal(18, 5)")]
        public decimal MachineScrapTarget { get; set; }
        [Column("afScrapTarget", TypeName = "decimal(18, 5)")]
        public decimal AfScrapTarget { get; set; }
        [Column("isPriority")]
        public bool? IsPriority { get; set; }
        [Column("component_count")]
        public int? ComponentCount { get; set; }
    }
}
