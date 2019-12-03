using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourbyHourListRefs
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("cycle", TypeName = "decimal(18, 2)")]
        public decimal Cycle { get; set; }
        [Column("PPH_Target", TypeName = "decimal(18, 0)")]
        public decimal? PphTarget { get; set; }
        [Column("PPH_Target_decimal", TypeName = "decimal(18, 5)")]
        public decimal? PphTargetDecimal { get; set; }
        public int? Net { get; set; }
        [Column("oae", TypeName = "decimal(38, 20)")]
        public decimal? Oae { get; set; }
        [Required]
        [Column("bootstrapClass")]
        [StringLength(7)]
        public string BootstrapClass { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(50)]
        public string CellSideFoundry { get; set; }
        [Column("cavities_foundry")]
        public int? CavitiesFoundry { get; set; }
        public int HourId { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("downtimeloss", TypeName = "decimal(38, 2)")]
        public decimal Downtimeloss { get; set; }
        [Column("scrapTotal")]
        public int ScrapTotal { get; set; }
        [Column("warmersTotal")]
        public int WarmersTotal { get; set; }
        [Column("actualcycle", TypeName = "decimal(18, 5)")]
        public decimal? Actualcycle { get; set; }
    }
}
