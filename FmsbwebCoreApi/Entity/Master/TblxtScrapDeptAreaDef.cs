using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtScrapDeptAreaDef")]
    public partial class TblxtScrapDeptAreaDef
    {
        [Key]
        [Column("ScrapDeptID")]
        [StringLength(1)]
        public string ScrapDeptId { get; set; }
        [Key]
        [Column("ScrapDeptAreaID")]
        [StringLength(1)]
        public string ScrapDeptAreaId { get; set; }
        [Key]
        [Column("ScrapDeptAreaDefectID")]
        [StringLength(2)]
        public string ScrapDeptAreaDefectId { get; set; }
        [StringLength(40)]
        public string ScrapDeptAreaDefect { get; set; }
        [Column("HepworthID")]
        [StringLength(4)]
        public string HepworthId { get; set; }
        [Column("SummaryID")]
        [StringLength(4)]
        public string SummaryId { get; set; }

        [ForeignKey("ScrapDeptId,ScrapDeptAreaId")]
        [InverseProperty(nameof(TblxtScrapDeptArea.TblxtScrapDeptAreaDef))]
        public virtual TblxtScrapDeptArea ScrapDept { get; set; }
        [ForeignKey(nameof(SummaryId))]
        [InverseProperty(nameof(TblHepSummary.TblxtScrapDeptAreaDef))]
        public virtual TblHepSummary Summary { get; set; }
    }
}
