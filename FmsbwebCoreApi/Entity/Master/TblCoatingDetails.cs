using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCoatingDetails")]
    public partial class TblCoatingDetails
    {
        [Column("CoatingID")]
        public int? CoatingId { get; set; }
        [Key]
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Key]
        [StringLength(1)]
        public string Shift { get; set; }
        [Key]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
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
        public int? Quantity { get; set; }
        [StringLength(1)]
        public string EntryType { get; set; }

        [ForeignKey("CoatDate,Shift,DepartmentId,Run,RunNr,PartId")]
        [InverseProperty("TblCoatingDetails")]
        public virtual TblCoating TblCoating { get; set; }
    }
}
