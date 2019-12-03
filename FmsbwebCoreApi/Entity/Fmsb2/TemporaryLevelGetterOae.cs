using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class TemporaryLevelGetterOae
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("prodId")]
        public int? ProdId { get; set; }
        [Column("alarmLevel")]
        public int? AlarmLevel { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
    }
}
