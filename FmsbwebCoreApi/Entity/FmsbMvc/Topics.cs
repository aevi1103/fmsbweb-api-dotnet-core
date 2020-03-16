using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class Topics
    {
        public Topics()
        {
            Assignments = new HashSet<Assignments>();
        }

        [Key]
        public int TopicsId { get; set; }
        [Required]
        [StringLength(100)]
        public string TopicName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Topics))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("Topics")]
        public virtual ICollection<Assignments> Assignments { get; set; }
    }
}
