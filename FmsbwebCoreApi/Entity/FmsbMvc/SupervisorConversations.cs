using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class SupervisorConversations
    {
        [Key]
        public int SupervisorConversationId { get; set; }
        public int DepartmentId { get; set; }
        public int SupervisorClockNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string SupervisorName { get; set; }
        public int ShiftNameId { get; set; }
        public int? ClockNumber { get; set; }
        [StringLength(25)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        public int AssignmentsId { get; set; }
        public int EmployeeFeedbackId { get; set; }
        [Required]
        [StringLength(1000)]
        public string Comments { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.SupervisorConversations))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [ForeignKey(nameof(AssignmentsId))]
        [InverseProperty("SupervisorConversations")]
        public virtual Assignments Assignments { get; set; }
        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.SupervisorConversations))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(EmployeeFeedbackId))]
        [InverseProperty(nameof(EmployeeFeedbacks.SupervisorConversations))]
        public virtual EmployeeFeedbacks EmployeeFeedback { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.SupervisorConversations))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
