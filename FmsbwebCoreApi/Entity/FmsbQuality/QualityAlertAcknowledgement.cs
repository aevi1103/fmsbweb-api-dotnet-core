using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class QualityAlertAcknowledgement
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("qaId")]
        public int QaId { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("clockNumber")]
        public int ClockNumber { get; set; }
        [Column("name")]
        [StringLength(500)]
        public string Name { get; set; }
        [Column("feedback")]
        [StringLength(500)]
        public string Feedback { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Column("scrapId")]
        public int? ScrapId { get; set; }
        [Column("userId")]
        [StringLength(50)]
        public string UserId { get; set; }
        [Column("workcenter")]
        [StringLength(50)]
        public string Workcenter { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime? ShiftDate { get; set; }
        [Column("shift")]
        [StringLength(5)]
        public string Shift { get; set; }
    }
}
