using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AnodizeDefectHistory
    {
        [Column("AnodizeID")]
        public int AnodizeId { get; set; }
        [Required]
        [StringLength(14)]
        public string Defect { get; set; }
        public int? Qty { get; set; }
    }
}
