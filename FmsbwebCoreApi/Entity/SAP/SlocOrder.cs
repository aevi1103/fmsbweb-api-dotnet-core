using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("SLOC_Order")]
    public partial class SlocOrder
    {
        [Key]
        [Column("SLOC")]
        [StringLength(50)]
        public string Sloc { get; set; }
        public int Sort { get; set; }
        [Column("SLOCName")]
        [StringLength(50)]
        public string Slocname { get; set; }
    }
}
