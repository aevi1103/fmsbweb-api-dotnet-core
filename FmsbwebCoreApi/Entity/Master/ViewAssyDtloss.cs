using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssyDtloss
    {
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
        [StringLength(50)]
        public string DowntimeName { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MinLoss { get; set; }
        [Column(TypeName = "decimal(23, 19)")]
        public decimal? HourLoss { get; set; }
    }
}
