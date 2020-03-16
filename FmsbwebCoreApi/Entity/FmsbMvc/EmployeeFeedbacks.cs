using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class EmployeeFeedbacks
    {
        public EmployeeFeedbacks()
        {
            SupervisorConversations = new HashSet<SupervisorConversations>();
        }

        [Key]
        public int EmployeeFeedbackId { get; set; }
        [StringLength(10)]
        public string Feedback { get; set; }

        [InverseProperty("EmployeeFeedback")]
        public virtual ICollection<SupervisorConversations> SupervisorConversations { get; set; }
    }
}
