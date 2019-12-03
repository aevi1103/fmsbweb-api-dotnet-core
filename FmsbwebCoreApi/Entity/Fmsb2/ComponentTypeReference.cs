using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.Fmsb2
{
    public partial class ComponentTypeReference
    {
        [Key]
        [StringLength(3)]
        public string ComponentId { get; set; }
        [Required]
        [StringLength(50)]
        public string ComponentName { get; set; }
    }
}
