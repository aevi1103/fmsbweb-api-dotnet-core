using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_SCodes")]
    public partial class TblScodes
    {
        public TblScodes()
        {
            TblScrapCounts = new HashSet<TblScrapCounts>();
            TblScrapList = new HashSet<TblScrapList>();
        }

        [Key]
        [StringLength(50)]
        public string ScrapCodes { get; set; }
        public string ScrapName { get; set; }

        [InverseProperty("ScrapCodeNavigation")]
        public virtual ICollection<TblScrapCounts> TblScrapCounts { get; set; }
        [InverseProperty("ScrapCodeNavigation")]
        public virtual ICollection<TblScrapList> TblScrapList { get; set; }
    }
}
