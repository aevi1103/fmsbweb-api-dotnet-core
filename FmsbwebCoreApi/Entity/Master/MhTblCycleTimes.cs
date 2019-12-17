using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MhTblCycleTimes
    {
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public int? CycleTime { get; set; }
    }
}
