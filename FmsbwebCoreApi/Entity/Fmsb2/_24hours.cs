using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("24Hours")]
    public partial class _24hours
    {
        [Column("shift")]
        public int? Shift { get; set; }
        [Column("hour")]
        public int? Hour { get; set; }
    }
}
