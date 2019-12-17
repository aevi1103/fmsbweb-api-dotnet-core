using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class Resultview2
    {
        [Column("typeid")]
        public int Typeid { get; set; }
        [Column("checksheet_login_id")]
        public int ChecksheetLoginId { get; set; }
        [Column("characteristicsId")]
        public int CharacteristicsId { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Column("subMachineId")]
        public int SubMachineId { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("checksheet")]
        [StringLength(50)]
        public string Checksheet { get; set; }
        [Column("line")]
        public int? Line { get; set; }
        [Required]
        [Column("partNum")]
        [StringLength(50)]
        public string PartNum { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine { get; set; }
        [Required]
        [Column("subMachine")]
        [StringLength(50)]
        public string SubMachine { get; set; }
        [Column("sort")]
        public int Sort { get; set; }
        [Required]
        [Column("number_ref")]
        [StringLength(200)]
        public string NumberRef { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }
        [Required]
        [Column("gauge")]
        [StringLength(100)]
        public string Gauge { get; set; }
        [Required]
        [Column("frequency")]
        [StringLength(200)]
        public string Frequency { get; set; }
        [Column("min", TypeName = "decimal(18, 5)")]
        public decimal? Min { get; set; }
        [Column("nom", TypeName = "decimal(18, 5)")]
        public decimal? Nom { get; set; }
        [Column("max", TypeName = "decimal(18, 5)")]
        public decimal? Max { get; set; }
        [Column("expectedValueType")]
        [StringLength(50)]
        public string ExpectedValueType { get; set; }
        [Required]
        [Column("freq")]
        [StringLength(50)]
        public string Freq { get; set; }
        [Column("value", TypeName = "decimal(18, 5)")]
        public decimal? Value { get; set; }
    }
}
