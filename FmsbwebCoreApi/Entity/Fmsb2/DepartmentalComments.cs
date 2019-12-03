using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DepartmentalComments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("manager")]
        [StringLength(50)]
        public string Manager { get; set; }
        [Required]
        [Column("category")]
        [StringLength(50)]
        public string Category { get; set; }
        [Required]
        [Column("comments")]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
