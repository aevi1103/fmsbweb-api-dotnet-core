using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class AssyChangeover
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("hourId")]
        public int HourId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [Column("deptName")]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [Column("machineName")]
        [StringLength(50)]
        public string MachineName { get; set; }
        [Required]
        [Column("question")]
        [StringLength(500)]
        public string Question { get; set; }
        [Required]
        [Column("yesNo")]
        [StringLength(3)]
        public string YesNo { get; set; }
        [Column("mnodifiedDate", TypeName = "datetime")]
        public DateTime MnodifiedDate { get; set; }
        [Required]
        [Column("fromPart")]
        [StringLength(50)]
        public string FromPart { get; set; }
        [Required]
        [Column("toPart")]
        [StringLength(50)]
        public string ToPart { get; set; }
        [Column("hourNum")]
        public int HourNum { get; set; }
        [Column("order")]
        public int Order { get; set; }
        public string ClockNums { get; set; }
    }
}
