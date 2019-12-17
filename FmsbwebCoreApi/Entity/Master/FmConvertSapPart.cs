using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FmConvertSapPart
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("line")]
        [StringLength(50)]
        public string Line { get; set; }
        [Column("SAP_Parts")]
        [StringLength(101)]
        public string SapParts { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [Required]
        [StringLength(50)]
        public string DefectArea { get; set; }
        public string DefectName { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [Required]
        [StringLength(10)]
        public string Department { get; set; }
        [Column("SAPPart")]
        [StringLength(30)]
        public string Sappart { get; set; }
    }
}
