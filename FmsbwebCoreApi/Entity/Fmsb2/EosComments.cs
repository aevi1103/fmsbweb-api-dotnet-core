using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    [Table("EOS_Comments")]
    public partial class EosComments
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(5)]
        public string Shift { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(50)]
        public string Machine { get; set; }
        [Column("side")]
        [StringLength(5)]
        public string Side { get; set; }
        [Required]
        [Column("comment")]
        public string Comment { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
