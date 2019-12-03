using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logistics_part_inv")]
    public partial class LogisticsPartInv
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("partId")]
        public int PartId { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column("daysOnHand", TypeName = "decimal(18, 5)")]
        public decimal? DaysOnHand { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("logisticsId")]
        public int LogisticsId { get; set; }
    }
}
