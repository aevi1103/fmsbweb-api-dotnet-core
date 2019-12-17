using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ComponentViewScrap
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }
        [Column("GRD")]
        [StringLength(1)]
        public string Grd { get; set; }
        [Required]
        [Column("PN")]
        [StringLength(101)]
        public string Pn { get; set; }
        [Required]
        [StringLength(50)]
        public string ComponentCode { get; set; }
        public int Multiplier { get; set; }
        public int? AutoQty { get; set; }
    }
}
