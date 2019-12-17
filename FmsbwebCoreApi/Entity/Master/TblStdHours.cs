using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblStdHours")]
    public partial class TblStdHours
    {
        [Required]
        [StringLength(10)]
        public string Process { get; set; }
        public float StdHours { get; set; }
    }
}
