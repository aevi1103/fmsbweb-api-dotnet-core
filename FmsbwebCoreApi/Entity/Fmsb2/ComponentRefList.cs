using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentRefList
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("multiplier")]
        public int Multiplier { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
