using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("MachineGaugeLog_Deleted")]
    public partial class MachineGaugeLogDeleted
    {
        [Column("line")]
        public int Line { get; set; }
        [Required]
        [Column("part")]
        [StringLength(500)]
        public string Part { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("time")]
        public TimeSpan Time { get; set; }
        [Required]
        [Column("initials")]
        [StringLength(50)]
        public string Initials { get; set; }
        [Required]
        [Column("gageStation")]
        [StringLength(50)]
        public string GageStation { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }
        [Column("tieIn")]
        public bool TieIn { get; set; }
        [Column("containment")]
        public bool Containment { get; set; }
        [Required]
        [Column("fix")]
        public string Fix { get; set; }
        [Column("timestamp", TypeName = "datetime")]
        public DateTime Timestamp { get; set; }
        [Required]
        [Column("gageType")]
        [StringLength(50)]
        public string GageType { get; set; }
        [Column("line_weekly_maint")]
        [StringLength(50)]
        public string LineWeeklyMaint { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("delete_datetime", TypeName = "datetime")]
        public DateTime? DeleteDatetime { get; set; }
        [Column("id")]
        public int? Id { get; set; }
        [Key]
        [Column("id_pk")]
        public int IdPk { get; set; }
        [Column("problem")]
        public string Problem { get; set; }
        [Column("fix_reason")]
        public string FixReason { get; set; }
        [Column("other_comments")]
        public string OtherComments { get; set; }
    }
}
