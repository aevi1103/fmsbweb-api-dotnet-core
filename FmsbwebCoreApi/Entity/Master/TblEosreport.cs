using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblEOSReport")]
    public partial class TblEosreport
    {
        [Key]
        [Column("EOSReportID")]
        public int EosreportId { get; set; }
        [Column("EDate", TypeName = "datetime")]
        public DateTime Edate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [StringLength(25)]
        public string Supervisor { get; set; }
        [Column("HPI")]
        [StringLength(254)]
        public string Hpi { get; set; }
        public int? SafetyIncidents { get; set; }
        [Required]
        [StringLength(3)]
        public string StopObs { get; set; }
        [Required]
        [StringLength(3)]
        public string LayeredAudit { get; set; }
        [StringLength(50)]
        public string AuditArea { get; set; }
        [Required]
        [Column("Non_Conform")]
        [StringLength(3)]
        public string NonConform { get; set; }
        [Column("PSOOvertime")]
        public int? Psoovertime { get; set; }
        [Column("SCOOvertime")]
        public int? Scoovertime { get; set; }
        public int? TempEmps { get; set; }
        [Required]
        [StringLength(3)]
        public string ScreenInv { get; set; }
        [Required]
        [Column("COCartInv")]
        [StringLength(3)]
        public string CocartInv { get; set; }
        [Required]
        [StringLength(3)]
        public string ChemInv { get; set; }
        [Column("AFOnly")]
        public short? Afonly { get; set; }
        [Column("AF2Proto")]
        public short? Af2proto { get; set; }
        [Column("AF2Mach")]
        public short? Af2mach { get; set; }
        [Column("AF2Other")]
        public short? Af2other { get; set; }
        [Column("AFOT")]
        public int? Afot { get; set; }
        [Column("AFDOT")]
        public int? Afdot { get; set; }
    }
}
