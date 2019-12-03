using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("Escalation_Recipients")]
    public partial class EscalationRecipients
    {
        public EscalationRecipients()
        {
            ScrapEscalation = new HashSet<ScrapEscalation>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DeptName { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Shift { get; set; }
        [Required]
        public string EmailRecipients { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("EscalationRecipient")]
        public virtual ICollection<ScrapEscalation> ScrapEscalation { get; set; }
    }
}
