using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class ClockNumbers
    {
        public int Id { get; set; }
        public int Clock { get; set; }
        [Required]
        [Column("FName")]
        [StringLength(100)]
        public string Fname { get; set; }
        [Required]
        [Column("LName")]
        [StringLength(100)]
        public string Lname { get; set; }
        [Required]
        [StringLength(100)]
        public string Dept { get; set; }
        [Required]
        [StringLength(10)]
        public string Shift { get; set; }
        [Required]
        [StringLength(100)]
        public string Job { get; set; }
    }
}
