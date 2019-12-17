using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_ScrapList")]
    public partial class TblScrapList
    {
        [Required]
        [StringLength(50)]
        public string ScrapCode { get; set; }
        [Required]
        [StringLength(100)]
        public string ScrapName { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Key]
        [Column("ScrapID")]
        public int ScrapId { get; set; }

        [ForeignKey(nameof(MachineCode))]
        [InverseProperty(nameof(TblMachineNames.TblScrapList))]
        public virtual TblMachineNames MachineCodeNavigation { get; set; }
        [ForeignKey(nameof(ScrapCode))]
        [InverseProperty(nameof(TblScodes.TblScrapList))]
        public virtual TblScodes ScrapCodeNavigation { get; set; }
    }
}
