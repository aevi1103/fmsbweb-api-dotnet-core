using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblPostAssemblyDetails")]
    public partial class TblPostAssemblyDetails
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
        [StringLength(25)]
        public string Description { get; set; }
        public int? Quantity { get; set; }
        [Key]
        [Column("RunNR")]
        public short RunNr { get; set; }
    }
}
