using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    [Table("HxHPushAlerts", Schema = "HxH")]
    public partial class HxHpushAlerts
    {
        [Key]
        [Column("HxHPushAlertsId")]
        public int HxHpushAlertsId { get; set; }
        [Column("HxHPushEnum")]
        public int HxHpushEnum { get; set; }
        public bool Enable { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.HxHpushAlerts))]
        public virtual AspNetUsers ApplicationUser { get; set; }
    }
}
