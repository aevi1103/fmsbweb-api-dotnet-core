using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("SWOT_Profile")]
    public partial class SwotProfile
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [Column("profile")]
        [StringLength(50)]
        public string Profile { get; set; }
        [Required]
        [Column("lines")]
        [StringLength(500)]
        public string Lines { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
