using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfAssyDowntime
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Grade { get; set; }
        [Required]
        [StringLength(50)]
        public string ClockNum { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Minutes { get; set; }
    }
}
