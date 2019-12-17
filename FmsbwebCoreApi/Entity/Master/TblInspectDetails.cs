using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblInspectDetails")]
    public partial class TblInspectDetails
    {
        [Column("InspectID")]
        [StringLength(20)]
        public string InspectId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime InspDate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        public byte Line { get; set; }
        [Key]
        [StringLength(1)]
        public string Run { get; set; }
        [Key]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Key]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Key]
        [Column("DefectID")]
        [StringLength(4)]
        public string DefectId { get; set; }
        public int Quantity { get; set; }
        [Required]
        [StringLength(1)]
        public string EntryType { get; set; }

        [ForeignKey("InspDate,Shift,Line,Run,RunNr,PartId")]
        [InverseProperty("TblInspectDetails")]
        public virtual TblInspect TblInspect { get; set; }
    }
}
