using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("MaintenanceBreakDownReason", Schema = "Alert")]
    public partial class MaintenanceBreakDownReason
    {
        public MaintenanceBreakDownReason()
        {
            BreakdownReason2 = new HashSet<BreakdownReason2>();
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            MaintenanceAlertLog = new HashSet<MaintenanceAlertLog>();
            OperatorDowntime = new HashSet<OperatorDowntime>();
            ProcessTech = new HashSet<ProcessTech>();
        }

        [Key]
        public int MaintenanceBreakDownReasonId { get; set; }
        [Required]
        public string BreakDown { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public int? DepartmentId { get; set; }
        public bool IsActive { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.MaintenanceBreakDownReason))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.MaintenanceBreakDownReason))]
        public virtual Departments Department { get; set; }
        [InverseProperty("MaintenanceBreakDownReason")]
        public virtual ICollection<BreakdownReason2> BreakdownReason2 { get; set; }
        [InverseProperty("MaintenanceBreakDownReason")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("MaintenanceBreakDownReason")]
        public virtual ICollection<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        [InverseProperty("MaintenanceBreakDownReason")]
        public virtual ICollection<OperatorDowntime> OperatorDowntime { get; set; }
        [InverseProperty("MaintenanceBreakDownReason")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
    }
}
