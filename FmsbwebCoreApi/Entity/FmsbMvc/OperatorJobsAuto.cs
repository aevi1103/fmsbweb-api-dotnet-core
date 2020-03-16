using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class OperatorJobsAuto
    {
        public int Id { get; set; }
        public string TagId { get; set; }
        public int HourId { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        public string MachineIconics { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(10)]
        public string CellSide { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Required]
        [Column("machine_hxh")]
        [StringLength(50)]
        public string MachineHxh { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        [Required]
        [StringLength(500)]
        public string MachineName { get; set; }
        [StringLength(500)]
        public string SubMachineName { get; set; }
        [Column("primaryReason")]
        public string PrimaryReason { get; set; }
        [Column("secondaryReason")]
        public string SecondaryReason { get; set; }
        public string DowntimeComment { get; set; }
        public string StatusText { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
    }
}
