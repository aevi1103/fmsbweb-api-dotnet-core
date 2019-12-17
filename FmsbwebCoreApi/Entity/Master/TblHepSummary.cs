using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblHepSummary")]
    public partial class TblHepSummary
    {
        public TblHepSummary()
        {
            TblxtScrapDeptAreaDef = new HashSet<TblxtScrapDeptAreaDef>();
        }

        [Key]
        [Column("SummaryID")]
        [StringLength(4)]
        public string SummaryId { get; set; }
        [StringLength(1)]
        public string Dept { get; set; }
        [StringLength(25)]
        public string Description { get; set; }
        [StringLength(20)]
        public string SummarizedAs { get; set; }

        [InverseProperty("Summary")]
        public virtual ICollection<TblxtScrapDeptAreaDef> TblxtScrapDeptAreaDef { get; set; }
    }
}
