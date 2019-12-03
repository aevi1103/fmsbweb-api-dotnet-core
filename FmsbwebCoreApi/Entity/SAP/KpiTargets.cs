using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("KPI_Targets")]
    public partial class KpiTargets
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("deptId")]
        [StringLength(50)]
        public string DeptId { get; set; }
        [Required]
        [Column("kpi")]
        [StringLength(50)]
        public string Kpi { get; set; }
        [Column("min", TypeName = "decimal(18, 2)")]
        public decimal Min { get; set; }
        [Column("max", TypeName = "decimal(18, 2)")]
        public decimal Max { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
