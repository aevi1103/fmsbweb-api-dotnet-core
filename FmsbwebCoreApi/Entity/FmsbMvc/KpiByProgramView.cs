using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class KpiByProgramView
    {
        public int KpiByProgramId { get; set; }
        public int AreaId { get; set; }
        [Required]
        [StringLength(25)]
        public string AreaName { get; set; }
        [Column("KPIId")]
        public int Kpiid { get; set; }
        [Required]
        [Column("KPIName")]
        [StringLength(25)]
        public string Kpiname { get; set; }
        public int ProgramId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProgramName { get; set; }
        public int MonthNumber { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal Target { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
    }
}
