using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class ShiftNames
    {
        public ShiftNames()
        {
            Discipline = new HashSet<Discipline>();
            EmailNotificationRecipients = new HashSet<EmailNotificationRecipients>();
            EmployeeJob = new HashSet<EmployeeJob>();
            MaintenanceTech = new HashSet<MaintenanceTech>();
            ProcessTechName = new HashSet<ProcessTechName>();
            SupervisorConversations = new HashSet<SupervisorConversations>();
        }

        [Key]
        public int ShiftNameId { get; set; }
        [StringLength(1)]
        public string Shift { get; set; }

        [InverseProperty("ShiftName")]
        public virtual ICollection<Discipline> Discipline { get; set; }
        [InverseProperty("ShiftName")]
        public virtual ICollection<EmailNotificationRecipients> EmailNotificationRecipients { get; set; }
        [InverseProperty("ShiftName")]
        public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
        [InverseProperty("ShiftName")]
        public virtual ICollection<MaintenanceTech> MaintenanceTech { get; set; }
        [InverseProperty("ShiftName")]
        public virtual ICollection<ProcessTechName> ProcessTechName { get; set; }
        [InverseProperty("ShiftName")]
        public virtual ICollection<SupervisorConversations> SupervisorConversations { get; set; }
    }
}
