using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtPart")]
    public partial class TblxtPart
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Required]
        [StringLength(25)]
        public string PartDescription { get; set; }
        [StringLength(15)]
        public string PartFamily { get; set; }
        [StringLength(1)]
        public string PartCode { get; set; }
        [StringLength(5)]
        public string AlloyCode { get; set; }
        [Required]
        [Column("MCOnly")]
        public bool? Mconly { get; set; }
        [Required]
        [Column("TPOnly")]
        public bool? Tponly { get; set; }
        [Required]
        public bool? Dead { get; set; }
        public int? CycleTime { get; set; }
        [StringLength(25)]
        public string Customer { get; set; }
        [StringLength(50)]
        public string FirstFinProc { get; set; }
        public float? PartWt { get; set; }
        public bool? MisMatchCheck { get; set; }
        public bool? PipCheck { get; set; }
        public int? PartPerBasket { get; set; }
        [StringLength(2)]
        public string SecondFinProc { get; set; }
        [StringLength(2)]
        public string ThirdFinProc { get; set; }
        [Column("CastingPartID")]
        [StringLength(6)]
        public string CastingPartId { get; set; }
        [Column("IntranetPartID")]
        public int? IntranetPartId { get; set; }
        [StringLength(20)]
        public string FoundryNumber { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateCreated { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastUpdated { get; set; }
        [StringLength(50)]
        public string LastUpdatedBy { get; set; }
    }
}
