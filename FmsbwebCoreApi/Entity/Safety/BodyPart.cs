using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class BodyPart
    {
        public BodyPart()
        {
            Incidence = new HashSet<Incidence>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [Column("BodyPart")]
        [StringLength(50)]
        public string BodyPart1 { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }

        [InverseProperty("BodyPart")]
        public virtual ICollection<Incidence> Incidence { get; set; }
    }
}
