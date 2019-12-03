using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ProductionSummaryv2
    {
        [Column("hrId")]
        public int HrId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [StringLength(10)]
        public string CellSide { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("netHxh")]
        public int? NetHxh { get; set; }
        [StringLength(30)]
        public string WkNum { get; set; }
        [Column("warmers_hxh")]
        public int WarmersHxh { get; set; }
        [Column("cell_hxh")]
        public int CellHxh { get; set; }
        [Column("fs_hxh")]
        public int FsHxh { get; set; }
        [Column("ms_hxh")]
        public int MsHxh { get; set; }
        [Column("anod_hxh")]
        public int AnodHxh { get; set; }
        [Column("sc_hxh")]
        public int ScHxh { get; set; }
        [Column("assy_hxh")]
        public int AssyHxh { get; set; }
        [Column("warmers_scrapP")]
        public int WarmersScrapP { get; set; }
        [Column("cell_scrapP")]
        public int CellScrapP { get; set; }
        [Column("fs_scrapP")]
        public int FsScrapP { get; set; }
        [Column("ms_scrapP")]
        public int MsScrapP { get; set; }
        [Column("anod_scrapP")]
        public int AnodScrapP { get; set; }
        [Column("sc_scrapP")]
        public int ScScrapP { get; set; }
        [Column("assy_scrapP")]
        public int AssyScrapP { get; set; }
        public int TotalAssyLoad { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal? TargetP { get; set; }
    }
}
