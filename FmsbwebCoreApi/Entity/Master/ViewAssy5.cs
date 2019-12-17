using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssy5
    {
        [Column("Assembly5ID")]
        public int Assembly5Id { get; set; }
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
        public short? PackOutTotal { get; set; }
        [Column("NAD_Foundry")]
        public short? NadFoundry { get; set; }
        [Column("NAD_Machining")]
        public short? NadMachining { get; set; }
        [Column("NAD_Anodizing")]
        public short? NadAnodizing { get; set; }
        [Column("NAD_SkirtCoat")]
        public short? NadSkirtCoat { get; set; }
        public int? OperatorHandling { get; set; }
        public int? PistonWeight { get; set; }
        public int? LaserFailure { get; set; }
        public int? MachineHandling { get; set; }
        [Column("preassy_old")]
        public int? PreassyOld { get; set; }
        [Column("hand_old")]
        public short? HandOld { get; set; }
        [Column("changeover_min")]
        public short? ChangeoverMin { get; set; }
        public int? Totalassyscrap { get; set; }
        public int? Runtime { get; set; }
        [StringLength(254)]
        public string ScrapComment { get; set; }
    }
}
