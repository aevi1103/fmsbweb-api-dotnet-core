using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ChecksExist
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [Column("fromPart")]
        [StringLength(50)]
        public string FromPart { get; set; }
        [Required]
        [Column("toPart")]
        [StringLength(50)]
        public string ToPart { get; set; }
        [StringLength(50)]
        public string Page { get; set; }
    }
}
