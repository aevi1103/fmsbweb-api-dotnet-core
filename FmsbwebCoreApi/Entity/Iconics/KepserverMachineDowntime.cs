using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Iconics
{
    [Table("KEPServer_MachineDowntime")]
    public partial class KepserverMachineDowntime
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("tagName")]
        [StringLength(50)]
        public string TagName { get; set; }
        [Column("isInitialSave")]
        public bool? IsInitialSave { get; set; }
        [Column("start_stamp", TypeName = "datetime")]
        public DateTime? StartStamp { get; set; }
        [Column("end_stamp", TypeName = "datetime")]
        public DateTime? EndStamp { get; set; }
        [Column("downtime_minutes", TypeName = "decimal(18, 2)")]
        public decimal? DowntimeMinutes { get; set; }
        [Column("time_stamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [Required]
        [Column("currentVal")]
        [StringLength(10)]
        public string CurrentVal { get; set; }
        [Column("original_start_stamp", TypeName = "datetime")]
        public DateTime? OriginalStartStamp { get; set; }
        [Column("original_end_stamp", TypeName = "datetime")]
        public DateTime? OriginalEndStamp { get; set; }
    }
}
