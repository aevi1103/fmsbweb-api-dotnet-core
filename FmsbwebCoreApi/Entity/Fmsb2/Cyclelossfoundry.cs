using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Cyclelossfoundry
    {
        public int HourId { get; set; }
        [Column("downtimeId")]
        public int? DowntimeId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column("machineGroup")]
        public int? MachineGroup { get; set; }
        [Column("machineNumber")]
        public int MachineNumber { get; set; }
        [Required]
        [Column("reason1")]
        [StringLength(10)]
        public string Reason1 { get; set; }
        [Required]
        [Column("reason2")]
        [StringLength(10)]
        public string Reason2 { get; set; }
        public int? Comments { get; set; }
        [Column("targetCycle", TypeName = "decimal(18, 2)")]
        public decimal TargetCycle { get; set; }
        [Column("actualCycleFoundry", TypeName = "decimal(18, 5)")]
        public decimal ActualCycleFoundry { get; set; }
        [Column("modifieddate")]
        public int? Modifieddate { get; set; }
        [Column("cavities_foundry")]
        public int? CavitiesFoundry { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(10)]
        public string CellSideFoundry { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Column("PPH_Target", TypeName = "decimal(18, 5)")]
        public decimal? PphTarget { get; set; }
        [Column("downtimeloss_InputDt", TypeName = "decimal(38, 2)")]
        public decimal DowntimelossInputDt { get; set; }
        [Column("needtargetfromactualcycle")]
        public int? Needtargetfromactualcycle { get; set; }
    }
}
