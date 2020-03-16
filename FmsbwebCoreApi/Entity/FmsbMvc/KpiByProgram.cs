using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("KpiByProgram", Schema = "FmsbWeb")]
    public partial class KpiByProgram
    {
        [Key]
        public int KpiByProgramId { get; set; }
        public int AreaId { get; set; }
        [Column("KPIId")]
        public int Kpiid { get; set; }
        public int ProgramId { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal Target { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public int MonthNumber { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.KpiByProgram))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(AreaId))]
        [InverseProperty("KpiByProgram")]
        public virtual Area Area { get; set; }
        [ForeignKey(nameof(Kpiid))]
        [InverseProperty("KpiByProgram")]
        public virtual Kpi Kpi { get; set; }
        [ForeignKey(nameof(ProgramId))]
        [InverseProperty("KpiByProgram")]
        public virtual Program Program { get; set; }
    }
}
