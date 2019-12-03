using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class GetAfParts
    {
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
    }
}
