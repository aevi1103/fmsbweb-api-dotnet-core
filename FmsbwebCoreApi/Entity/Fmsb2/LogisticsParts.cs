using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logisticsParts")]
    public partial class LogisticsParts
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("program")]
        [StringLength(50)]
        public string Program { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("sort")]
        public int? Sort { get; set; }
    }
}
