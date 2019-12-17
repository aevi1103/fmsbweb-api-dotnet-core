using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblyParts")]
    public partial class TblRingAssemblyParts
    {
        public TblRingAssemblyParts()
        {
            TblRingAssemblies = new HashSet<TblRingAssemblies>();
            TblRingAssemblyCount = new HashSet<TblRingAssemblyCount>();
            TblRingAssemblyIssued = new HashSet<TblRingAssemblyIssued>();
        }

        [Key]
        [Column("PartGroupID")]
        [StringLength(15)]
        public string PartGroupId { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [Column("PNExp")]
        [StringLength(15)]
        public string Pnexp { get; set; }
        [StringLength(50)]
        public string ExpDesc { get; set; }
        [Column("PNRail")]
        [StringLength(15)]
        public string Pnrail { get; set; }
        [StringLength(50)]
        public string RailDesc { get; set; }
        [Column("PNLC")]
        [StringLength(15)]
        public string Pnlc { get; set; }
        [Column("LCompDesc")]
        [StringLength(50)]
        public string LcompDesc { get; set; }
        [Column("PNUC")]
        [StringLength(15)]
        public string Pnuc { get; set; }
        [Column("UCompDesc")]
        [StringLength(50)]
        public string UcompDesc { get; set; }
        [Column("PNPin")]
        [StringLength(15)]
        public string Pnpin { get; set; }
        [StringLength(50)]
        public string PinDesc { get; set; }
        [Column("PNCC")]
        [StringLength(15)]
        public string Pncc { get; set; }
        [Column("CClipDesc")]
        [StringLength(50)]
        public string CclipDesc { get; set; }
        [Column("PNRod")]
        [StringLength(15)]
        public string Pnrod { get; set; }
        [StringLength(50)]
        public string RodDesc { get; set; }

        [InverseProperty("PartGroup")]
        public virtual ICollection<TblRingAssemblies> TblRingAssemblies { get; set; }
        [InverseProperty("PartGroup")]
        public virtual ICollection<TblRingAssemblyCount> TblRingAssemblyCount { get; set; }
        [InverseProperty("PartGroup")]
        public virtual ICollection<TblRingAssemblyIssued> TblRingAssemblyIssued { get; set; }
    }
}
