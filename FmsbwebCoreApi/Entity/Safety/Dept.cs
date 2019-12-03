using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class Dept
    {
        public Dept()
        {
            Incidence = new HashSet<Incidence>();
        }

        [Key]
        [Column("Dept")]
        [StringLength(50)]
        public string Dept1 { get; set; }

        [InverseProperty("DeptNavigation")]
        public virtual ICollection<Incidence> Incidence { get; set; }
    }
}
