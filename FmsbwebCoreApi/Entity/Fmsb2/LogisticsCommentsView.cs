using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class LogisticsCommentsView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
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
