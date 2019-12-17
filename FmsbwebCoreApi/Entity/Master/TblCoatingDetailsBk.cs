using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblCoatingDetails_bk")]
    public partial class TblCoatingDetailsBk
    {
        [Column("CoatingID")]
        [StringLength(25)]
        public string CoatingId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CoatDate { get; set; }
        [Required]
        [StringLength(1)]
        public string Shift { get; set; }
        [Required]
        [Column("DepartmentID")]
        [StringLength(2)]
        public string DepartmentId { get; set; }
        [Column("ProcessID")]
        [StringLength(3)]
        public string ProcessId { get; set; }
        [Required]
        [StringLength(1)]
        public string Run { get; set; }
        [Required]
        [StringLength(1)]
        public string RunNr { get; set; }
        [Required]
        [Column("PartID")]
        [StringLength(6)]
        public string PartId { get; set; }
        [Required]
        [Column("DefectID")]
        [StringLength(4)]
        public string DefectId { get; set; }
        public int? Quantity { get; set; }
        [StringLength(1)]
        public string EntryType { get; set; }
    }
}
