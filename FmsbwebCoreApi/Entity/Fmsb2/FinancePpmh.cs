using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_PPMH")]
    public partial class FinancePpmh
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [Column("month")]
        [StringLength(50)]
        public string Month { get; set; }
        [Column("target", TypeName = "decimal(18, 2)")]
        public decimal Target { get; set; }
        [Column("actual", TypeName = "decimal(18, 2)")]
        public decimal Actual { get; set; }
        [Column("DLE", TypeName = "decimal(18, 2)")]
        public decimal Dle { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
