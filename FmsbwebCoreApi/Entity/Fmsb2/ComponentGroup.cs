using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentGroup
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("componentCategory")]
        [StringLength(50)]
        public string ComponentCategory { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
