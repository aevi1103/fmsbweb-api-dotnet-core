using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("OperatorDowntime", Schema = "Iconics")]
    public partial class OperatorDowntime
    {
        public OperatorDowntime()
        {
            GageCall = new HashSet<GageCall>();
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            ProcessTech = new HashSet<ProcessTech>();
        }

        [Key]
        public int OperatorDowntimeId { get; set; }
        public string TagId { get; set; }
        public string MachineName { get; set; }
        public int HourId { get; set; }
        public int DowntimeAutoId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime StartTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndTime { get; set; }
        public int? MachineId { get; set; }
        public int? SubMachineId { get; set; }
        public int? MaintenanceBreakDownReasonId { get; set; }
        public int? BreakdownReason2Id { get; set; }
        public string DowntimeComment { get; set; }
        public string StatusText { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        public bool? IsManualTrigger { get; set; }

        [ForeignKey(nameof(BreakdownReason2Id))]
        [InverseProperty("OperatorDowntime")]
        public virtual BreakdownReason2 BreakdownReason2 { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("OperatorDowntime")]
        public virtual Machine Machine { get; set; }
        [ForeignKey(nameof(MaintenanceBreakDownReasonId))]
        [InverseProperty("OperatorDowntime")]
        public virtual MaintenanceBreakDownReason MaintenanceBreakDownReason { get; set; }
        [ForeignKey(nameof(SubMachineId))]
        [InverseProperty("OperatorDowntime")]
        public virtual SubMachine SubMachine { get; set; }
        [InverseProperty("OperatorDowntime")]
        public virtual ICollection<GageCall> GageCall { get; set; }
        [InverseProperty("OperatorDowntime")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("OperatorDowntime")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
    }
}
