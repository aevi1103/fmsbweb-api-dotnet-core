using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class CheckSheetCharacteristics
    {
        public CheckSheetCharacteristics()
        {
            ChecksheetResults = new HashSet<ChecksheetResults>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("part_num")]
        [StringLength(200)]
        public string PartNum { get; set; }
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
        [Required]
        [Column("word_value")]
        [StringLength(200)]
        public string WordValue { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("expectedValueType")]
        [StringLength(50)]
        public string ExpectedValueType { get; set; }
        [Column("typeId")]
        public int TypeId { get; set; }

        [ForeignKey(nameof(MachineId))]
        [InverseProperty("CheckSheetCharacteristics")]
        public virtual Machine Machine { get; set; }
        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(ChecksheetType.CheckSheetCharacteristics))]
        public virtual ChecksheetType Type { get; set; }
        [InverseProperty("Characteristics")]
        public virtual ICollection<ChecksheetResults> ChecksheetResults { get; set; }
    }
}
