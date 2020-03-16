using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("DowntimeTriggerThreshold", Schema = "Iconics")]
    public partial class DowntimeTriggerThreshold
    {
        [Key]
        public int DowntimeTriggerThresholdId { get; set; }
        public string DeptName { get; set; }
        public int Threshold { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }
        public bool IsLive { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.DowntimeTriggerThreshold))]
        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}
