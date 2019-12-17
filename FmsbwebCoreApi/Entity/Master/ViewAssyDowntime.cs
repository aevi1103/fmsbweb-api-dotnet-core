using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssyDowntime
    {
        [Column("PID")]
        public int Pid { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeName { get; set; }
        [Column("min", TypeName = "decimal(38, 2)")]
        public decimal? Min { get; set; }
    }
}
