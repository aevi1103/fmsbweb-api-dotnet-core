using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_DowntimeCounts")]
    public partial class TblDowntimeCounts
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("PID")]
        public int Pid { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeCode { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Minutes { get; set; }
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [StringLength(50)]
        public string DowntimeName { get; set; }

        [ForeignKey(nameof(DowntimeCode))]
        [InverseProperty(nameof(TblDowntimeList.TblDowntimeCounts))]
        public virtual TblDowntimeList DowntimeCodeNavigation { get; set; }
        [ForeignKey(nameof(Pid))]
        [InverseProperty(nameof(TblAssyProd.TblDowntimeCounts))]
        public virtual TblAssyProd P { get; set; }
    }
}
