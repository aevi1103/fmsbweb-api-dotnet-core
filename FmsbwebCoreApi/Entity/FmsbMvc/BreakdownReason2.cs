using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("BreakdownReason2", Schema = "Alert")]
    public partial class BreakdownReason2
    {
        public BreakdownReason2()
        {
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            MaintenanceAlertLog = new HashSet<MaintenanceAlertLog>();
            OperatorDowntime = new HashSet<OperatorDowntime>();
            ProcessTech = new HashSet<ProcessTech>();
        }

        [Key]
        public int BreakdownReason2Id { get; set; }
        [Required]
        public string BreakDown { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        public int MaintenanceBreakDownReasonId { get; set; }
        public bool IsActive { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.BreakdownReason2))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(MaintenanceBreakDownReasonId))]
        [InverseProperty("BreakdownReason2")]
        public virtual MaintenanceBreakDownReason MaintenanceBreakDownReason { get; set; }
        [InverseProperty("BreakdownReason2")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("BreakdownReason2")]
        public virtual ICollection<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        [InverseProperty("BreakdownReason2")]
        public virtual ICollection<OperatorDowntime> OperatorDowntime { get; set; }
        [InverseProperty("BreakdownReason2")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
    }
}
