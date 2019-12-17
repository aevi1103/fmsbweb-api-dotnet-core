using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("GP12_PartsInsected")]
    public partial class Gp12PartsInsected
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        public int PartsInspected { get; set; }
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
