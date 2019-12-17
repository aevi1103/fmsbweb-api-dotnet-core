using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tbl_CycleTime")]
    public partial class TblCycleTime
    {
        [Column(TypeName = "decimal(18, 5)")]
        public decimal CycleTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Key]
        [StringLength(50)]
        public string MachineCode { get; set; }

        [ForeignKey(nameof(MachineCode))]
        [InverseProperty(nameof(TblMachineNames.TblCycleTime))]
        public virtual TblMachineNames MachineCodeNavigation { get; set; }
    }
}
