using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentRecords
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("componentTypeId")]
        public int ComponentTypeId { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("comments")]
        [StringLength(500)]
        public string Comments { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("hourNum")]
        public int HourNum { get; set; }
        [Column("prodId")]
        public int ProdId { get; set; }
        public int? RodReclaimId { get; set; }
    }
}
