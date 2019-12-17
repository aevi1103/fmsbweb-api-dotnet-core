using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCFD")]
    public partial class TblCfd
    {
        [Key]
        [Column("CFD")]
        public int Cfd { get; set; }
        [Column("CDate", TypeName = "datetime")]
        public DateTime? Cdate { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }
        [Column("partID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [StringLength(50)]
        public string Defect { get; set; }
        [StringLength(50)]
        public string Dept { get; set; }
        public int? Qty { get; set; }
    }
}
