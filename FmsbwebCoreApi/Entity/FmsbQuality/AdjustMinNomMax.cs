using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class AdjustMinNomMax
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("checksheet")]
        [StringLength(50)]
        public string Checksheet { get; set; }
        [Column("machineId")]
        public int? MachineId { get; set; }
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }
        [Column("typeId")]
        public int? TypeId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
    }
}
