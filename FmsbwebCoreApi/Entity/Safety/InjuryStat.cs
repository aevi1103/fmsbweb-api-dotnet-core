using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    public partial class InjuryStat
    {
        [Key]
        [Column("InjuryStat")]
        [StringLength(50)]
        public string InjuryStat1 { get; set; }
        [Column("color")]
        [StringLength(10)]
        public string Color { get; set; }
    }
}
