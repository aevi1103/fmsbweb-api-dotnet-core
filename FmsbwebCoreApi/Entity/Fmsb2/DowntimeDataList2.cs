using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DowntimeDataList2
    {
        public int HourId { get; set; }
        [Column("downtimeId")]
        public int DowntimeId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(10)]
        public string CellSideFoundry { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("machineGroup")]
        [StringLength(500)]
        public string MachineGroup { get; set; }
        [Column("machineNumber")]
        [StringLength(50)]
        public string MachineNumber { get; set; }
        [Column("reason1")]
        public string Reason1 { get; set; }
        [Required]
        [Column("reason2")]
        [StringLength(500)]
        public string Reason2 { get; set; }
        public string Comments { get; set; }
        [Column("downtimeloss", TypeName = "decimal(18, 2)")]
        public decimal? Downtimeloss { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("machineGroupId")]
        public int? MachineGroupId { get; set; }
        [Column("machineNumberId")]
        public int? MachineNumberId { get; set; }
        [Column("reason1Id")]
        public int? Reason1Id { get; set; }
        [Column("reason2Id")]
        public int? Reason2Id { get; set; }
        public Guid Id { get; set; }
        public int? DeptId { get; set; }
    }
}
