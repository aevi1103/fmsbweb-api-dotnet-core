using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy3
    {
        [Column("Assembly3ID")]
        public int Assembly3Id { get; set; }
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
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? PinInsertion { get; set; }
        public int? Vision { get; set; }
        public int? Oiler { get; set; }
        public int? PinForce { get; set; }
        public int? BlackDotVision { get; set; }
        public int? RodOrientation { get; set; }
        public int? PushPush { get; set; }
        [Column("LVDT")]
        public int? Lvdt { get; set; }
        public int? VisionHandling { get; set; }
        public int? RodPinFreeness { get; set; }
        public int? RingFreeness { get; set; }
        [Column("Preassy_old")]
        public short? PreassyOld { get; set; }
        [Column("MachFault_old")]
        public short? MachFaultOld { get; set; }
        [Column("rod_rej_old")]
        public short? RodRejOld { get; set; }
        [Column("assyhand_old")]
        public short? AssyhandOld { get; set; }
        [Column("comp_old")]
        public short? CompOld { get; set; }
        [Column("blackdot_old")]
        public short? BlackdotOld { get; set; }
        [Column("changeover_min")]
        public short? ChangeoverMin { get; set; }
        [Column("totalassyScrap")]
        public int? TotalassyScrap { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
        public int? Runtime { get; set; }
    }
}
