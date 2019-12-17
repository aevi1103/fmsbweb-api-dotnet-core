using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblyCount")]
    public partial class TblRingAssemblyCount
    {
        [Key]
        [Column("PartGroupID")]
        [StringLength(15)]
        public string PartGroupId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime CountDate { get; set; }
        public int? ExpCount { get; set; }
        public int? RailCount { get; set; }
        [Column("LCompCount")]
        public int? LcompCount { get; set; }
        [Column("UCompCount")]
        public int? UcompCount { get; set; }
        public int? PinCount { get; set; }
        [Column("CClipCount")]
        public int? CclipCount { get; set; }
        public int? RodCount { get; set; }

        [ForeignKey(nameof(PartGroupId))]
        [InverseProperty(nameof(TblRingAssemblyParts.TblRingAssemblyCount))]
        public virtual TblRingAssemblyParts PartGroup { get; set; }
    }
}
