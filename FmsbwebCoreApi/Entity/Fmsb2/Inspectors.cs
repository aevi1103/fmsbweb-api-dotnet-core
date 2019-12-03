using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Inspectors
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("clock")]
        public int Clock { get; set; }
        [Column("prodid")]
        public int Prodid { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
