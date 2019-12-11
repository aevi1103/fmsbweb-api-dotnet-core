using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Intranet
{
    public partial class FmsbMasterProdPartsCopyDashboard
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [StringLength(50)]
        public string Line { get; set; }
        [StringLength(100)]
        public string Part { get; set; }
        public int FoundryGross { get; set; }
        [Column("Machining_Gross")]
        public int MachiningGross { get; set; }
        [Column("Anod_Gross")]
        public int AnodGross { get; set; }
        [Column("SC_Gross")]
        public int ScGross { get; set; }
        [Column("Assy_Gross")]
        public int AssyGross { get; set; }
        [Column("warmers")]
        public int Warmers { get; set; }
        [Column("fs")]
        public int Fs { get; set; }
        [Column("ms")]
        public int Ms { get; set; }
        [Column("anod")]
        public int Anod { get; set; }
        [Column("sc")]
        public int Sc { get; set; }
        [Column("assy")]
        public int Assy { get; set; }
        [Column("net")]
        public int Net { get; set; }
        [StringLength(50)]
        public string Area { get; set; }
        public int? WkNum { get; set; }
        [Required]
        [StringLength(22)]
        public string Department { get; set; }
        [Column(TypeName = "decimal(38, 2)")]
        public decimal OeeTarget { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal OaeTarget { get; set; }
    }
}
