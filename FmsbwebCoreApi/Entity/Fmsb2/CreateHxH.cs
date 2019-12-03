using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class CreateHxH
    {
        public CreateHxH()
        {
            HourByHour = new HashSet<HourByHour>();
            HxhOpsClockNum = new HashSet<HxhOpsClockNum>();
            ScrapHxh = new HashSet<ScrapHxh>();
        }

        [Key]
        [Column("hrId")]
        public int HrId { get; set; }
        [Column("shiftdate", TypeName = "datetime")]
        public DateTime Shiftdate { get; set; }
        [Required]
        [Column("shift")]
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("deptid")]
        public int Deptid { get; set; }
        [Column("machineid")]
        public int Machineid { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime? Modifieddate { get; set; }
        [StringLength(10)]
        public string CellSide { get; set; }
        [Required]
        public byte[] RowVersion { get; set; }

        [InverseProperty("HourNavigation")]
        public virtual ICollection<HourByHour> HourByHour { get; set; }
        [InverseProperty("Hxh")]
        public virtual ICollection<HxhOpsClockNum> HxhOpsClockNum { get; set; }
        [InverseProperty("Hxh")]
        public virtual ICollection<ScrapHxh> ScrapHxh { get; set; }
    }
}
