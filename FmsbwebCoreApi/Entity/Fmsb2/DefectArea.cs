using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class DefectArea
    {
        public DefectArea()
        {
            Defects = new HashSet<Defects>();
            ProdScrap = new HashSet<ProdScrap>();
            ScrapView = new HashSet<ScrapView>();
        }

        [Key]
        [Column("defectAreaId")]
        public int DefectAreaId { get; set; }
        [Required]
        [Column("defectArea")]
        [StringLength(50)]
        public string DefectArea1 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("DefectArea")]
        public virtual ICollection<Defects> Defects { get; set; }
        [InverseProperty("DefectArea")]
        public virtual ICollection<ProdScrap> ProdScrap { get; set; }
        [InverseProperty("DefectArea")]
        public virtual ICollection<ScrapView> ScrapView { get; set; }
    }
}
