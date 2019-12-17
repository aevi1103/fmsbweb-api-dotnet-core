using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy7
    {
        [Column("Assembly7ID")]
        public int Assembly7Id { get; set; }
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
        public string Orientation { get; set; }
        [Column("gross")]
        public short? Gross { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_Anodizing")]
        public short? NadAnodizing { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        public int? FalseReject { get; set; }
        public int? Shape { get; set; }
        public int? OffLocation { get; set; }
        public int? Size { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? PinInsertion { get; set; }
        public int? Vision { get; set; }
        public int? Circlip1 { get; set; }
        public int? Circlip2 { get; set; }
        public int? PushPush { get; set; }
        public int? RodOrientation { get; set; }
        public int? MissingLaserPro { get; set; }
        public int? NoCirclips { get; set; }
        public int? FlaseReject2ClipsSeated { get; set; }
        public int? RodPinFreeness { get; set; }
        public int? RingFreeness { get; set; }
        public int? GradeMarkFailure { get; set; }
        public int? PackOutHandlingLargeRobot { get; set; }
        [Column("preassy_old")]
        public short? PreassyOld { get; set; }
        [Column("machfault_old")]
        public short? MachfaultOld { get; set; }
        [Column("rod_old")]
        public short? RodOld { get; set; }
        [Column("assyhand_old")]
        public short? AssyhandOld { get; set; }
        [Column("comp_old")]
        public short? CompOld { get; set; }
        [Column("blackdot_old")]
        public short? BlackdotOld { get; set; }
        [Column("changeover_min")]
        public short? ChangeoverMin { get; set; }
        [Column("total")]
        public int? Total { get; set; }
        public int? Runtime { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
    }
}
