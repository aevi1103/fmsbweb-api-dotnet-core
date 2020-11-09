using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    public partial class MachineMapping
    {
        [Key]
        [Column("machine")]
        [StringLength(100)]
        public string Machine { get; set; }
        [Required]
        [Column("machine_hxh")]
        [StringLength(100)]
        public string MachineHxh { get; set; }
        [Column("side")]
        [StringLength(50)]
        public string Side { get; set; }
        [Required]
        [StringLength(50)]
        public string Department { get; set; }
        [Required]
        [StringLength(50)]
        public string Area { get; set; }
        [Column("line")]
        [StringLength(50)]
        public string Line { get; set; }
        [Column("deptid")]
        public int? Deptid { get; set; }
        [Column("machineId")]
        public int? MachineId { get; set; }
        [Column("MachineMapping")]
        [StringLength(20)]
        public string MachineMapping1 { get; set; }
        [Column("machineNumber")]
        [StringLength(10)]
        public int? MachineNumber { get; set; }
    }
}
