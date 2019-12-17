using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblDieHistory")]
    public partial class TblDieHistory
    {
        [Required]
        [Column("DieID")]
        [StringLength(12)]
        public string DieId { get; set; }
        public bool Approved { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? ApprovalDate { get; set; }
        [StringLength(255)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeEntered { get; set; }
        [StringLength(50)]
        public string Location { get; set; }
        public int? ApprovedBy { get; set; }
        public bool? MgrApproved { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? MgrApprovedDate { get; set; }
        public int? MgrApprovedBy { get; set; }
    }
}
