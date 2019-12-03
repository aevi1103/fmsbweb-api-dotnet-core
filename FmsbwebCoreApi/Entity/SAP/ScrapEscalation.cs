using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("Scrap_Escalation")]
    public partial class ScrapEscalation
    {
        public ScrapEscalation()
        {
            ScrapEscalationLog = new HashSet<ScrapEscalationLog>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("machine")]
        [StringLength(5000)]
        public string Machine { get; set; }
        [Required]
        [Column("scrapCode")]
        [StringLength(5000)]
        public string ScrapCode { get; set; }
        [Column("alert_level")]
        public int AlertLevel { get; set; }
        [Column("qty")]
        public int Qty { get; set; }
        [Column("modifiedDate", TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
        [Column("escalationRecipientId")]
        public int EscalationRecipientId { get; set; }
        [Column("escalationMsgId")]
        public int EscalationMsgId { get; set; }
        [Column("shift")]
        [StringLength(5)]
        public string Shift { get; set; }

        [ForeignKey(nameof(EscalationMsgId))]
        [InverseProperty(nameof(EscalationMessage.ScrapEscalation))]
        public virtual EscalationMessage EscalationMsg { get; set; }
        [ForeignKey(nameof(EscalationRecipientId))]
        [InverseProperty(nameof(EscalationRecipients.ScrapEscalation))]
        public virtual EscalationRecipients EscalationRecipient { get; set; }
        [InverseProperty("ScrapEscalation")]
        public virtual ICollection<ScrapEscalationLog> ScrapEscalationLog { get; set; }
    }
}
