using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblA3DailyChkSheet")]
    public partial class TblA3dailyChkSheet
    {
        [Key]
        [Column("VDate", TypeName = "datetime")]
        public DateTime Vdate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Key]
        [StringLength(1)]
        public string Run { get; set; }
        [Key]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(50)]
        public string EnteredBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TimeStamp { get; set; }
        [Column("PistonOD")]
        public bool PistonOd { get; set; }
        public bool PistonOrient { get; set; }
        public bool ExpanderOrient { get; set; }
        public bool RailOrient { get; set; }
        [Column("UCRLoad")]
        public bool? Ucrload { get; set; }
        [Column("LCRLoad")]
        public bool Lcrload { get; set; }
        [Column("LCROrient")]
        public bool Lcrorient { get; set; }
        [Column("UCROrient")]
        public bool Ucrorient { get; set; }
        [Column("UCRMissing")]
        public bool Ucrmissing { get; set; }
        [Column("LCRMissing")]
        public bool Lcrmissing { get; set; }
        public bool ExpanderMissing { get; set; }
        public bool ExpanderUpDown { get; set; }
        public bool RailGapOrient { get; set; }
        public bool InkReserviorLevel { get; set; }
        public bool InkNozzlesLeakFree { get; set; }
        public bool? InkBlackStripe { get; set; }
        public bool InkJetGrade { get; set; }
        public bool GradeSetting { get; set; }
        public bool PaintDot { get; set; }
        public bool PaintDotVerify { get; set; }
        public bool OilReservior { get; set; }
        public short? OilNozzlePressure1 { get; set; }
        public int? OilNozzlePressure2 { get; set; }
        public short? OilNozzlePressure3 { get; set; }
        public bool RodOrient { get; set; }
        public bool ForeignPin { get; set; }
        public short? ForceDetectMaster { get; set; }
        public short? ForceDetectProduction { get; set; }
        public bool CirclipGageMissing { get; set; }
        public bool CirclipGageUnseated { get; set; }
        public bool CirclipCameraMissing { get; set; }
        public bool CirclipCameraDouble { get; set; }
        public bool CirclipCameraUnseated { get; set; }
        public bool RodOrient2 { get; set; }
        public bool SerialDateCode { get; set; }
        public bool InkJetDateCode { get; set; }
        public bool? InkJetCrown { get; set; }
        public bool PistonOnload { get; set; }
        public bool Dial2RejectChute { get; set; }
        public bool Dial3RejectChute { get; set; }
        public bool PinOnload { get; set; }
        public bool PistonOffload { get; set; }
        public bool LotTraceability { get; set; }
        public bool MasterReturned { get; set; }
        [StringLength(254)]
        public string Comments { get; set; }
    }
}
