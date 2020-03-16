using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class Departments
    {
        public Departments()
        {
            Assignments = new HashSet<Assignments>();
            Discipline = new HashSet<Discipline>();
            EmailNotificationRecipients = new HashSet<EmailNotificationRecipients>();
            EmployeeJob = new HashSet<EmployeeJob>();
            ForkliftTask = new HashSet<ForkliftTask>();
            JobTitle = new HashSet<JobTitle>();
            Machine = new HashSet<Machine>();
            MaintenanceBreakDownReason = new HashSet<MaintenanceBreakDownReason>();
            OvertimeLog = new HashSet<OvertimeLog>();
            ProcessTechName = new HashSet<ProcessTechName>();
            SupervisorConversations = new HashSet<SupervisorConversations>();
            UserDepartments = new HashSet<UserDepartments>();
        }

        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Stamp { get; set; }
        [StringLength(128)]
        public string ApplicationUserId { get; set; }

        [ForeignKey(nameof(ApplicationUserId))]
        [InverseProperty(nameof(AspNetUsers.Departments))]
        public virtual AspNetUsers ApplicationUser { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Assignments> Assignments { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Discipline> Discipline { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<EmailNotificationRecipients> EmailNotificationRecipients { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<ForkliftTask> ForkliftTask { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<JobTitle> JobTitle { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<Machine> Machine { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<MaintenanceBreakDownReason> MaintenanceBreakDownReason { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<OvertimeLog> OvertimeLog { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<ProcessTechName> ProcessTechName { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<SupervisorConversations> SupervisorConversations { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<UserDepartments> UserDepartments { get; set; }
    }
}
