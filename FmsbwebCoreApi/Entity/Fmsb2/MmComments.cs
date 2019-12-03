using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("MM_Comments")]
    public partial class MmComments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(50)]
        public string Dept { get; set; }
        [Required]
        [Column("name")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Column("issue")]
        public string Issue { get; set; }
        [Column("action")]
        public string Action { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column("timeStamp", TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
    }
}
