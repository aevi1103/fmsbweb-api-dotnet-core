using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logistics_inventory")]
    public partial class LogisticsInventory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("logisticsId")]
        public int LogisticsId { get; set; }
        [Required]
        [Column("category")]
        [StringLength(200)]
        public string Category { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("avg_days", TypeName = "decimal(18, 5)")]
        public decimal AvgDays { get; set; }
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
