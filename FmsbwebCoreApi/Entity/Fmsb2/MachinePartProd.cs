using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachinePartProd
    {
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
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("oaeTarget")]
        public int? OaeTarget { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
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
        [Column("scrapTotal")]
        public int? ScrapTotal { get; set; }
        public int? Net { get; set; }
        [Column("downtimeLoss_Auto_min", TypeName = "decimal(38, 1)")]
        public decimal? DowntimeLossAutoMin { get; set; }
        [Column("downtimeloss_InputDt", TypeName = "decimal(38, 2)")]
        public decimal? DowntimelossInputDt { get; set; }
        [Column("oaep", TypeName = "decimal(37, 19)")]
        public decimal? Oaep { get; set; }
        [Column("cellp", TypeName = "decimal(37, 19)")]
        public decimal? Cellp { get; set; }
        [Column("fsp", TypeName = "decimal(37, 19)")]
        public decimal? Fsp { get; set; }
        [Column("msp", TypeName = "decimal(37, 19)")]
        public decimal? Msp { get; set; }
        [Column("anodp", TypeName = "decimal(37, 19)")]
        public decimal? Anodp { get; set; }
        [Column("sc_eoo_p", TypeName = "decimal(38, 19)")]
        public decimal? ScEooP { get; set; }
        [Column("assyp", TypeName = "decimal(37, 19)")]
        public decimal? Assyp { get; set; }
    }
}
