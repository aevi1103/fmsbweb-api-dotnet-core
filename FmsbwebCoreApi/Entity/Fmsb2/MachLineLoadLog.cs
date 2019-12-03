using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachLineLoadLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("scrapId")]
        public int ScrapId { get; set; }
        [Required]
        [Column("bCode")]
        [StringLength(50)]
        public string BCode { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("clorindo")]
        public bool? Clorindo { get; set; }
        [Column("gsa")]
        public bool? Gsa { get; set; }
    }
}
