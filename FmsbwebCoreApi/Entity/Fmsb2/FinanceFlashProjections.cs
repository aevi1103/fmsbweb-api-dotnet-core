using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_FlashProjections")]
    public partial class FinanceFlashProjections
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("monthNum")]
        public int MonthNum { get; set; }
        [Column("sales_1000", TypeName = "decimal(18, 2)")]
        public decimal Sales1000 { get; set; }
        [Column("ebitda_1000", TypeName = "decimal(18, 2)")]
        public decimal Ebitda1000 { get; set; }
        [Column("capitalFcst", TypeName = "decimal(18, 2)")]
        public decimal CapitalFcst { get; set; }
        [Column("pistonScrapFcst_cost", TypeName = "decimal(18, 2)")]
        public decimal PistonScrapFcstCost { get; set; }
        [Column("mroFcst_cost", TypeName = "decimal(18, 2)")]
        public decimal MroFcstCost { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
