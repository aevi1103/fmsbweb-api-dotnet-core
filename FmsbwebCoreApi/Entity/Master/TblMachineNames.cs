using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_MachineNames")]
    public partial class TblMachineNames
    {
        public TblMachineNames()
        {
            TblAssyProd = new HashSet<TblAssyProd>();
            TblScrapList = new HashSet<TblScrapList>();
        }

        [Key]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [StringLength(100)]
        public string MachineName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }

        [InverseProperty("MachineCodeNavigation")]
        public virtual TblCycleTime TblCycleTime { get; set; }
        [InverseProperty("MachineCodeNavigation")]
        public virtual ICollection<TblAssyProd> TblAssyProd { get; set; }
        [InverseProperty("MachineCodeNavigation")]
        public virtual ICollection<TblScrapList> TblScrapList { get; set; }
    }
}
