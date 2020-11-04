using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.AutoGage
{
    public partial class AutoGage2View
    {
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(8000)]
        public string Part2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [StringLength(5)]
        public string Shift { get; set; }
        public int Line { get; set; }
        [Required]
        [StringLength(50)]
        public string Machine { get; set; }
        [Required]
        [StringLength(50)]
        public string Grade { get; set; }
        [Required]
        [StringLength(500)]
        public string MeasurementResult { get; set; }
        public bool IsPassed { get; set; }
        public int RegageStatus { get; set; }
        [StringLength(100)]
        public string DefectOnly { get; set; }
        [StringLength(500)]
        public string DefectFound { get; set; }
        [StringLength(2000)]
        public string DefectFoundLowSpec { get; set; }
        [StringLength(2000)]
        public string DefectFoundHighSpec { get; set; }
        public int? NumOfDefects { get; set; }
        public int? NumOfHighDefects { get; set; }
        public int? NumOfLowDefects { get; set; }
        [Column("stamp", TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(500)]
        public string FileName { get; set; }
    }
}
