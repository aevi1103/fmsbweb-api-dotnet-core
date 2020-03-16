using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("MaintenanceTech", Schema = "Maintenance")]
    public partial class MaintenanceTech
    {
        [Key]
        public int ClockNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ShiftNameId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.MaintenanceTech))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.MaintenanceTech))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
