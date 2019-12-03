using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DefectEscalation
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Column("triggerQty")]
        public int TriggerQty { get; set; }
        [Column("escalationMsgId")]
        [StringLength(500)]
        public string EscalationMsgId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
    }
}
