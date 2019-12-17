using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblRingAssemblyDetails")]
    public partial class TblRingAssemblyDetails
    {
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
        public int? ExpanderQty { get; set; }
        public int? RailQty { get; set; }
        public int? LowerCompQty { get; set; }
        public int? UpperCompQty { get; set; }
        public int? PinQty { get; set; }
        public int? CirclipQty { get; set; }
        public int? RodQty { get; set; }

        [ForeignKey("CoatDate,Shift,DepartmentId,Run,RunNr,PartId")]
        [InverseProperty("TblRingAssemblyDetails")]
        public virtual TblCoating TblCoating { get; set; }
    }
}
