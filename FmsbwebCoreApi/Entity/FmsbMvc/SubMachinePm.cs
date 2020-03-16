using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("SubMachinePM", Schema = "Maintenance")]
    public partial class SubMachinePm
    {
        [Key]
        [Column("SubMachinePMId")]
        public int SubMachinePmid { get; set; }
        public int SubMachineId { get; set; }
        public int PreventiveMaintenanceId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCompleted { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.SubMachinePm))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(PreventiveMaintenanceId))]
        [InverseProperty("SubMachinePm")]
        public virtual PreventiveMaintenance PreventiveMaintenance { get; set; }
        [ForeignKey(nameof(SubMachineId))]
        [InverseProperty("SubMachinePm")]
        public virtual SubMachine SubMachine { get; set; }
    }
}
