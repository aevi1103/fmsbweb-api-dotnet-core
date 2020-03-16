using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("Area", Schema = "FmsbWeb")]
    public partial class Area
    {
        public Area()
        {
            KpiByProgram1 = new HashSet<KpiByProgram1>();
            Kpitarget1 = new HashSet<Kpitarget1>();
        }

        [Key]
        public int AreaId { get; set; }
        [Required]
        [StringLength(25)]
        public string AreaName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Area))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("Area")]
        public virtual ICollection<KpiByProgram1> KpiByProgram1 { get; set; }
        [InverseProperty("Area")]
        public virtual ICollection<Kpitarget1> Kpitarget1 { get; set; }
    }
}
