using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapHxh
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hxhid")]
        public int Hxhid { get; set; }
        [Column("defectid")]
        public int Defectid { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("hourNum")]
        public int HourNum { get; set; }

        [ForeignKey(nameof(Hxhid))]
        [InverseProperty(nameof(CreateHxH.ScrapHxh))]
        public virtual CreateHxH Hxh { get; set; }
    }
}
