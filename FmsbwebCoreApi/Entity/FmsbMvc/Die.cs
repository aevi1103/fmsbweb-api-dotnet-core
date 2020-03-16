using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Die", Schema = "DieStatus")]
    public partial class Die
    {
        public Die()
        {
            DieTracker = new HashSet<DieTracker>();
        }

        [Key]
        public int DieId { get; set; }
        public string DieName { get; set; }
        public int BlockId { get; set; }
        public int DieCoatingLife { get; set; }
        public string Warning { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public string DieComment { get; set; }
        public string BlockComment { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Die))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(BlockId))]
        [InverseProperty("Die")]
        public virtual Block Block { get; set; }
        [InverseProperty("Die")]
        public virtual ICollection<DieTracker> DieTracker { get; set; }
    }
}
