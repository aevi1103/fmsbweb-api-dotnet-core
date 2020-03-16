using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Forklift", Schema = "Alert")]
    public partial class Forklift
    {
        [Key]
        public int ForkliftId { get; set; }
        public int MachineId { get; set; }
        public int ForkliftTaskId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public bool IsWorking { get; set; }
        public bool IsComplete { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Forklift))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(ForkliftTaskId))]
        [InverseProperty("Forklift")]
        public virtual ForkliftTask ForkliftTask { get; set; }
        [ForeignKey(nameof(MachineId))]
        [InverseProperty("Forklift")]
        public virtual Machine Machine { get; set; }
    }
}
