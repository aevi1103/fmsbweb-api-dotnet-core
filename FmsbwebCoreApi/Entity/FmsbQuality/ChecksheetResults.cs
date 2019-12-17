using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    [Table("Checksheet_Results")]
    public partial class ChecksheetResults
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("checksheet_login_id")]
        public int ChecksheetLoginId { get; set; }
        [Column("subMachineId")]
        public int SubMachineId { get; set; }
        [Column("value_decimal", TypeName = "decimal(18, 5)")]
        public decimal? ValueDecimal { get; set; }
        [Column("value_bool")]
        public bool? ValueBool { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Column("characteristicsId")]
        public int CharacteristicsId { get; set; }
        [Required]
        [Column("partNum")]
        [StringLength(50)]
        public string PartNum { get; set; }
        [Column("checksheetName")]
        [StringLength(50)]
        public string ChecksheetName { get; set; }
        [Column("line")]
        public int? Line { get; set; }

        [ForeignKey(nameof(CharacteristicsId))]
        [InverseProperty(nameof(CheckSheetCharacteristics.ChecksheetResults))]
        public virtual CheckSheetCharacteristics Characteristics { get; set; }
        [ForeignKey(nameof(ChecksheetLoginId))]
        [InverseProperty("ChecksheetResults")]
        public virtual ChecksheetLogin ChecksheetLogin { get; set; }
        [ForeignKey(nameof(FrequencyId))]
        [InverseProperty(nameof(MachineFrequency.ChecksheetResults))]
        public virtual MachineFrequency Frequency { get; set; }
        [ForeignKey(nameof(SubMachineId))]
        [InverseProperty("ChecksheetResults")]
        public virtual SubMachine SubMachine { get; set; }
    }
}
