using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineLookupView
    {
        [Required]
        [Column("mainMachine")]
        [StringLength(50)]
        public string MainMachine { get; set; }
        [Required]
        [Column("refMachine")]
        [StringLength(50)]
        public string RefMachine { get; set; }
    }
}
