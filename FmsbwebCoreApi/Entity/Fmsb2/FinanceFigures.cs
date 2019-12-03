using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_Figures")]
    public partial class FinanceFigures
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("sales_1000", TypeName = "decimal(18, 2)")]
        public decimal Sales1000 { get; set; }
        [Column("ebitda_1000", TypeName = "decimal(18, 2)")]
        public decimal Ebitda1000 { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [Column("monthNum")]
        public int MonthNum { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
    }
}
