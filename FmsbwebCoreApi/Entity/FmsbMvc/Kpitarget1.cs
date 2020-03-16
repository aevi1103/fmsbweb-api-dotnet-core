using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("KPITarget", Schema = "FmsbWeb")]
    public partial class Kpitarget1
    {
        [Key]
        [Column("KPITargetId")]
        public int KpitargetId { get; set; }
        public int AreaId { get; set; }
        [Column("KPIId")]
        public int Kpiid { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal Min { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal Max { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Kpitarget1))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(AreaId))]
        [InverseProperty("Kpitarget1")]
        public virtual Area Area { get; set; }
        [ForeignKey(nameof(Kpiid))]
        [InverseProperty("Kpitarget1")]
        public virtual Kpi Kpi { get; set; }
    }
}
