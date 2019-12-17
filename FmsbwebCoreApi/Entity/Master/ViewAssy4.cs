using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy4
    {
        [Column("Assembly4ID")]
        public int Assembly4Id { get; set; }
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
        [Column("ANOD")]
        public short? Anod { get; set; }
        [Column("sc")]
        public short? Sc { get; set; }
        public int? Expander { get; set; }
        public int? LowerRail { get; set; }
        public int? UpperRail { get; set; }
        public int? LowerComp { get; set; }
        public int? UpperComp { get; set; }
        public int? Dropped { get; set; }
        public int? Casting { get; set; }
        public int? Scratches { get; set; }
        public int? TightPin { get; set; }
        [Column("pre_old")]
        public short PreOld { get; set; }
        [Column("machfault_old")]
        public short MachfaultOld { get; set; }
        [Column("rod_old")]
        public short RodOld { get; set; }
        [Column("assyhand_old")]
        public short AssyhandOld { get; set; }
        [Column("comp_old")]
        public short CompOld { get; set; }
        [Column("blackdot_old")]
        public short BlackdotOld { get; set; }
        [Column("Changeover_min")]
        public short? ChangeoverMin { get; set; }
        public int? TotalAssyScrap { get; set; }
        public int? Runtime { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
    }
}
