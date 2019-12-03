using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Users
    {
        [Key]
        [Column("fmid")]
        [StringLength(50)]
        public string Fmid { get; set; }
        [Required]
        [Column("fname")]
        [StringLength(50)]
        public string Fname { get; set; }
        [Required]
        [Column("lname")]
        [StringLength(50)]
        public string Lname { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("password")]
        public string Password { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
