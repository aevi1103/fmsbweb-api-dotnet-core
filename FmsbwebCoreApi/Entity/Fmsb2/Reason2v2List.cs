using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class Reason2v2List
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Column("reason1id")]
        public int Reason1id { get; set; }
        [Column("reason1")]
        public string Reason1 { get; set; }
        [Column("reason2")]
        [StringLength(500)]
        public string Reason2 { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
