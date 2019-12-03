using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Defects
    {
        public Defects()
        {
            ProdScrap = new HashSet<ProdScrap>();
            ScrapView = new HashSet<ScrapView>();
        }

        [Key]
        [Column("defectId")]
        public int DefectId { get; set; }
        [Required]
        [Column("defectName")]
        [StringLength(500)]
        public string DefectName { get; set; }
        [Column("defectDescription")]
        public string DefectDescription { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }

        [ForeignKey(nameof(DefectAreaId))]
        [InverseProperty("Defects")]
        public virtual DefectArea DefectArea { get; set; }
        [InverseProperty("Defect")]
        public virtual ICollection<ProdScrap> ProdScrap { get; set; }
        [InverseProperty("Defect")]
        public virtual ICollection<ScrapView> ScrapView { get; set; }
    }
}
