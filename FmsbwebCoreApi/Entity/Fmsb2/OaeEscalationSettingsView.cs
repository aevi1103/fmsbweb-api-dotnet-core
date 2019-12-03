using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class OaeEscalationSettingsView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Column("redStatusCount")]
        public int RedStatusCount { get; set; }
        [Column("yellowStatusCount")]
        public int YellowStatusCount { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
