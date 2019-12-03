using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentTraceability
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("pistonPartOverride")]
        [StringLength(50)]
        public string PistonPartOverride { get; set; }
        [Required]
        [Column("componentPart")]
        [StringLength(50)]
        public string ComponentPart { get; set; }
        [Required]
        [Column("lotNumber")]
        [StringLength(50)]
        public string LotNumber { get; set; }
        [Column("modifiedate", TypeName = "datetime")]
        public DateTime Modifiedate { get; set; }
        [Column("julianDateCode")]
        [StringLength(100)]
        public string JulianDateCode { get; set; }
    }
}
