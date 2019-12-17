using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("GP12_ScrapData")]
    public partial class Gp12ScrapData
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        [Required]
        [StringLength(50)]
        public string Defect { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
    }
}
