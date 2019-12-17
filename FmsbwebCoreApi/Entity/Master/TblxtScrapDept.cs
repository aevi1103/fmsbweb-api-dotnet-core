using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblxtScrapDept")]
    public partial class TblxtScrapDept
    {
        public TblxtScrapDept()
        {
            TblxtScrapDeptArea = new HashSet<TblxtScrapDeptArea>();
        }

        [Key]
        [Column("ScrapDeptID")]
        [StringLength(1)]
        public string ScrapDeptId { get; set; }
        [StringLength(15)]
        public string ScrapDept { get; set; }

        [InverseProperty("ScrapDept")]
        public virtual ICollection<TblxtScrapDeptArea> TblxtScrapDeptArea { get; set; }
    }
}
