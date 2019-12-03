using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourlyProduction
    {
        public int ProdId { get; set; }
        [Column("hxhId")]
        public int HxhId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column("cycle", TypeName = "decimal(18, 2)")]
        public decimal Cycle { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(10)]
        public string CellSideFoundry { get; set; }
        [Column("cavities_foundry")]
        public int? CavitiesFoundry { get; set; }
        [Column("PPH_Target", TypeName = "decimal(18, 5)")]
        public decimal? PphTarget { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("cellSWarmers")]
        public int? CellSwarmers { get; set; }
        [Column("cellMachineScrap")]
        public int? CellMachineScrap { get; set; }
        [Column("cellVisualScrap")]
        public int? CellVisualScrap { get; set; }
        [Column("cellScrap")]
        public int? CellScrap { get; set; }
        [Column("foundryScrap")]
        public int? FoundryScrap { get; set; }
        [Column("machScrap")]
        public int? MachScrap { get; set; }
        [Column("anodScrap")]
        public int? AnodScrap { get; set; }
        [Column("scScrap")]
        public int? ScScrap { get; set; }
        [Column("eooScrap")]
        public int? EooScrap { get; set; }
        [Column("assyScrap")]
        public int? AssyScrap { get; set; }
        [Column("warmersTotal")]
        public int WarmersTotal { get; set; }
        [Column("scrapTotal")]
        public int ScrapTotal { get; set; }
        public int? Net { get; set; }
        [Column("oae", TypeName = "decimal(38, 20)")]
        public decimal? Oae { get; set; }
        [StringLength(7)]
        public string Status { get; set; }
        [Column("downtimeloss_InputDt", TypeName = "decimal(38, 2)")]
        public decimal DowntimelossInputDt { get; set; }
        [Column("downtimeLoss_Auto_min", TypeName = "decimal(18, 0)")]
        public decimal? DowntimeLossAutoMin { get; set; }
        [Column("lossPecentfromAutoDt", TypeName = "decimal(38, 20)")]
        public decimal? LossPecentfromAutoDt { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? RemainingDt { get; set; }
        [Column("actualCycleFoundry", TypeName = "decimal(18, 5)")]
        public decimal ActualCycleFoundry { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
    }
}
