using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("af_OAE_OEE_EOS_transfered")]
    public partial class AfOaeOeeEosTransfered
    {
        [StringLength(10)]
        public string Dept { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column("OAETarget", TypeName = "decimal(38, 17)")]
        public decimal? Oaetarget { get; set; }
        [Column("OEETarget", TypeName = "decimal(38, 5)")]
        public decimal? Oeetarget { get; set; }
        public int? Gross { get; set; }
        [Column("FS")]
        public int? Fs { get; set; }
        [Column("MS")]
        public int? Ms { get; set; }
        public int? Anod { get; set; }
        [Column("SC")]
        public int? Sc { get; set; }
        public int? Assy { get; set; }
        public int? TotalScrap { get; set; }
        public int? Net { get; set; }
    }
}
