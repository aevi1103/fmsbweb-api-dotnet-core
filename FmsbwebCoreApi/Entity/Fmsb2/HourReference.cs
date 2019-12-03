using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class HourReference
    {
        public int HrNumber { get; set; }
        [Column("time")]
        public TimeSpan Time { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
    }
}
