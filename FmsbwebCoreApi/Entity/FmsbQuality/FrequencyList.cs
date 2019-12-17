using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class FrequencyList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("sort")]
        public int Sort { get; set; }
        [Required]
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("machineId")]
        public int MachineId { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine { get; set; }
        [Required]
        [Column("checksheetType")]
        [StringLength(50)]
        public string ChecksheetType { get; set; }
        [Required]
        [Column("map")]
        [StringLength(52)]
        public string Map { get; set; }
    }
}
