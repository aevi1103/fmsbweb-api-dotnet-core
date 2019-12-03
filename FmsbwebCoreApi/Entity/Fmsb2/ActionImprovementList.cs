using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ActionImprovementList
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("actionImprovements")]
        [StringLength(500)]
        public string ActionImprovements { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
