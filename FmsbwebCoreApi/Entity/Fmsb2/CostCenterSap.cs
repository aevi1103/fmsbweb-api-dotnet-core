using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("CostCenter_SAP")]
    public partial class CostCenterSap
    {
        [Key]
        public int CostCenter { get; set; }
        [StringLength(50)]
        public string Dept { get; set; }
    }
}
