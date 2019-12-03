using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Safety
{
    [Table("Months_Reference")]
    public partial class MonthsReference
    {
        [Required]
        [Column("mos")]
        [StringLength(50)]
        public string Mos { get; set; }
        [Column("mos_num")]
        public int MosNum { get; set; }
    }
}
