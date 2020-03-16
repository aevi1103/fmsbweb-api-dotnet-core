using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("CastingCell", Schema = "DieStatus")]
    public partial class CastingCell
    {
        public CastingCell()
        {
            DieTracker = new HashSet<DieTracker>();
        }

        [Key]
        public int CastingCellName { get; set; }
        public bool IsDualCavity { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.CastingCell))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("CastingCellNameNavigation")]
        public virtual ICollection<DieTracker> DieTracker { get; set; }
    }
}
