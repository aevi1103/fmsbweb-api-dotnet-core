using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class DeptLineRefs
    {
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("line")]
        [StringLength(50)]
        public string Line { get; set; }
    }
}
