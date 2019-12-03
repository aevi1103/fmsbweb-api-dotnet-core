using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HxhOpsClockNum
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("clock")]
        public int Clock { get; set; }
        [Column("hxhid")]
        public int Hxhid { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [ForeignKey(nameof(Hxhid))]
        [InverseProperty(nameof(CreateHxH.HxhOpsClockNum))]
        public virtual CreateHxH Hxh { get; set; }
    }
}
