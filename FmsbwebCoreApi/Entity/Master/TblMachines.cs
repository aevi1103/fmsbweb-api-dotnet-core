using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    [Table("tblMachines")]
    public partial class TblMachines
    {
        [Key]
        [Column("MachineID")]
        [StringLength(12)]
        public string MachineId { get; set; }
        [Required]
        [StringLength(20)]
        public string MachineDesc { get; set; }
        [Column("ParentID")]
        [StringLength(12)]
        public string ParentId { get; set; }
    }
}
