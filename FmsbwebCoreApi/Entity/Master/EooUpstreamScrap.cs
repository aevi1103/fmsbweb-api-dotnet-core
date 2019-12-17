using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("EOO_UpstreamScrap")]
    public partial class EooUpstreamScrap
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectAreaName { get; set; }
        [Required]
        public string DefectName { get; set; }
        public int? Qty { get; set; }
        public string Comments { get; set; }
        [Column("SkitCoatID")]
        public int SkitCoatId { get; set; }

        [ForeignKey(nameof(SkitCoatId))]
        [InverseProperty(nameof(TblSkirtCoat.EooUpstreamScrap))]
        public virtual TblSkirtCoat SkitCoat { get; set; }
    }
}
