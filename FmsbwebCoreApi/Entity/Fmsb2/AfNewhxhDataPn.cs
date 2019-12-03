using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class AfNewhxhDataPn
    {
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [StringLength(50)]
        public string Part { get; set; }
        [Column("foundryGross")]
        public int? FoundryGross { get; set; }
        public int? MachGross { get; set; }
        [Column("anodGross")]
        public int? AnodGross { get; set; }
        [Column("scGross")]
        public int? ScGross { get; set; }
        [Column("assyGross")]
        public int? AssyGross { get; set; }
        [Column("warmers")]
        public int? Warmers { get; set; }
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
        public int? Net { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        public int? WkNum { get; set; }
        [Required]
        [StringLength(22)]
        public string Department { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal? OeeTarget { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal? OaeTarget { get; set; }
    }
}
