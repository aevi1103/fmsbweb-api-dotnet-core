using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblyIssued")]
    public partial class TblRingAssemblyIssued
    {
        [Key]
        [Column("PartGroupID")]
        [StringLength(15)]
        public string PartGroupId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime AdjustDate { get; set; }
        public int? ExpAdjust { get; set; }
        public int? RailAdjust { get; set; }
        [Column("LCompAdjust")]
        public int? LcompAdjust { get; set; }
        [Column("UCompAdjust")]
        public int? UcompAdjust { get; set; }
        public int? PinAdjust { get; set; }
        [Column("CClipAdjust")]
        public int? CclipAdjust { get; set; }
        public int? RodAdjust { get; set; }

        [ForeignKey(nameof(PartGroupId))]
        [InverseProperty(nameof(TblRingAssemblyParts.TblRingAssemblyIssued))]
        public virtual TblRingAssemblyParts PartGroup { get; set; }
    }
}
