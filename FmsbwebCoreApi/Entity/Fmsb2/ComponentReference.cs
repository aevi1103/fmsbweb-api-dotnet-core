using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentReference
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("defectid")]
        public int Defectid { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Required]
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Column("multiplier")]
        public int Multiplier { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
