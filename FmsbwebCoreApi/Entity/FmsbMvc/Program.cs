using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Program", Schema = "FmsbWeb")]
    public partial class Program
    {
        public Program()
        {
            KpiByProgram1 = new HashSet<KpiByProgram1>();
        }

        [Key]
        public int ProgramId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProgramName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Program))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("Program")]
        public virtual ICollection<KpiByProgram1> KpiByProgram1 { get; set; }
    }
}
