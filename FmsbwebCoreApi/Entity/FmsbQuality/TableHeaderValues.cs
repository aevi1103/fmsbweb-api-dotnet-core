using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class TableHeaderValues
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("loginId")]
        public int LoginId { get; set; }
        [Column("line")]
        public int Line { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("subId")]
        public int SubId { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
    }
}
