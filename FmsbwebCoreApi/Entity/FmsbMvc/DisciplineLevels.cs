using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("DisciplineLevels", Schema = "Discipline")]
    public partial class DisciplineLevels
    {
        public DisciplineLevels()
        {
            Discipline = new HashSet<Discipline>();
        }

        [Key]
        public int DisciplineLevelsId { get; set; }
        [Required]
        [StringLength(100)]
        public string Levels { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.DisciplineLevels))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("DisciplineLevels")]
        public virtual ICollection<Discipline> Discipline { get; set; }
    }
}
