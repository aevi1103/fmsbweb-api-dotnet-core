using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class ForkliftView
    {
        public int ForkliftId { get; set; }
        public int MachineId { get; set; }
        [Required]
        [StringLength(500)]
        public string MachineName { get; set; }
        public int ForkliftTaskId { get; set; }
        [Required]
        public string TaskName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequestDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? WorkingDateTime { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CompletedDateTime { get; set; }
        public bool IsWorking { get; set; }
        public bool IsComplete { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
    }
}
