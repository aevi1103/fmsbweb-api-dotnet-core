using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class InvProgramTargets
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("program")]
        [StringLength(50)]
        public string Program { get; set; }
        [Required]
        [Column("SLOC")]
        [StringLength(50)]
        public string Sloc { get; set; }
        [Column("min")]
        public int Min { get; set; }
        [Column("max")]
        public int Max { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
    }
}
