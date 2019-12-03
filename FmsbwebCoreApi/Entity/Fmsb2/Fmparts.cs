using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Fmparts
    {
        [Column("FMPart")]
        [StringLength(8)]
        public string Fmpart { get; set; }
        [Column("pn_nograde")]
        [StringLength(8)]
        public string PnNograde { get; set; }
        [Required]
        [StringLength(9)]
        public string Category { get; set; }
        [Column("SAPPart")]
        [StringLength(30)]
        public string Sappart { get; set; }
    }
}
