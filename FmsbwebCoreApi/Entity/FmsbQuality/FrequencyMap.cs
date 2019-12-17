using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class FrequencyMap
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("checksheet")]
        [StringLength(50)]
        public string Checksheet { get; set; }
        [Required]
        [Column("map")]
        [StringLength(50)]
        public string Map { get; set; }
        [Column("typeId")]
        public int? TypeId { get; set; }
    }
}
