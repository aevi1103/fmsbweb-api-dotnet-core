using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDies")]
    public partial class TblDies
    {
        [Key]
        [StringLength(4)]
        public string DieNr { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Required]
        public bool? OddEven { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DieDate { get; set; }
        [StringLength(50)]
        public string DieComment { get; set; }
        public int? CastHist { get; set; }

        [ForeignKey(nameof(PartId))]
        [InverseProperty(nameof(TblCastingGroups.TblDies))]
        public virtual TblCastingGroups Part { get; set; }
    }
}
