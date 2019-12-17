using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class EooExcelDownload
    {
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("PN")]
        [StringLength(6)]
        public string Pn { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectAreaName { get; set; }
        [Required]
        public string DefectName { get; set; }
        public int? Qty { get; set; }
        public string Comments { get; set; }
    }
}
