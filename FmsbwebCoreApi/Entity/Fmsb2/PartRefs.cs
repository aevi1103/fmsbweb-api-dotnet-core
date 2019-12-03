using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class PartRefs
    {
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("correctPart")]
        [StringLength(50)]
        public string CorrectPart { get; set; }
    }
}
