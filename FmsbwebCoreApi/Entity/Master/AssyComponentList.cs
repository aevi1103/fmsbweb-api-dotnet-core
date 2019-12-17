using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Master
{
    public partial class AssyComponentList
    {
        [Column("ScrapID")]
        public int ScrapId { get; set; }
        [Required]
        [StringLength(100)]
        public string ScrapName { get; set; }
        [Required]
        [StringLength(50)]
        public string MachineCode { get; set; }
        [Required]
        [Column("ComponentID")]
        [StringLength(50)]
        public string ComponentId { get; set; }
        public int Multiplier { get; set; }
    }
}
