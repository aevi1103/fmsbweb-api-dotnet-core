using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfAllEosUnion
    {
        [Column(TypeName = "datetime")]
        public DateTime? CoatDate { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("shiftHours")]
        public int? ShiftHours { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column(TypeName = "numeric(38, 5)")]
        public decimal? CycleTime { get; set; }
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("runtime")]
        public int? Runtime { get; set; }
        [Column(TypeName = "numeric(38, 20)")]
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
        [Column("oaeCom")]
        public string OaeCom { get; set; }
        public string ScrapCom { get; set; }
        public string OtherCom { get; set; }
    }
}
