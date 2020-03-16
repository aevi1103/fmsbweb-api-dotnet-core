using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class MaintenanceCallView
    {
        public int MaintenanceAlertId { get; set; }
        public int MachineId { get; set; }
        public int SubMachineId { get; set; }
        [Required]
        [StringLength(500)]
        public string MachineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public bool IsWorking { get; set; }
        public bool IsComplete { get; set; }
        public string ResponseComment { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public int MaintenanceBreakDownReasonId { get; set; }
        public string BreakdownComments { get; set; }
        public string MaintenanceTechClockNumbers { get; set; }
        public string SupervisorId { get; set; }
        [StringLength(50)]
        public string ClockNumberStr { get; set; }
    }
}
