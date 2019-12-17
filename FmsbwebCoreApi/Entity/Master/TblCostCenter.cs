using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCostCenter")]
    public partial class TblCostCenter
    {
        [Key]
        public int CostCenter { get; set; }
        [StringLength(50)]
        public string Desc { get; set; }
    }
}
