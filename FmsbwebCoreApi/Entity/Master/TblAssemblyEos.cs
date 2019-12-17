using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblAssembly_EOS")]
    public partial class TblAssemblyEos
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string ShiftHours { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? CycleTime { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        public int? Runtime { get; set; }
        [Column(TypeName = "decimal(18, 5)")]
        public decimal? Target { get; set; }
        [Column("Assy_Gross")]
        public int? AssyGross { get; set; }
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
        [Column("OAECom")]
        public string Oaecom { get; set; }
        public string ScrapCom { get; set; }
        public string OtherCom { get; set; }
        [Column("Anod_Gross")]
        public int? AnodGross { get; set; }
        [Column("SC_Gross")]
        public int? ScGross { get; set; }
    }
}
