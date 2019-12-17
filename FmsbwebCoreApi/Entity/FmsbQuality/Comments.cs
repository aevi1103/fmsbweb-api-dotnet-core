using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbQuality
{
    public partial class Comments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("loginId")]
        public int LoginId { get; set; }
        [Column("charId")]
        public int CharId { get; set; }
        [Column("frequencyId")]
        public int FrequencyId { get; set; }
        [Column("subId")]
        public int SubId { get; set; }
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
