using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewFoundryscrapAF
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("anodGrs")]
        public int? AnodGrs { get; set; }
        [Column("scGrs")]
        public int? ScGrs { get; set; }
        [Column("assyGrs")]
        public int? AssyGrs { get; set; }
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
        [Column("totalGrs")]
        public int? TotalGrs { get; set; }
        [Column("net")]
        public int? Net { get; set; }
        [StringLength(10)]
        public string Dept { get; set; }
    }
}
