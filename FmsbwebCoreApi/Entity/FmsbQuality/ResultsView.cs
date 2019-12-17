using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class ResultsView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("typeid")]
        public int Typeid { get; set; }
        [Column("checksheet_login_id")]
        public int ChecksheetLoginId { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Column("subMachineId")]
        public int SubMachineId { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Column("characteristicsId")]
        public int CharacteristicsId { get; set; }
        [Required]
        [Column("checksheetType")]
        [StringLength(50)]
        public string ChecksheetType { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("checksheet_mach")]
        [StringLength(50)]
        public string ChecksheetMach { get; set; }
        [Column("checksheet_quality")]
        [StringLength(50)]
        public string ChecksheetQuality { get; set; }
        [Column("line_quality")]
        public int? LineQuality { get; set; }
        [Column("line_mach")]
        public int? LineMach { get; set; }
        [Required]
        [Column("partNum")]
        [StringLength(50)]
        public string PartNum { get; set; }
        [Column("clockNum")]
        public int? ClockNum { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine { get; set; }
        [Required]
        [Column("subMachine")]
        [StringLength(50)]
        public string SubMachine { get; set; }
        [Required]
        [Column("freq")]
        [StringLength(50)]
        public string Freq { get; set; }
        [Column("sort")]
        public int Sort { get; set; }
        [Required]
        [Column("number_ref")]
        [StringLength(200)]
        public string NumberRef { get; set; }
        [Required]
        [Column("gauge")]
        [StringLength(100)]
        public string Gauge { get; set; }
        [Required]
        [Column("frequency")]
        [StringLength(200)]
        public string Frequency { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }
        [Column("min", TypeName = "decimal(18, 5)")]
        public decimal? Min { get; set; }
        [Column("nom", TypeName = "decimal(18, 5)")]
        public decimal? Nom { get; set; }
        [Column("max", TypeName = "decimal(18, 5)")]
        public decimal? Max { get; set; }
        [Column("expectedValueType")]
        [StringLength(50)]
        public string ExpectedValueType { get; set; }
        [Column("value_decimal", TypeName = "decimal(18, 5)")]
        public decimal? ValueDecimal { get; set; }
        [Column("value_bool")]
        public bool? ValueBool { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
