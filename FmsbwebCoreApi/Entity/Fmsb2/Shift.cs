using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Shift
    {
        public Shift()
        {
            Prod = new HashSet<Prod>();
            ProdScrap = new HashSet<ProdScrap>();
        }

        [Key]
        [Column("Shift")]
        [StringLength(50)]
        public string Shift1 { get; set; }

        [InverseProperty("ShiftNavigation")]
        public virtual ICollection<Prod> Prod { get; set; }
        [InverseProperty("ShiftNavigation")]
        public virtual ICollection<ProdScrap> ProdScrap { get; set; }
    }
}
