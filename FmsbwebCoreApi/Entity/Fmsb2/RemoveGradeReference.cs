using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class RemoveGradeReference
    {
        [Key]
        [Column("partwithsuffix")]
        [StringLength(50)]
        public string Partwithsuffix { get; set; }
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
    }
}
