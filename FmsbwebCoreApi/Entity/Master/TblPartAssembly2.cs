using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartAssembly2")]
    public partial class TblPartAssembly2
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        public bool Assembly1 { get; set; }
        public bool Assembly2 { get; set; }
        public bool Assembly3 { get; set; }
        public bool Assembly4 { get; set; }
        public bool PostAssy { get; set; }
        public bool SkirtCoat { get; set; }
        public bool TinPlate { get; set; }
        public bool Anodize { get; set; }
    }
}
