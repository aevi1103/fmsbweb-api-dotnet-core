using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfmanningSummary
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("hours")]
        public int Hours { get; set; }
        public int TotalFinishing { get; set; }
        public int TotalAssy { get; set; }
        public int? FinishingManHrs { get; set; }
        public int? AssemblyManHours { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal SkirtCoatTarget { get; set; }
        public int SkirtCoatGross { get; set; }
        public int SkirtCoatNet { get; set; }
        [Column(TypeName = "decimal(38, 5)")]
        public decimal AssemblyTarget { get; set; }
        public int AssemblyGross { get; set; }
        public int AssemblyNet { get; set; }
    }
}
