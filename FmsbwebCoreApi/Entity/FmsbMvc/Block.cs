using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Block", Schema = "DieStatus")]
    public partial class Block
    {
        public Block()
        {
            Die = new HashSet<Die>();
        }

        [Key]
        public int BlockId { get; set; }
        public int BlockName { get; set; }
        [StringLength(128)]
        public string PartNumberId { get; set; }
        public string Comments { get; set; }
        public string Warning { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Block))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(PartNumberId))]
        [InverseProperty("Block")]
        public virtual PartNumber PartNumber { get; set; }
        [InverseProperty("Block")]
        public virtual ICollection<Die> Die { get; set; }
    }
}
