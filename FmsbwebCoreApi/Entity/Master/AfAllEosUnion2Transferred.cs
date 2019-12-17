using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("af_all_EOS_union2_transferred")]
    public partial class AfAllEosUnion2Transferred
    {
        [StringLength(10)]
        public string Dept { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? CycleTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("shiftHours")]
        public int? ShiftHours { get; set; }
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("runtime")]
        public int? Runtime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Target { get; set; }
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc")]
        public int? Sc { get; set; }
        [Column("assy")]
        public int? Assy { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Column("FS_p", TypeName = "decimal(18, 5)")]
        public decimal? FsP { get; set; }
        [Column("MS_p", TypeName = "decimal(18, 5)")]
        public decimal? MsP { get; set; }
        [Column("Anod_p", TypeName = "decimal(18, 5)")]
        public decimal? AnodP { get; set; }
        [Column("SC_p", TypeName = "decimal(18, 5)")]
        public decimal? ScP { get; set; }
        [Column("Assy_p", TypeName = "decimal(18, 5)")]
        public decimal? AssyP { get; set; }
        [Column("oaeCom")]
        public string OaeCom { get; set; }
        public string ScrapCom { get; set; }
        public string OtherCom { get; set; }
        [Column("wk")]
        public int? Wk { get; set; }
        [Column("anod_gross")]
        public int? AnodGross { get; set; }
        [Column("sc_gross")]
        public int? ScGross { get; set; }
        [Column("assy_gross")]
        public int? AssyGross { get; set; }
    }
}
