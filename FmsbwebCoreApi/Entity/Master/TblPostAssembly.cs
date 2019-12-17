using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPostAssembly")]
    public partial class TblPostAssembly
    {
        [Key]
        [Column("PADate", TypeName = "datetime")]
        public DateTime Padate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Key]
        [Column("RunNR")]
        public short RunNr { get; set; }
        [StringLength(5)]
        public string Inspector { get; set; }
        public int? NrReviewed { get; set; }
    }
}
