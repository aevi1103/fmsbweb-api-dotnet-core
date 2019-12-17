using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AfAllMachineDowntime
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
        public string Machine { get; set; }
        [Required]
        [StringLength(50)]
        public string Part { get; set; }
        [StringLength(50)]
        public string Grade { get; set; }
        [StringLength(50)]
        public string EnteredBy { get; set; }
        [Column("loss", TypeName = "decimal(18, 2)")]
        public decimal? Loss { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeName { get; set; }
        [Required]
        [StringLength(10)]
        public string Area { get; set; }
        [Required]
        [StringLength(3)]
        public string Department { get; set; }
    }
}
