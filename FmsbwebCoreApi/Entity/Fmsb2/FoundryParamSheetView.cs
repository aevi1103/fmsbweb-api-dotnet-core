using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamSheetView
    {
        [Column("paramValueSheetId")]
        public int ParamValueSheetId { get; set; }
        [Column("groupid")]
        public int Groupid { get; set; }
        [Column("characteristicId")]
        public int CharacteristicId { get; set; }
        [Column("paramId")]
        public int ParamId { get; set; }
        [Required]
        [Column("customer")]
        [StringLength(50)]
        public string Customer { get; set; }
        [Required]
        [Column("fmsbPart")]
        [StringLength(50)]
        public string FmsbPart { get; set; }
        [Column("revisionNumber")]
        public int RevisionNumber { get; set; }
        [Required]
        [Column("groupName")]
        [StringLength(50)]
        public string GroupName { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(50)]
        public string Characteristics { get; set; }
        [Required]
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
