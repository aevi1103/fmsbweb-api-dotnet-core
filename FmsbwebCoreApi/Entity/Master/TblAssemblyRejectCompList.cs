using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssemblyRejectCompList")]
    public partial class TblAssemblyRejectCompList
    {
        [Key]
        [StringLength(100)]
        public string RejectComp { get; set; }
    }
}
