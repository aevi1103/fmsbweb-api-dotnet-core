using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class OaeescalationLogActionsView
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("oaeLogId")]
        public int OaeLogId { get; set; }
        [Column("prodId")]
        public int ProdId { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("hour")]
        public int Hour { get; set; }
        [Column("alarmLevel")]
        public int AlarmLevel { get; set; }
        [Required]
        [Column("name")]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("action")]
        public string Action { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
    }
}
