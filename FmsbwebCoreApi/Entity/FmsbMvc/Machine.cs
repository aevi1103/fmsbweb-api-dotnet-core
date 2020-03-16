using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Machine", Schema = "Maintenance")]
    public partial class Machine
    {
        public Machine()
        {
            EstimatedPm = new HashSet<EstimatedPm>();
            Forklift = new HashSet<Forklift>();
            GageCall = new HashSet<GageCall>();
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            MaintenanceAlertLog = new HashSet<MaintenanceAlertLog>();
            OperatorDowntime = new HashSet<OperatorDowntime>();
            PreventiveMaintenance = new HashSet<PreventiveMaintenance>();
            ProcessTech = new HashSet<ProcessTech>();
            SubMachine = new HashSet<SubMachine>();
        }

        [Key]
        public int MachineId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(500)]
        public string MachineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Machine))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.Machine))]
        public virtual Departments Department { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<EstimatedPm> EstimatedPm { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<Forklift> Forklift { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<GageCall> GageCall { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<OperatorDowntime> OperatorDowntime { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<PreventiveMaintenance> PreventiveMaintenance { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
        [InverseProperty("Machine")]
        public virtual ICollection<SubMachine> SubMachine { get; set; }
    }
}
