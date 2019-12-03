using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class Injuries
    {
        public Injuries()
        {
            Incidence = new HashSet<Incidence>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string InjuryName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("Injury")]
        public virtual ICollection<Incidence> Incidence { get; set; }
    }
}
