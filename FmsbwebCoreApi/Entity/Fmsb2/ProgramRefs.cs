using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProgramRefs
    {
        [Key]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("program")]
        [StringLength(100)]
        public string Program { get; set; }
    }
}
