using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class FmsbMasterDefects
    {
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Column("line")]
        [StringLength(50)]
        public string Line { get; set; }
        public string Part { get; set; }
        [Column("grade")]
        [StringLength(50)]
        public string Grade { get; set; }
        [Column("gross")]
        public int? Gross { get; set; }
        [StringLength(50)]
        public string DefectArea { get; set; }
        public string DefectName { get; set; }
        [Column("qty")]
        public int? Qty { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
    }
}
