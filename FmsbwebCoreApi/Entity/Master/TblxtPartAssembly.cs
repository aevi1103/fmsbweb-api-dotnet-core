using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtPartAssembly")]
    public partial class TblxtPartAssembly
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Required]
        public bool? Anodize { get; set; }
        [Required]
        public bool? Assembly1 { get; set; }
        [Required]
        public bool? Assembly2 { get; set; }
        [Required]
        public bool? Assembly3 { get; set; }
        [Required]
        public bool? Assembly4 { get; set; }
        [Required]
        public bool? Assembly5 { get; set; }
        [Required]
        public bool? PostAssy { get; set; }
        [Required]
        public bool? SkirtCoat { get; set; }
        [Required]
        public bool? TinPlate { get; set; }
        [Required]
        public bool? ManualPackout { get; set; }
        public bool? Assembly6 { get; set; }
        public bool? Assembly7 { get; set; }
        public bool? Assembly8 { get; set; }
    }
}
