using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProductionUnion
    {
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column("cellSide_foundry")]
        [StringLength(10)]
        public string CellSideFoundry { get; set; }
        [Column("cavities_foundry")]
        public int? CavitiesFoundry { get; set; }
        [Column("oaeTarget", TypeName = "decimal(38, 5)")]
        public decimal? OaeTarget { get; set; }
        public int? Gross { get; set; }
        public int? CellScrap { get; set; }
        public int? Warmers { get; set; }
        [Column("fs_hxh_scrap")]
        public int? FsHxhScrap { get; set; }
        [Column("ms_hxh_scrap")]
        public int? MsHxhScrap { get; set; }
        [Column("anod_hxh_scrap")]
        public int? AnodHxhScrap { get; set; }
        [Column("sc_hxh_scrap")]
        public int? ScHxhScrap { get; set; }
        [Column("assy_hxh_scrap")]
        public int? AssyHxhScrap { get; set; }
        public int? Net { get; set; }
        public int? CellNum { get; set; }
    }
}
