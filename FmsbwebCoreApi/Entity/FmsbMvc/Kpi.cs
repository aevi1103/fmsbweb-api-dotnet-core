using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("KPI", Schema = "FmsbWeb")]
    public partial class Kpi
    {
        public Kpi()
        {
            KpiByProgram = new HashSet<KpiByProgram>();
            Kpitarget1 = new HashSet<Kpitarget1>();
        }

        [Key]
        [Column("KPIId")]
        public int Kpiid { get; set; }
        [Required]
        [Column("KPIName")]
        [StringLength(25)]
        public string Kpiname { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Kpi))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("Kpi")]
        public virtual ICollection<KpiByProgram> KpiByProgram { get; set; }
        [InverseProperty("Kpi")]
        public virtual ICollection<Kpitarget1> Kpitarget1 { get; set; }
    }
}
