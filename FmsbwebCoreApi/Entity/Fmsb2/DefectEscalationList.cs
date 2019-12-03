using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DefectEscalationList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("deptId")]
        public int DeptId { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Required]
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Column("triggerQty")]
        public int TriggerQty { get; set; }
        [Column("escalationMsgId")]
        [StringLength(500)]
        public string EscalationMsgId { get; set; }
        [Required]
        [Column("htmlEscalationMsg")]
        public string HtmlEscalationMsg { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
