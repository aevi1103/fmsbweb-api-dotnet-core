using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Employees
    {
        public int ClockNo { get; set; }
        [Required]
        [Column("fname")]
        [StringLength(100)]
        public string Fname { get; set; }
        [Required]
        [Column("lname")]
        [StringLength(100)]
        public string Lname { get; set; }
        [Required]
        [StringLength(208)]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string DeptName { get; set; }
        [Required]
        [StringLength(100)]
        public string JobTitle { get; set; }
    }
}
