using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtScrapDeptArea")]
    public partial class TblxtScrapDeptArea
    {
        public TblxtScrapDeptArea()
        {
            TblxtScrapDeptAreaDef = new HashSet<TblxtScrapDeptAreaDef>();
        }

        [Key]
        [Column("ScrapDeptID")]
        [StringLength(1)]
        public string ScrapDeptId { get; set; }
        [Key]
        [Column("ScrapDeptAreaID")]
        [StringLength(1)]
        public string ScrapDeptAreaId { get; set; }
        [StringLength(20)]
        public string ScrapDeptArea { get; set; }
        [StringLength(1)]
        public string DefectDepartment { get; set; }

        [ForeignKey(nameof(ScrapDeptId))]
        [InverseProperty(nameof(TblxtScrapDept.TblxtScrapDeptArea))]
        public virtual TblxtScrapDept ScrapDept { get; set; }
        [InverseProperty("ScrapDept")]
        public virtual ICollection<TblxtScrapDeptAreaDef> TblxtScrapDeptAreaDef { get; set; }
    }
}
