using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class SapCostCenter
    {
        [Key]
        [StringLength(50)]
        public string Dept { get; set; }
        public int? CostCenter { get; set; }
    }
}
