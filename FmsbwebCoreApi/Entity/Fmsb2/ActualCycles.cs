using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ActualCycles
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourid")]
        public int Hourid { get; set; }
        [Column("actualcycle", TypeName = "decimal(18, 5)")]
        public decimal? Actualcycle { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("hourNum")]
        public int? HourNum { get; set; }
    }
}
