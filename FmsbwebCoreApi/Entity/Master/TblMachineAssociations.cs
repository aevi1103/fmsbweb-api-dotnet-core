using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMachineAssociations")]
    public partial class TblMachineAssociations
    {
        [Required]
        [Column("MachineID")]
        [StringLength(12)]
        public string MachineId { get; set; }
        [Required]
        [StringLength(15)]
        public string Association { get; set; }
    }
}
