using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("logistics_mm")]
    public partial class LogisticsMm
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
