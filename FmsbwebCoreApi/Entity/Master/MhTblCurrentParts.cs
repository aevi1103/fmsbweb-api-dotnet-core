using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class MhTblCurrentParts
    {
        public int? Addr { get; set; }
        [StringLength(50)]
        public string PartNo { get; set; }
    }
}
