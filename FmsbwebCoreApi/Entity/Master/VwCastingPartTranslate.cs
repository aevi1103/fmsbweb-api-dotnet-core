using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class VwCastingPartTranslate
    {
        [Required]
        [Column("MachPartID")]
        [StringLength(6)]
        public string MachPartId { get; set; }
        [Column("CastingPartID")]
        [StringLength(6)]
        public string CastingPartId { get; set; }
    }
}
