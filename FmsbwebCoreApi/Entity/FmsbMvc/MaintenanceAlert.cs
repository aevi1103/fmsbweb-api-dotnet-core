using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("MaintenanceAlert", Schema = "Alert")]
    public partial class MaintenanceAlert
    {
        [Key]
        public int MaintenanceAlertId { get; set; }
        public int MachineId { get; set; }
        public int SubMachineId { get; set; }
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
        public bool IsFollowUp { get; set; }
        public string StartedFrom { get; set; }
        public string EndedFrom { get; set; }
        public int? BreakdownReason2Id { get; set; }
        public int? HourId { get; set; }
        [Column("HxHId")]
        public int? HxHid { get; set; }
        public int? OperatorDowntimeId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.MaintenanceAlert))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(BreakdownReason2Id))]
        [InverseProperty("MaintenanceAlert")]
        public virtual BreakdownReason2 BreakdownReason2 { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("MaintenanceAlert")]
        public virtual Machine Machine { get; set; }
        [ForeignKey(nameof(MaintenanceBreakDownReasonId))]
        [InverseProperty("MaintenanceAlert")]
        public virtual MaintenanceBreakDownReason MaintenanceBreakDownReason { get; set; }
        [ForeignKey(nameof(OperatorDowntimeId))]
        [InverseProperty("MaintenanceAlert")]
        public virtual OperatorDowntime OperatorDowntime { get; set; }
        [ForeignKey(nameof(SubMachineId))]
        [InverseProperty("MaintenanceAlert")]
        public virtual SubMachine SubMachine { get; set; }
    }
}
