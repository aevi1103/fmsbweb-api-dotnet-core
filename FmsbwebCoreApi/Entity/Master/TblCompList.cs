using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_CompList")]
    public partial class TblCompList
    {
        public TblCompList()
        {
            TblComponentScrap = new HashSet<TblComponentScrap>();
        }

        [Key]
        [StringLength(50)]
        public string ComponentCode { get; set; }

        [InverseProperty("ComponentCodeNavigation")]
        public virtual ICollection<TblComponentScrap> TblComponentScrap { get; set; }
    }
}
