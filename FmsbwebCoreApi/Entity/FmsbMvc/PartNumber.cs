using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("PartNumber", Schema = "DieStatus")]
    public partial class PartNumber
    {
        public PartNumber()
        {
            Block = new HashSet<Block>();
            DieTracker = new HashSet<DieTracker>();
        }

        [Key]
        [StringLength(128)]
        public string PartNumberId { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.PartNumber))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("PartNumber")]
        public virtual ICollection<Block> Block { get; set; }
        [InverseProperty("PartNumber")]
        public virtual ICollection<DieTracker> DieTracker { get; set; }
    }
}
