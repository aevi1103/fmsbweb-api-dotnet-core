using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class SkirtCoatScreenView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("hourNum")]
        public int HourNum { get; set; }
        [Required]
        [Column("screenPartNum")]
        [StringLength(500)]
        public string ScreenPartNum { get; set; }
        [Required]
        [Column("meshNumber")]
        [StringLength(500)]
        public string MeshNumber { get; set; }
        [Required]
        [Column("meshColor")]
        [StringLength(500)]
        public string MeshColor { get; set; }
        [Required]
        [Column("revDate")]
        [StringLength(500)]
        public string RevDate { get; set; }
        [Required]
        [Column("julianDate")]
        [StringLength(500)]
        public string JulianDate { get; set; }
        [Column("startCount")]
        public int? StartCount { get; set; }
        [Column("endCount")]
        public int? EndCount { get; set; }
        [Column("dateTimeScanned", TypeName = "datetime")]
        public DateTime DateTimeScanned { get; set; }
        [Column("removalReason")]
        public string RemovalReason { get; set; }
        [Column("scrapReason")]
        public string ScrapReason { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
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
        public string ClockNums { get; set; }
    }
}
