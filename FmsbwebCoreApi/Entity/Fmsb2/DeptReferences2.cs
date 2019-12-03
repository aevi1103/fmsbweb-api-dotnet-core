using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DeptReferences2
    {
        [Key]
        [StringLength(50)]
        public string Dept { get; set; }
        [StringLength(50)]
        public string DeptLinkOldDb { get; set; }
    }
}
