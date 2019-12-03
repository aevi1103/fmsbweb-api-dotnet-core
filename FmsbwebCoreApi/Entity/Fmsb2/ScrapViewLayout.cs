using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ScrapViewLayout
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("viewName")]
        [StringLength(100)]
        public string ViewName { get; set; }
        [Required]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [StringLength(50)]
        public string Machine { get; set; }
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        [Required]
        [StringLength(500)]
        public string Defect { get; set; }
        [Required]
        [Column("areaDefect")]
        [StringLength(553)]
        public string AreaDefect { get; set; }
        [Column("defectId")]
        public int DefectId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("htmlInputId")]
        [StringLength(8000)]
        public string HtmlInputId { get; set; }
    }
}
