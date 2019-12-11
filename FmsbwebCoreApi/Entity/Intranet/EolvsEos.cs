using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Intranet
{
    [Table("EOLVS_EOS", Schema = "dbo")]
    public partial class EolvsEos
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("supervisor")]
        [StringLength(50)]
        public string Supervisor { get; set; }
        [Column("line")]
        public int Line { get; set; }
        [Column("gross")]
        public int Gross { get; set; }
        [Column("ms")]
        public int Ms { get; set; }
        [Column("fs")]
        public int? Fs { get; set; }
        [Column("machDef_25")]
        [StringLength(50)]
        public string MachDef25 { get; set; }
        [Column("quality_com")]
        public string QualityCom { get; set; }
        [Column("downtime_com")]
        public string DowntimeCom { get; set; }
        [Column("com")]
        public string Com { get; set; }
        [Column("attachment")]
        public byte[] Attachment { get; set; }
        [Required]
        [Column("shiftname")]
        [StringLength(5)]
        public string Shiftname { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
        [Column("num_people", TypeName = "decimal(18, 3)")]
        public decimal NumPeople { get; set; }
        [Column("manual_target", TypeName = "decimal(18, 2)")]
        public decimal? ManualTarget { get; set; }
        [Column("pn")]
        [StringLength(100)]
        public string Pn { get; set; }
        [Column("Target_Runtime", TypeName = "decimal(18, 5)")]
        public decimal? TargetRuntime { get; set; }
        [Column("Non_schedRuntime", TypeName = "decimal(18, 5)")]
        public decimal? NonSchedRuntime { get; set; }
        [Column("Actual_Runtime", TypeName = "decimal(18, 5)")]
        public decimal? ActualRuntime { get; set; }
        [Column("Non_schedReason")]
        [StringLength(50)]
        public string NonSchedReason { get; set; }
        [Column("changeoverHrs", TypeName = "decimal(18, 3)")]
        public decimal? ChangeoverHrs { get; set; }
        [Column("co_type")]
        [StringLength(50)]
        public string CoType { get; set; }
        public bool? ToolChanged { get; set; }
        [Column("offLoads")]
        public int? OffLoads { get; set; }
    }
}
