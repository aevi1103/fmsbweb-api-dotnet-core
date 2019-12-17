using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ManningAllDept
    {
        [Column("shiftDate", TypeName = "datetime")]
        public DateTime ShiftDate { get; set; }
        [Required]
        [Column("shiftname")]
        [StringLength(50)]
        public string Shiftname { get; set; }
        [Column("ppl", TypeName = "decimal(38, 3)")]
        public decimal? Ppl { get; set; }
        [Column("manHrs", TypeName = "decimal(38, 3)")]
        public decimal? ManHrs { get; set; }
        [Required]
        [Column("dept")]
        [StringLength(12)]
        public string Dept { get; set; }
    }
}
