using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("SubMachine", Schema = "Maintenance")]
    public partial class SubMachine
    {
        public SubMachine()
        {
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            MaintenanceAlertLog = new HashSet<MaintenanceAlertLog>();
            OperatorDowntime = new HashSet<OperatorDowntime>();
            ProcessTech = new HashSet<ProcessTech>();
            SubMachinePm = new HashSet<SubMachinePm>();
        }

        [Key]
        public int SubMachineId { get; set; }
        public int MachineId { get; set; }
        [Required]
        [StringLength(500)]
        public string SubMachineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public bool IsObsolete { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.SubMachine))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("SubMachine")]
        public virtual Machine Machine { get; set; }
        [InverseProperty("SubMachine")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("SubMachine")]
        public virtual ICollection<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        [InverseProperty("SubMachine")]
        public virtual ICollection<OperatorDowntime> OperatorDowntime { get; set; }
        [InverseProperty("SubMachine")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
        [InverseProperty("SubMachine")]
        public virtual ICollection<SubMachinePm> SubMachinePm { get; set; }
    }
}
