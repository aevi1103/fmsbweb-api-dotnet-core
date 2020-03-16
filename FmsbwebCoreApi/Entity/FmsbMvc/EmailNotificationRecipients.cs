using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class EmailNotificationRecipients
    {
        [Key]
        [StringLength(500)]
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public int ShiftNameId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty(nameof(Departments.EmailNotificationRecipients))]
        public virtual Departments Department { get; set; }
        [ForeignKey(nameof(ShiftNameId))]
        [InverseProperty(nameof(ShiftNames.EmailNotificationRecipients))]
        public virtual ShiftNames ShiftName { get; set; }
    }
}
