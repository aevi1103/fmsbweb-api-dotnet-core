using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FmsbwebCoreApi.Entity.FmsbMvc
{
    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            Area = new HashSet<Area>();
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
            Assignments = new HashSet<Assignments>();
            Block = new HashSet<Block>();
            BreakdownReason2 = new HashSet<BreakdownReason2>();
            CastingCell = new HashSet<CastingCell>();
            ClockNumber = new HashSet<ClockNumber>();
            Departments = new HashSet<Departments>();
            Die = new HashSet<Die>();
            DieTracker = new HashSet<DieTracker>();
            Discipline = new HashSet<Discipline>();
            DisciplineLevels = new HashSet<DisciplineLevels>();
            DisciplineTopic = new HashSet<DisciplineTopic>();
            DowntimeTriggerThreshold = new HashSet<DowntimeTriggerThreshold>();
            EmployeeJob = new HashSet<EmployeeJob>();
            EstimatedPm = new HashSet<EstimatedPm>();
            Forklift = new HashSet<Forklift>();
            ForkliftTask = new HashSet<ForkliftTask>();
            GageCall = new HashSet<GageCall>();
            HxHpushAlerts = new HashSet<HxHpushAlerts>();
            JobTitle = new HashSet<JobTitle>();
            Kpi = new HashSet<Kpi>();
            KpiByProgram1 = new HashSet<KpiByProgram1>();
            Kpitarget1 = new HashSet<Kpitarget1>();
            Machine = new HashSet<Machine>();
            MaintenanceAlert = new HashSet<MaintenanceAlert>();
            MaintenanceAlertLog = new HashSet<MaintenanceAlertLog>();
            MaintenanceBreakDownReason = new HashSet<MaintenanceBreakDownReason>();
            MaintenanceTech = new HashSet<MaintenanceTech>();
            OvertimeCategory = new HashSet<OvertimeCategory>();
            OvertimeLog = new HashSet<OvertimeLog>();
            PartNumber = new HashSet<PartNumber>();
            PreventiveMaintenance = new HashSet<PreventiveMaintenance>();
            ProcessTech = new HashSet<ProcessTech>();
            ProcessTechName = new HashSet<ProcessTechName>();
            Program = new HashSet<Program>();
            SubMachine = new HashSet<SubMachine>();
            SubMachinePm = new HashSet<SubMachinePm>();
            SupervisorConversations = new HashSet<SupervisorConversations>();
            Topics = new HashSet<Topics>();
            UserDepartments = new HashSet<UserDepartments>();
        }

        [Key]
        [StringLength(128)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [StringLength(256)]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Area> Area { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Assignments> Assignments { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Block> Block { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<BreakdownReason2> BreakdownReason2 { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<CastingCell> CastingCell { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<ClockNumber> ClockNumber { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Departments> Departments { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Die> Die { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<DieTracker> DieTracker { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Discipline> Discipline { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<DisciplineLevels> DisciplineLevels { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<DisciplineTopic> DisciplineTopic { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<DowntimeTriggerThreshold> DowntimeTriggerThreshold { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<EmployeeJob> EmployeeJob { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<EstimatedPm> EstimatedPm { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Forklift> Forklift { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<ForkliftTask> ForkliftTask { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<GageCall> GageCall { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<HxHpushAlerts> HxHpushAlerts { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<JobTitle> JobTitle { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Kpi> Kpi { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<KpiByProgram1> KpiByProgram1 { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Kpitarget1> Kpitarget1 { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Machine> Machine { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<MaintenanceAlert> MaintenanceAlert { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<MaintenanceBreakDownReason> MaintenanceBreakDownReason { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<MaintenanceTech> MaintenanceTech { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<OvertimeCategory> OvertimeCategory { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<OvertimeLog> OvertimeLog { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<PartNumber> PartNumber { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<PreventiveMaintenance> PreventiveMaintenance { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<ProcessTech> ProcessTech { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<ProcessTechName> ProcessTechName { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Program> Program { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<SubMachine> SubMachine { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<SubMachinePm> SubMachinePm { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<SupervisorConversations> SupervisorConversations { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<Topics> Topics { get; set; }
        [InverseProperty("ApplicationUser")]
        public virtual ICollection<UserDepartments> UserDepartments { get; set; }
    }
}
