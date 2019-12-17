using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class ViewAssyScrap
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
        [Column("gross")]
        public int? Gross { get; set; }
        public int? CountGross { get; set; }
        public int? GrossD { get; set; }
        [StringLength(100)]
        public string ScrapName { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Column(TypeName = "decimal(38, 20)")]
        public decimal? ScrapP { get; set; }
    }
}
