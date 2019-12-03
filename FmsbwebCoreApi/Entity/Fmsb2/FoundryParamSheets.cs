using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class FoundryParamSheets
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("characteristicId")]
        public int CharacteristicId { get; set; }
        [Required]
        [Column("value")]
        [StringLength(500)]
        public string Value { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("paramId")]
        public int ParamId { get; set; }

        [ForeignKey(nameof(CharacteristicId))]
        [InverseProperty(nameof(FoundryParamCharacteristics.FoundryParamSheets))]
        public virtual FoundryParamCharacteristics Characteristic { get; set; }
        [ForeignKey(nameof(ParamId))]
        [InverseProperty(nameof(FoundryParamSheetIds.FoundryParamSheets))]
        public virtual FoundryParamSheetIds Param { get; set; }
    }
}
