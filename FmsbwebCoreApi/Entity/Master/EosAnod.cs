using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class EosAnod
    {
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("shiftHours")]
        public int? ShiftHours { get; set; }
        [Required]
        [StringLength(2)]
        public string Line { get; set; }
        [Column(TypeName = "numeric(3, 1)")]
        public decimal CycleTime { get; set; }
        [Required]
        [Column("part")]
        [StringLength(6)]
        public string Part { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [Column("runtime")]
        public int Runtime { get; set; }
        [Column(TypeName = "numeric(20, 6)")]
        public decimal? Target { get; set; }
        public int? Gross { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("ms")]
        public int? Ms { get; set; }
        [Column("anod")]
        public int? Anod { get; set; }
        [Column("sc")]
        public int Sc { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [Required]
        [Column("oaeCom")]
        [StringLength(500)]
        public string OaeCom { get; set; }
        [Required]
        [StringLength(500)]
        public string ScrapCom { get; set; }
        [Required]
        [StringLength(500)]
        public string OtherCom { get; set; }
    }
}
