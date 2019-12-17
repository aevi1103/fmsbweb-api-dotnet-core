using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_Assy_Prod")]
    public partial class TblAssyProd
    {
        public TblAssyProd()
        {
            TblComponentScrap = new HashSet<TblComponentScrap>();
            TblDowntimeCounts = new HashSet<TblDowntimeCounts>();
            TblScrapCounts = new HashSet<TblScrapCounts>();
        }

        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [StringLength(50)]
        public string PartNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string Grade { get; set; }
        [Required]
        [StringLength(50)]
        public string ClockNum { get; set; }
        public int Gross { get; set; }
        [Column("OAE_Comments")]
        public string OaeComments { get; set; }
        [Column("Scrap_Comments")]
        public string ScrapComments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("runtime")]
        public int Runtime { get; set; }
        [Column("stat")]
        public bool? Stat { get; set; }
        [Column("otherComment")]
        public string OtherComment { get; set; }

        [ForeignKey(nameof(MachineCode))]
        [InverseProperty(nameof(TblMachineNames.TblAssyProd))]
        public virtual TblMachineNames MachineCodeNavigation { get; set; }
        [InverseProperty("Prod")]
        public virtual ICollection<TblComponentScrap> TblComponentScrap { get; set; }
        [InverseProperty("P")]
        public virtual ICollection<TblDowntimeCounts> TblDowntimeCounts { get; set; }
        [InverseProperty("Prod")]
        public virtual ICollection<TblScrapCounts> TblScrapCounts { get; set; }
    }
}
