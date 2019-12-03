using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class DmaxParts
    {
        [Key]
        [Column("material_dmax")]
        [StringLength(50)]
        public string MaterialDmax { get; set; }
    }
}
