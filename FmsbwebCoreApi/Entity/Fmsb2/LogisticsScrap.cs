using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logistics_scrap")]
    public partial class LogisticsScrap
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("inventoryScrapQty")]
        public int? InventoryScrapQty { get; set; }
        [Column("inventoryScrapCost", TypeName = "decimal(18, 5)")]
        public decimal? InventoryScrapCost { get; set; }
        [Column("processScrapQty")]
        public int? ProcessScrapQty { get; set; }
        [Column("processScrapCost", TypeName = "decimal(18, 5)")]
        public decimal? ProcessScrapCost { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("costCenter")]
        public int? CostCenter { get; set; }
        [Column("logisticsId")]
        public int LogisticsId { get; set; }
    }
}
