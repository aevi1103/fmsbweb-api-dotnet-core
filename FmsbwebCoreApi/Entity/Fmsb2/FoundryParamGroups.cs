using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamGroups
    {
        public FoundryParamGroups()
        {
            FoundryParamCharacteristics = new HashSet<FoundryParamCharacteristics>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("groupName")]
        [StringLength(50)]
        public string GroupName { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("Group")]
        public virtual ICollection<FoundryParamCharacteristics> FoundryParamCharacteristics { get; set; }
    }
}
