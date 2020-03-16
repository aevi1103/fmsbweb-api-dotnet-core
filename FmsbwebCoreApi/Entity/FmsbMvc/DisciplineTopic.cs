using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("DisciplineTopic", Schema = "Discipline")]
    public partial class DisciplineTopic
    {
        public DisciplineTopic()
        {
            Discipline = new HashSet<Discipline>();
        }

        [Key]
        public int DisciplineTopicId { get; set; }
        [Required]
        [StringLength(100)]
        public string Topic { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.DisciplineTopic))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("DisciplineTopic")]
        public virtual ICollection<Discipline> Discipline { get; set; }
    }
}
