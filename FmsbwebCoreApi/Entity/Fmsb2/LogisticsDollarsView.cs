using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class LogisticsDollarsView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("logisticsId")]
        public int LogisticsId { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Required]
        [Column("category")]
        [StringLength(200)]
        public string Category { get; set; }
        [Column("actual", TypeName = "decimal(18, 5)")]
        public decimal? Actual { get; set; }
        [Column("target", TypeName = "decimal(18, 5)")]
        public decimal? Target { get; set; }
        [Column("modifieDate", TypeName = "datetime")]
        public DateTime ModifieDate { get; set; }
    }
}
