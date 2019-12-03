using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("componentTypeId")]
        public int ComponentTypeId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("groupId")]
        public int GroupId { get; set; }
        [Required]
        [Column("componentCategory")]
        [StringLength(50)]
        public string ComponentCategory { get; set; }
        [Required]
        [Column("component")]
        [StringLength(50)]
        public string Component { get; set; }
        [Column("pn")]
        [StringLength(50)]
        public string Pn { get; set; }
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
        public int? ProdId { get; set; }
        [Required]
        [Column("stat")]
        [StringLength(23)]
        public string Stat { get; set; }
    }
}
