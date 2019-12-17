using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPartRouting")]
    public partial class TblPartRouting
    {
        [Key]
        [Column("PartID")]
        [StringLength(10)]
        public string PartId { get; set; }
        [Required]
        public bool? TinPlate { get; set; }
        [Required]
        public bool? Anodize { get; set; }
        [Required]
        public bool? Phosphate { get; set; }
        [Required]
        public bool? PadPrint { get; set; }
        [Required]
        public bool? SkirtCoat { get; set; }
        [Required]
        public bool? Assy1 { get; set; }
        [Required]
        public bool? Assy2 { get; set; }
        [Required]
        public bool? Assy3 { get; set; }
        [Required]
        public bool? Assy4 { get; set; }
        [Required]
        public bool? Assy5 { get; set; }
        [Required]
        public bool? Assy6 { get; set; }
        public long? BegInv { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? InvDate { get; set; }
    }
}
