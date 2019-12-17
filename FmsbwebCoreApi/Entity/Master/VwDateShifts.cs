using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class VwDateShifts
    {
        [Column("SDate", TypeName = "datetime")]
        public DateTime Sdate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
    }
}
