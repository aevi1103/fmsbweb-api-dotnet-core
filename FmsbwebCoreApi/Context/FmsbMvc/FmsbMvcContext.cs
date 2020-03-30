using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.FmsbMvc;

namespace FmsbwebCoreApi.Context.FmsbMvc
{
    public partial class FmsbMvcContext : DbContext
    {
        public FmsbMvcContext()
        {
        }

        public FmsbMvcContext(DbContextOptions<FmsbMvcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Block> Block { get; set; }
        public virtual DbSet<BreakdownReason2> BreakdownReason2 { get; set; }
        public virtual DbSet<CastingCell> CastingCell { get; set; }
        public virtual DbSet<ClockNumber> ClockNumber { get; set; }
        public virtual DbSet<ClockNumbers> ClockNumbers { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Die> Die { get; set; }
        public virtual DbSet<DieTracker> DieTracker { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<DisciplineLevels> DisciplineLevels { get; set; }
        public virtual DbSet<DisciplineTopic> DisciplineTopic { get; set; }
        public virtual DbSet<DowntimeTriggerThreshold> DowntimeTriggerThreshold { get; set; }
        public virtual DbSet<EmailNotificationRecipients> EmailNotificationRecipients { get; set; }
        public virtual DbSet<EmployeeFeedbacks> EmployeeFeedbacks { get; set; }
        public virtual DbSet<EmployeeJob> EmployeeJob { get; set; }
        public virtual DbSet<EstimatedPm> EstimatedPm { get; set; }
        public virtual DbSet<Forklift> Forklift { get; set; }
        public virtual DbSet<ForkliftTask> ForkliftTask { get; set; }
        public virtual DbSet<ForkliftView> ForkliftView { get; set; }
        public virtual DbSet<GageCall> GageCall { get; set; }
        public virtual DbSet<GaugeCallType> GaugeCallType { get; set; }
        public virtual DbSet<GaugeStation> GaugeStation { get; set; }
        public virtual DbSet<HxHpushAlerts> HxHpushAlerts { get; set; }
        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<Kpi> Kpi { get; set; }
        public virtual DbSet<KpiByProgram> KpiByProgram { get; set; }
        public virtual DbSet<KpiByProgram1> KpiByProgram1 { get; set; }
        public virtual DbSet<KpiTarget> KpiTarget { get; set; }
        public virtual DbSet<Kpitarget1> Kpitarget1 { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MaintenanceAlert> MaintenanceAlert { get; set; }
        public virtual DbSet<MaintenanceAlertLog> MaintenanceAlertLog { get; set; }
        public virtual DbSet<MaintenanceAlertLog1> MaintenanceAlertLog1 { get; set; }
        public virtual DbSet<MaintenanceBreakDownReason> MaintenanceBreakDownReason { get; set; }
        public virtual DbSet<MaintenanceCallView> MaintenanceCallView { get; set; }
        public virtual DbSet<MaintenanceCallbox> MaintenanceCallbox { get; set; }
        public virtual DbSet<MaintenanceTech> MaintenanceTech { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<OperatorAutoCallbox> OperatorAutoCallbox { get; set; }
        public virtual DbSet<OperatorAutoDowntimeEmailRecipients> OperatorAutoDowntimeEmailRecipients { get; set; }
        public virtual DbSet<OperatorDowntime> OperatorDowntime { get; set; }
        public virtual DbSet<OperatorJobsAuto> OperatorJobsAuto { get; set; }
        public virtual DbSet<OverallCallbox> OverallCallbox { get; set; }
        public virtual DbSet<OvertimeCategory> OvertimeCategory { get; set; }
        public virtual DbSet<OvertimeLog> OvertimeLog { get; set; }
        public virtual DbSet<PartNumber> PartNumber { get; set; }
        public virtual DbSet<PreventiveMaintenance> PreventiveMaintenance { get; set; }
        public virtual DbSet<ProcessTech> ProcessTech { get; set; }
        public virtual DbSet<ProcessTechCallbox> ProcessTechCallbox { get; set; }
        public virtual DbSet<ProcessTechName> ProcessTechName { get; set; }
        public virtual DbSet<Entity.FmsbMvc.Program> Program { get; set; }
        public virtual DbSet<QualityTechCallbox> QualityTechCallbox { get; set; }
        public virtual DbSet<ShiftNames> ShiftNames { get; set; }
        public virtual DbSet<SpGetClockNumbersResult> SpGetClockNumbersResult { get; set; }
        public virtual DbSet<SubMachine> SubMachine { get; set; }
        public virtual DbSet<SubMachinePm> SubMachinePm { get; set; }
        public virtual DbSet<SupervisorConversations> SupervisorConversations { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }
        public virtual DbSet<UserDepartments> UserDepartments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
////                optionsBuilder.UseSqlServer("Data Source=SBNDINMS002;Initial Catalog=FMSB_HR;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder 
                            ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.Entity<Area>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Area)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_FmsbWeb.Area_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<Assignments>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.TopicsId)
                    .HasName("IX_TopicsId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.Assignments_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Assignments_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.Topics)
                    .WithMany(p => p.Assignments)
                    .HasForeignKey(d => d.TopicsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.Assignments_dbo.Topics_TopicsId");
            });

            modelBuilder.Entity<Block>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.PartNumberId)
                    .HasName("IX_PartNumberId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Block)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_DieStatus.Block_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.PartNumber)
                    .WithMany(p => p.Block)
                    .HasForeignKey(d => d.PartNumberId)
                    .HasConstraintName("FK_DieStatus.Block_DieStatus.PartNumber_PartNumberId");
            });

            modelBuilder.Entity<BreakdownReason2>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.MaintenanceBreakDownReasonId)
                    .HasName("IX_MaintenanceBreakDownReasonId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.BreakdownReason2)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.BreakdownReason2_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.MaintenanceBreakDownReason)
                    .WithMany(p => p.BreakdownReason2)
                    .HasForeignKey(d => d.MaintenanceBreakDownReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.BreakdownReason2_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId");
            });

