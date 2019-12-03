using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("componentTypes")]
    public partial class ComponentTypes
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("componentGroupId")]
        public int ComponentGroupId { get; set; }
        [Required]
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
