using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy2
    {
        [Column("Assembly2ID")]
        public int Assembly2Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(2)]
        public string Grade { get; set; }
        [Column("gross")]
        public short? Gross { get; set; }
        [Column("fs")]
        public short? Fs { get; set; }
        [Column("ms")]
        public short? Ms { get; set; }
        public short? Anodize { get; set; }
        [Column("SC")]
        public short? Sc { get; set; }
        public int? Vision { get; set; }
        [Column("PRAM")]
        public int? Pram { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? PinInsertion { get; set; }
        public int? FalseReject { get; set; }
        public int? Shape { get; set; }
        public int? OffLocation { get; set; }
        public int? Size { get; set; }
        public int? WipeOff { get; set; }
        public int? LaserPro { get; set; }
        public int? NoCirclips { get; set; }
        [Column("stSnapRing")]
        public int StSnapRing { get; set; }
        [Column("ndSnapRing")]
        public int NdSnapRing { get; set; }
        public int ClipsSeated { get; set; }
        public int? RodPinFreeness { get; set; }
        public int? RingFreeness { get; set; }
        [Column("preassy_old")]
        public short? PreassyOld { get; set; }
        [Column("machinefault_old")]
        public short? MachinefaultOld { get; set; }
        [Column("reject_old")]
        public short? RejectOld { get; set; }
        [Column("handling_old")]
        public short? HandlingOld { get; set; }
        [Column("ComponentDef_old")]
        public short? ComponentDefOld { get; set; }
        [Column("Dot_old")]
        public short? DotOld { get; set; }
        [Column("Changeover_min")]
        public short? ChangeoverMin { get; set; }
        public int? TotalAssyScrap { get; set; }
        public int? Runtime { get; set; }
        [Column("otherCom")]
        [StringLength(254)]
        public string OtherCom { get; set; }
    }
}