            modelBuilder.Entity<CastingCell>(entity =>
            {
                entity.HasKey(e => e.CastingCellName)
                    .HasName("PK_DieStatus.CastingCell");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.CastingCellName).ValueGeneratedNever();

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.CastingCell)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_DieStatus.CastingCell_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<ClockNumber>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.ClockNumberId).ValueGeneratedNever();

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ClockNumber)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Overtime.ClockNumber_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<ClockNumbers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClockNumbers");

                entity.Property(e => e.Dept).IsUnicode(false);
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_dbo.Departments");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.Departments_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<Die>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.BlockId)
                    .HasName("IX_BlockId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Die)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_DieStatus.Die_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Block)
                    .WithMany(p => p.Die)
                    .HasForeignKey(d => d.BlockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DieStatus.Die_DieStatus.Block_BlockId");
            });

            modelBuilder.Entity<DieTracker>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.CastingCellName)
                    .HasName("IX_CastingCellName");

                entity.HasIndex(e => e.DieId)
                    .HasName("IX_DieId");

                entity.HasIndex(e => e.PartNumberId)
                    .HasName("IX_PartNumberId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.DieTracker)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_DieStatus.DieTracker_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.CastingCellNameNavigation)
                    .WithMany(p => p.DieTracker)
                    .HasForeignKey(d => d.CastingCellName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DieStatus.DieTracker_DieStatus.CastingCell_CastingCellName");

                entity.HasOne(d => d.Die)
                    .WithMany(p => p.DieTracker)
                    .HasForeignKey(d => d.DieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DieStatus.DieTracker_DieStatus.Die_DieId");

                entity.HasOne(d => d.PartNumber)
                    .WithMany(p => p.DieTracker)
                    .HasForeignKey(d => d.PartNumberId)
                    .HasConstraintName("FK_DieStatus.DieTracker_DieStatus.PartNumber_PartNumberId");
            });

            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.HasKey(e => e.DisciplineLogId)
                    .HasName("PK_Discipline.Discipline");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.DisciplineLevelsId)
                    .HasName("IX_DisciplineLevelsId");

                entity.HasIndex(e => e.DisciplineTopicId)
                    .HasName("IX_DisciplineTopicId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.SupervisorName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Discipline.Discipline_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discipline.Discipline_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.DisciplineLevels)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.DisciplineLevelsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discipline.Discipline_Discipline.DisciplineLevels_DisciplineLevelsId");

                entity.HasOne(d => d.DisciplineTopic)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.DisciplineTopicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discipline.Discipline_Discipline.DisciplineTopic_DisciplineTopicId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.Discipline)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discipline.Discipline_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<DisciplineLevels>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.Levels).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.DisciplineLevels)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Discipline.DisciplineLevels_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<DisciplineTopic>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.Topic).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.DisciplineTopic)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Discipline.DisciplineTopic_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<DowntimeTriggerThreshold>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.DowntimeTriggerThreshold)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Iconics.DowntimeTriggerThreshold_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<EmailNotificationRecipients>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK_dbo.EmailNotificationRecipients");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmailNotificationRecipients)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.EmailNotificationRecipients_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.EmailNotificationRecipients)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.EmailNotificationRecipients_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<EmployeeFeedbacks>(entity =>
            {
                entity.HasKey(e => e.EmployeeFeedbackId)
                    .HasName("PK_dbo.EmployeeFeedbacks");

                entity.Property(e => e.Feedback).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeJob>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.ClockNumberId)
                    .HasName("IX_ClockNumberId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.JobTitleId)
                    .HasName("IX_JobTitleId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.EmployeeJob)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Overtime.EmployeeJob_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.ClockNumber)
                    .WithMany(p => p.EmployeeJob)
                    .HasForeignKey(d => d.ClockNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.EmployeeJob_Overtime.ClockNumber_ClockNumberId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeJob)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.EmployeeJob_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.EmployeeJob)
                    .HasForeignKey(d => d.JobTitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.EmployeeJob_Overtime.JobTitle_JobTitleId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.EmployeeJob)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.EmployeeJob_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<EstimatedPm>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.EstimatedPm)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.EstimatedPM_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.EstimatedPm)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.EstimatedPM_Maintenance.Machine_MachineId");
            });

            modelBuilder.Entity<Forklift>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.ForkliftTaskId)
                    .HasName("IX_ForkliftTaskId");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Forklift)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.Forklift_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.ForkliftTask)
                    .WithMany(p => p.Forklift)
                    .HasForeignKey(d => d.ForkliftTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.Forklift_Alert.ForkliftTask_ForkliftTaskId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Forklift)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.Forklift_Maintenance.Machine_MachineId");
            });

            modelBuilder.Entity<ForkliftTask>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ForkliftTask)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.ForkliftTask_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ForkliftTask)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.ForkliftTask_dbo.Departments_DepartmentId");
            });

            modelBuilder.Entity<ForkliftView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("forklift_view");

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<GageCall>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.GaugeCallTypeId)
                    .HasName("IX_GaugeCallTypeId");

                entity.HasIndex(e => e.GaugeStationId)
                    .HasName("IX_GaugeStationId");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasIndex(e => e.OperatorDowntimeId)
                    .HasName("IX_OperatorDowntimeId");

                entity.Property(e => e.RequestedBy).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.GageCall)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.GageCall_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.GaugeCallType)
                    .WithMany(p => p.GageCall)
                    .HasForeignKey(d => d.GaugeCallTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.GageCall_Gauge.GaugeCallType_GaugeCallTypeId");

                entity.HasOne(d => d.GaugeStation)
                    .WithMany(p => p.GageCall)
                    .HasForeignKey(d => d.GaugeStationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.GageCall_Gauge.GaugeStation_GaugeStationId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.GageCall)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.GageCall_Maintenance.Machine_MachineId");

                entity.HasOne(d => d.OperatorDowntime)
                    .WithMany(p => p.GageCall)
                    .HasForeignKey(d => d.OperatorDowntimeId)
                    .HasConstraintName("FK_Alert.GageCall_Iconics.OperatorDowntime_OperatorDowntimeId");
            });

            modelBuilder.Entity<HxHpushAlerts>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.HxHpushAlerts)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_HxH.HxHPushAlerts_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.JobTitle)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Overtime.JobTitle_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.JobTitle)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.JobTitle_dbo.Departments_DepartmentId");
            });

            modelBuilder.Entity<Kpi>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.Kpiname).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Kpi)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_FmsbWeb.KPI_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<KpiByProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_by_program");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.Kpiname).IsUnicode(false);
            });

            modelBuilder.Entity<KpiByProgram1>(entity =>
            {
                entity.HasKey(e => e.KpiByProgramId)
                    .HasName("PK_FmsbWeb.KpiByProgram");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_AreaId");

                entity.HasIndex(e => e.Kpiid)
                    .HasName("IX_KPIId");

                entity.HasIndex(e => e.ProgramId)
                    .HasName("IX_ProgramId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.KpiByProgram1)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_FmsbWeb.KpiByProgram_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.KpiByProgram1)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FmsbWeb.KpiByProgram_FmsbWeb.Area_AreaId");

                entity.HasOne(d => d.Kpi)
                    .WithMany(p => p.KpiByProgram1)
                    .HasForeignKey(d => d.Kpiid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FmsbWeb.KpiByProgram_FmsbWeb.KPI_KPIId");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.KpiByProgram1)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FmsbWeb.KpiByProgram_FmsbWeb.Program_ProgramId");
            });

            modelBuilder.Entity<KpiTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Target");

                entity.Property(e => e.AreaName).IsUnicode(false);

                entity.Property(e => e.Kpiname).IsUnicode(false);
            });

            modelBuilder.Entity<Kpitarget1>(entity =>
            {
                entity.HasKey(e => e.KpitargetId)
                    .HasName("PK_FmsbWeb.KPITarget");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.AreaId)
                    .HasName("IX_AreaId");

                entity.HasIndex(e => e.Kpiid)
                    .HasName("IX_KPIId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Kpitarget1)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_FmsbWeb.KPITarget_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Kpitarget1)
                    .HasForeignKey(d => d.AreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FmsbWeb.KPITarget_FmsbWeb.Area_AreaId");

                entity.HasOne(d => d.Kpi)
                    .WithMany(p => p.Kpitarget1)
                    .HasForeignKey(d => d.Kpiid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FmsbWeb.KPITarget_FmsbWeb.KPI_KPIId");
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.Machine_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Machine)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.Machine_dbo.Departments_DepartmentId");
            });

            modelBuilder.Entity<MaintenanceAlert>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.BreakdownReason2Id)
                    .HasName("IX_BreakdownReason2Id");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasIndex(e => e.MaintenanceBreakDownReasonId)
                    .HasName("IX_MaintenanceBreakDownReasonId");

                entity.HasIndex(e => e.OperatorDowntimeId)
                    .HasName("IX_OperatorDowntimeId");

                entity.HasIndex(e => e.SubMachineId)
                    .HasName("IX_SubMachineId");

                entity.Property(e => e.ClockNumberStr).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.BreakdownReason2)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.BreakdownReason2Id)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_Alert.BreakdownReason2_BreakdownReason2Id");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_Maintenance.Machine_MachineId");

                entity.HasOne(d => d.MaintenanceBreakDownReason)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.MaintenanceBreakDownReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId");

                entity.HasOne(d => d.OperatorDowntime)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.OperatorDowntimeId)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_Iconics.OperatorDowntime_OperatorDowntimeId");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.MaintenanceAlert)
                    .HasForeignKey(d => d.SubMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlert_Maintenance.SubMachine_SubMachineId");
            });

            modelBuilder.Entity<MaintenanceAlertLog>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.BreakdownReason2Id)
                    .HasName("IX_BreakdownReason2Id");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasIndex(e => e.MaintenanceBreakDownReasonId)
                    .HasName("IX_MaintenanceBreakDownReasonId");

                entity.HasIndex(e => e.SubMachineId)
                    .HasName("IX_SubMachineId");

                entity.Property(e => e.ClockNumberStr).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.MaintenanceAlertLog)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.MaintenanceAlertLog_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.BreakdownReason2)
                    .WithMany(p => p.MaintenanceAlertLog)
                    .HasForeignKey(d => d.BreakdownReason2Id)
                    .HasConstraintName("FK_Alert.MaintenanceAlertLog_Alert.BreakdownReason2_BreakdownReason2Id");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.MaintenanceAlertLog)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlertLog_Maintenance.Machine_MachineId");

                entity.HasOne(d => d.MaintenanceBreakDownReason)
                    .WithMany(p => p.MaintenanceAlertLog)
                    .HasForeignKey(d => d.MaintenanceBreakDownReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlertLog_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.MaintenanceAlertLog)
                    .HasForeignKey(d => d.SubMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.MaintenanceAlertLog_Maintenance.SubMachine_SubMachineId");
            });

            modelBuilder.Entity<MaintenanceAlertLog1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaintenanceAlertLog");

                entity.Property(e => e.ClockNumberStr).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.StatusText).IsUnicode(false);

                entity.Property(e => e.SubMachineName).IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceBreakDownReason>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.MaintenanceBreakDownReason)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.MaintenanceBreakDownReason_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.MaintenanceBreakDownReason)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Alert.MaintenanceBreakDownReason_dbo.Departments_DepartmentId");
            });

            modelBuilder.Entity<MaintenanceCallView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaintenanceCallView");

                entity.Property(e => e.ClockNumberStr).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceCallbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MaintenanceCallbox");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceTech>(entity =>
            {
                entity.HasKey(e => e.ClockNumber)
                    .HasName("PK_Maintenance.MaintenanceTech");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.Property(e => e.ClockNumber).ValueGeneratedNever();

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.MaintenanceTech)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.MaintenanceTech_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.MaintenanceTech)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.MaintenanceTech_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<OperatorAutoCallbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OperatorAutoCallbox");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.MaintenanceComment).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<OperatorDowntime>(entity =>
            {
                entity.HasIndex(e => e.BreakdownReason2Id)
                    .HasName("IX_BreakdownReason2Id");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasIndex(e => e.MaintenanceBreakDownReasonId)
                    .HasName("IX_MaintenanceBreakDownReasonId");

                entity.HasIndex(e => e.SubMachineId)
                    .HasName("IX_SubMachineId");

                entity.HasOne(d => d.BreakdownReason2)
                    .WithMany(p => p.OperatorDowntime)
                    .HasForeignKey(d => d.BreakdownReason2Id)
                    .HasConstraintName("FK_Iconics.OperatorDowntime_Alert.BreakdownReason2_BreakdownReason2Id");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.OperatorDowntime)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_Iconics.OperatorDowntime_Maintenance.Machine_MachineId");

                entity.HasOne(d => d.MaintenanceBreakDownReason)
                    .WithMany(p => p.OperatorDowntime)
                    .HasForeignKey(d => d.MaintenanceBreakDownReasonId)
                    .HasConstraintName("FK_Iconics.OperatorDowntime_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.OperatorDowntime)
                    .HasForeignKey(d => d.SubMachineId)
                    .HasConstraintName("FK_Iconics.OperatorDowntime_Maintenance.SubMachine_SubMachineId");
            });

            modelBuilder.Entity<OperatorJobsAuto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OperatorJobsAuto");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SubMachineName).IsUnicode(false);
            });

            modelBuilder.Entity<OverallCallbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OverallCallbox");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<OvertimeCategory>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.OvertimeCategory)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Overtime.OvertimeCategory_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<OvertimeLog>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.ClockNumberId)
                    .HasName("IX_ClockNumberId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.OvertimeCategoryId)
                    .HasName("IX_OvertimeCategoryId");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Supervisor).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.OvertimeLog)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Overtime.OvertimeLog_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.ClockNumber)
                    .WithMany(p => p.OvertimeLog)
                    .HasForeignKey(d => d.ClockNumberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.OvertimeLog_Overtime.ClockNumber_ClockNumberId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.OvertimeLog)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.OvertimeLog_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.OvertimeCategory)
                    .WithMany(p => p.OvertimeLog)
                    .HasForeignKey(d => d.OvertimeCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Overtime.OvertimeLog_Overtime.OvertimeCategory_OvertimeCategoryId");
            });

            modelBuilder.Entity<PartNumber>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.PartNumber)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_DieStatus.PartNumber_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<PreventiveMaintenance>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.PreventiveMaintenance)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.PreventiveMaintenance_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.PreventiveMaintenance)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.PreventiveMaintenance_Maintenance.Machine_MachineId");
            });

            modelBuilder.Entity<ProcessTech>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.BreakdownReason2Id)
                    .HasName("IX_BreakdownReason2Id");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.HasIndex(e => e.MaintenanceBreakDownReasonId)
                    .HasName("IX_MaintenanceBreakDownReasonId");

                entity.HasIndex(e => e.OperatorDowntimeId)
                    .HasName("IX_OperatorDowntimeId");

                entity.HasIndex(e => e.SubMachineId)
                    .HasName("IX_SubMachineId");

                entity.Property(e => e.ClockNumberStr).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Alert.ProcessTech_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.BreakdownReason2)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.BreakdownReason2Id)
                    .HasConstraintName("FK_Alert.ProcessTech_Alert.BreakdownReason2_BreakdownReason2Id");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.ProcessTech_Maintenance.Machine_MachineId");

                entity.HasOne(d => d.MaintenanceBreakDownReason)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.MaintenanceBreakDownReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.ProcessTech_Alert.MaintenanceBreakDownReason_MaintenanceBreakDownReasonId");

                entity.HasOne(d => d.OperatorDowntime)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.OperatorDowntimeId)
                    .HasConstraintName("FK_Alert.ProcessTech_Iconics.OperatorDowntime_OperatorDowntimeId");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.ProcessTech)
                    .HasForeignKey(d => d.SubMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Alert.ProcessTech_Maintenance.SubMachine_SubMachineId");
            });

            modelBuilder.Entity<ProcessTechCallbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProcessTechCallbox");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<ProcessTechName>(entity =>
            {
                entity.HasKey(e => e.ClockNumber)
                    .HasName("PK_ProcessTechs.ProcessTechName");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.Property(e => e.ClockNumber).ValueGeneratedNever();

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.ProcessTechName)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_ProcessTechs.ProcessTechName_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.ProcessTechName)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessTechs.ProcessTechName_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.ProcessTechName)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessTechs.ProcessTechName_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<Entity.FmsbMvc.Program>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Program)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_FmsbWeb.Program_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<QualityTechCallbox>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QualityTechCallbox");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<ShiftNames>(entity =>
            {
                entity.HasKey(e => e.ShiftNameId)
                    .HasName("PK_dbo.ShiftNames");

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<SubMachine>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.MachineId)
                    .HasName("IX_MachineId");

                entity.Property(e => e.SubMachineName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.SubMachine)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.SubMachine_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.SubMachine)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.SubMachine_Maintenance.Machine_MachineId");
            });

            modelBuilder.Entity<SubMachinePm>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.PreventiveMaintenanceId)
                    .HasName("IX_PreventiveMaintenanceId");

                entity.HasIndex(e => e.SubMachineId)
                    .HasName("IX_SubMachineId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.SubMachinePm)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_Maintenance.SubMachinePM_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.PreventiveMaintenance)
                    .WithMany(p => p.SubMachinePm)
                    .HasForeignKey(d => d.PreventiveMaintenanceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.SubMachinePM_Maintenance.PreventiveMaintenance_PreventiveMaintenanceId");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.SubMachinePm)
                    .HasForeignKey(d => d.SubMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Maintenance.SubMachinePM_Maintenance.SubMachine_SubMachineId");
            });

            modelBuilder.Entity<SupervisorConversations>(entity =>
            {
                entity.HasKey(e => e.SupervisorConversationId)
                    .HasName("PK_dbo.SupervisorConversations");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.AssignmentsId)
                    .HasName("IX_AssignmentsId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasIndex(e => e.EmployeeFeedbackId)
                    .HasName("IX_EmployeeFeedbackId");

                entity.HasIndex(e => e.ShiftNameId)
                    .HasName("IX_ShiftNameId");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.SupervisorName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.SupervisorConversations)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.SupervisorConversations_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Assignments)
                    .WithMany(p => p.SupervisorConversations)
                    .HasForeignKey(d => d.AssignmentsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupervisorConversations_dbo.Assignments_AssignmentsId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SupervisorConversations)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupervisorConversations_dbo.Departments_DepartmentId");

                entity.HasOne(d => d.EmployeeFeedback)
                    .WithMany(p => p.SupervisorConversations)
                    .HasForeignKey(d => d.EmployeeFeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupervisorConversations_dbo.EmployeeFeedbacks_EmployeeFeedbackId");

                entity.HasOne(d => d.ShiftName)
                    .WithMany(p => p.SupervisorConversations)
                    .HasForeignKey(d => d.ShiftNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.SupervisorConversations_dbo.ShiftNames_ShiftNameId");
            });

            modelBuilder.Entity<Topics>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.Property(e => e.TopicName).IsUnicode(false);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.Topics)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.Topics_dbo.AspNetUsers_ApplicationUserId");
            });

            modelBuilder.Entity<UserDepartments>(entity =>
            {
                entity.HasKey(e => e.UserDepartmentId)
                    .HasName("PK_dbo.UserDepartments");

                entity.HasIndex(e => e.ApplicationUserId)
                    .HasName("IX_ApplicationUserId");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("IX_DepartmentId");

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.UserDepartments)
                    .HasForeignKey(d => d.ApplicationUserId)
                    .HasConstraintName("FK_dbo.UserDepartments_dbo.AspNetUsers_ApplicationUserId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.UserDepartments)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.UserDepartments_dbo.Departments_DepartmentId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
