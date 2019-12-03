using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class MachineGroupNumber
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("machineGroupId")]
        public int MachineGroupId { get; set; }
        [Column("machineNumber")]
        [StringLength(50)]
        public string MachineNumber { get; set; }
        [Column("modifieddate", TypeName = "datetime")]
        public DateTime Modifieddate { get; set; }
        [Column("isActive")]
        public bool? IsActive { get; set; }
    }
}
