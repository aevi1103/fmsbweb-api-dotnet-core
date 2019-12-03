using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class SapCompPartsBom
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("sap_part")]
        [StringLength(50)]
        public string SapPart { get; set; }
        [Required]
        [Column("fm_part")]
        [StringLength(50)]
        public string FmPart { get; set; }
        [Required]
        [Column("sad_desc")]
        [StringLength(100)]
        public string SadDesc { get; set; }
        [Column("p1a")]
        [StringLength(500)]
        public string P1a { get; set; }
    }
}
