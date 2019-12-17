using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblies")]
    public partial class TblRingAssemblies
    {
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Key]
        [Column("PartGroupID")]
        [StringLength(15)]
        public string PartGroupId { get; set; }

        [ForeignKey(nameof(PartGroupId))]
        [InverseProperty(nameof(TblRingAssemblyParts.TblRingAssemblies))]
        public virtual TblRingAssemblyParts PartGroup { get; set; }
    }
}
