using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtPartFmly")]
    public partial class TblxtPartFmly
    {
        [Key]
        [StringLength(15)]
        public string PartFamily { get; set; }
        [StringLength(10)]
        public string Customer { get; set; }
        [Required]
        [StringLength(5)]
        public string AlloyCode { get; set; }
        public int CycleTime { get; set; }
        public float PartWt { get; set; }
        [Required]
        public bool? IsDead { get; set; }
        [Required]
        public bool? MisMatchCheck { get; set; }
        [Required]
        public bool? PipCheck { get; set; }
        public int PartPerBasket { get; set; }
        public int? MachineCycleTime { get; set; }
        [Column("IntranetPartID")]
        public int? IntranetPartId { get; set; }
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
