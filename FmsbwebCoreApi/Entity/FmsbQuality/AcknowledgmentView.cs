using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class AcknowledgmentView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("qaId")]
        public int QaId { get; set; }
        [Column("hourId")]
        public int? HourId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime? Shiftdate { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
        [Column("machineName")]
        [StringLength(97)]
        public string MachineName { get; set; }
        [StringLength(10)]
        public string CellSide { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
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
        [Column("qa_modifieddate", TypeName = "datetime")]
        public DateTime QaModifieddate { get; set; }
        [Column("userId")]
        [StringLength(50)]
        public string UserId { get; set; }
    }
}
