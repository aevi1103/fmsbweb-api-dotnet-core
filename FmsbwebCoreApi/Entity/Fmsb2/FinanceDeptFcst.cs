using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("Finance_DeptFcst")]
    public partial class FinanceDeptFcst
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("year")]
        public int Year { get; set; }
        [Column("monthNum")]
        public int MonthNum { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Column("totalUnitFcst")]
        public int TotalUnitFcst { get; set; }
        [Column("oaeFcst", TypeName = "decimal(18, 2)")]
        public decimal OaeFcst { get; set; }
        [Column("datetime", TypeName = "datetime")]
        public DateTime Datetime { get; set; }
    }
}
