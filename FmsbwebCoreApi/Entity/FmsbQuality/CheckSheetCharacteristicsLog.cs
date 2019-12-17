using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class CheckSheetCharacteristicsLog
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("old_char_id")]
        public int? OldCharId { get; set; }
        [Column("machineId")]
        public int? MachineId { get; set; }
        [Column("part_num")]
        [StringLength(50)]
        public string PartNum { get; set; }
        [Column("sort")]
        public int? Sort { get; set; }
        [Column("number_ref")]
        [StringLength(50)]
        public string NumberRef { get; set; }
        [Column("characteristics")]
        public string Characteristics { get; set; }
        [Column("gauge")]
        public string Gauge { get; set; }
        [Column("frequency")]
        public string Frequency { get; set; }
        [Column("min", TypeName = "decimal(18, 5)")]
        public decimal? Min { get; set; }
        [Column("nom", TypeName = "decimal(18, 5)")]
        public decimal? Nom { get; set; }
        [Column("max", TypeName = "decimal(18, 5)")]
        public decimal? Max { get; set; }
        [Column("word_value")]
        public string WordValue { get; set; }
        [Column("expectedValueType")]
        [StringLength(50)]
        public string ExpectedValueType { get; set; }
        [Column("typeId")]
        public int? TypeId { get; set; }
        [Column("trigger_status")]
        [StringLength(50)]
        public string TriggerStatus { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
        [Column("new_min", TypeName = "decimal(18, 5)")]
        public decimal? NewMin { get; set; }
        [Column("new_nom", TypeName = "decimal(18, 5)")]
        public decimal? NewNom { get; set; }
        [Column("new_max", TypeName = "decimal(18, 5)")]
        public decimal? NewMax { get; set; }
    }
}
