using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class MaintenanceAlertLog1
    {
        public int MaintenanceAlertLogId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        public int Status { get; set; }
        [Required]
        [StringLength(6)]
        public string StatusText { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public int MaintenanceAlertId { get; set; }
        public int MachineId { get; set; }
        [Required]
        [StringLength(500)]
        public string MachineName { get; set; }
        public int SubMachineId { get; set; }
        [Required]
        [StringLength(500)]
        public string SubMachineName { get; set; }
        public int MaintenanceBreakDownReasonId { get; set; }
        [Required]
        public string BreakDown { get; set; }
        public string BreakdownComments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public bool IsWorking { get; set; }
        public bool IsComplete { get; set; }
        public bool IsFollowUp { get; set; }
        public string MaintenanceTechClockNumbers { get; set; }
        public string ResponseComment { get; set; }
        public string InitialUserId { get; set; }
        public string SupervisorId { get; set; }
        [StringLength(50)]
        public string ClockNumberStr { get; set; }
        public string StartedFrom { get; set; }
        public string EndedFrom { get; set; }
        public string DeleteComment { get; set; }
    }
}
