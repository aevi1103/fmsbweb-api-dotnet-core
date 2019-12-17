using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class SapAfScrapUpload
    {
        [StringLength(10)]
        public string Dept { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
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
    }
}
