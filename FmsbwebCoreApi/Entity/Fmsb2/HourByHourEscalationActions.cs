using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourByHourEscalationActions
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("action")]
        public string Action { get; set; }
        [Column("owner")]
        public string Owner { get; set; }
        [Column("duedate", TypeName = "datetime")]
        public DateTime? Duedate { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
    }
}
