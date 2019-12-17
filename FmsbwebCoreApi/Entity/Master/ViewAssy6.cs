using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy6
    {
        [Column("Assembly6ID")]
        public int Assembly6Id { get; set; }
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
        [Column("NAD_FoundryPre")]
        public short? NadFoundryPre { get; set; }
        [Column("NAD_MachiningPre")]
        public short? NadMachiningPre { get; set; }
        [Column("NAD_AnodizingPre")]
        public short? NadAnodizingPre { get; set; }
        [Column("NAD_SkirtCoatPre")]
        public short? NadSkirtCoatPre { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? PinInsertion { get; set; }
        public int? Circlip { get; set; }
        public int? PinFreeness { get; set; }
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
        [Column("totalassyscrap")]
        public int? Totalassyscrap { get; set; }
        public int? Runtime { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
    }
}
