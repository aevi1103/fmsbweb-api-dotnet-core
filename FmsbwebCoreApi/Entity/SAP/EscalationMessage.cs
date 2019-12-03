using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.SAP
{
    [Table("Escalation_Message")]
    public partial class EscalationMessage
    {
        public EscalationMessage()
        {
            ScrapEscalation = new HashSet<ScrapEscalation>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [InverseProperty("EscalationMsg")]
        public virtual ICollection<ScrapEscalation> ScrapEscalation { get; set; }
    }
}
