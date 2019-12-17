using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class CommentList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("loginId")]
        public int LoginId { get; set; }
        [Column("charId")]
        public int CharId { get; set; }
        [Required]
        [Column("characteristics")]
        [StringLength(500)]
        public string Characteristics { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Required]
        [Column("value")]
        [StringLength(50)]
        public string Value { get; set; }
        [Column("subId")]
        public int SubId { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine { get; set; }
        [Required]
        [Column("subMachine")]
        [StringLength(50)]
        public string SubMachine { get; set; }
        [Required]
        [Column("part")]
        [StringLength(50)]
        public string Part { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("message")]
        public string Message { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("line")]
        public int Line { get; set; }
    }
}
