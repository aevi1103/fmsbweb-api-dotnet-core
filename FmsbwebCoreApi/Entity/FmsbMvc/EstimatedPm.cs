using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("EstimatedPM", Schema = "Maintenance")]
    public partial class EstimatedPm
    {
        [Key]
        [Column("EstimatedPMId")]
        public int EstimatedPmid { get; set; }
        public int MachineId { get; set; }
        [Column("DaysBeforePM")]
        public int DaysBeforePm { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        [Column("MinDaysBeforePM")]
        public int MinDaysBeforePm { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.EstimatedPm))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("EstimatedPm")]
        public virtual Machine Machine { get; set; }
    }
}
