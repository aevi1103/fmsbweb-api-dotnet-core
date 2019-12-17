using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_DowntimeList")]
    public partial class TblDowntimeList
    {
        public TblDowntimeList()
        {
            TblDowntimeCounts = new HashSet<TblDowntimeCounts>();
        }

        [Key]
        [StringLength(50)]
        public string DowntimeCode { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeName { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("DowntimeCodeNavigation")]
        public virtual ICollection<TblDowntimeCounts> TblDowntimeCounts { get; set; }
    }
}
