using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCastingGroups")]
    public partial class TblCastingGroups
    {
        public TblCastingGroups()
        {
            TblDies = new HashSet<TblDies>();
        }

        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(6)]
        public string CastGroup { get; set; }

        [InverseProperty("Part")]
        public virtual ICollection<TblDies> TblDies { get; set; }
    }
}
