using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logistics_customer")]
    public partial class LogisticsCustomer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("customer")]
        [StringLength(50)]
        public string Customer { get; set; }
        [Column("comment")]
        public string Comment { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("logisticsId")]
        public int LogisticsId { get; set; }
    }
}
