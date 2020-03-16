using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("PreventiveMaintenance", Schema = "Maintenance")]
    public partial class PreventiveMaintenance
    {
        public PreventiveMaintenance()
        {
            SubMachinePm = new HashSet<SubMachinePm>();
        }

        [Key]
        public int PreventiveMaintenanceId { get; set; }
        public int MachineId { get; set; }
        [Column("LastCompletedPM", TypeName = "datetime")]
        public DateTime LastCompletedPm { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.PreventiveMaintenance))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("PreventiveMaintenance")]
        public virtual Machine Machine { get; set; }
        [InverseProperty("PreventiveMaintenance")]
        public virtual ICollection<SubMachinePm> SubMachinePm { get; set; }
    }
}
