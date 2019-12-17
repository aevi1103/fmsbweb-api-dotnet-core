using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.FmsbQuality;

namespace FmsbwebCoreApi.Context.FmsbQuality
{
    public partial class fmsbQualityContext : DbContext
    {
        public fmsbQualityContext()
        {
        }

        public fmsbQualityContext(DbContextOptions<fmsbQualityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AcknowledgmentView> AcknowledgmentView { get; set; }
        public virtual DbSet<AcknowledgmentView2> AcknowledgmentView2 { get; set; }
        public virtual DbSet<AdjustMinNomMax> AdjustMinNomMax { get; set; }
        public virtual DbSet<CharacteristicsView> CharacteristicsView { get; set; }
        public virtual DbSet<CheckSheetCharacteristics> CheckSheetCharacteristics { get; set; }
        public virtual DbSet<CheckSheetCharacteristicsLog> CheckSheetCharacteristicsLog { get; set; }
        public virtual DbSet<ChecksheetLogin> ChecksheetLogin { get; set; }
        public virtual DbSet<ChecksheetResults> ChecksheetResults { get; set; }
        public virtual DbSet<ChecksheetType> ChecksheetType { get; set; }
        public virtual DbSet<CommentList> CommentList { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<CustomerComplaint> CustomerComplaint { get; set; }
        public virtual DbSet<DistinctExpectedTypes> DistinctExpectedTypes { get; set; }
        public virtual DbSet<FrequencyList> FrequencyList { get; set; }
        public virtual DbSet<FrequencyMap> FrequencyMap { get; set; }
        public virtual DbSet<Gauges> Gauges { get; set; }
        public virtual DbSet<Machine> Machine { get; set; }
        public virtual DbSet<MachineFrequency> MachineFrequency { get; set; }
        public virtual DbSet<MachineGaugeLog> MachineGaugeLog { get; set; }
        public virtual DbSet<MachineGaugeLogDeleted> MachineGaugeLogDeleted { get; set; }
        public virtual DbSet<MachineGaugeLogNotifications> MachineGaugeLogNotifications { get; set; }
        public virtual DbSet<QaEmails> QaEmails { get; set; }
        public virtual DbSet<QaReports> QaReports { get; set; }
        public virtual DbSet<QualityAlert> QualityAlert { get; set; }
        public virtual DbSet<QualityAlertAcknowledgement> QualityAlertAcknowledgement { get; set; }
        public virtual DbSet<QualityAlertAttachments> QualityAlertAttachments { get; set; }
        public virtual DbSet<RemoveCharacteristics> RemoveCharacteristics { get; set; }
        public virtual DbSet<ResultsView> ResultsView { get; set; }
        public virtual DbSet<Resultview2> Resultview2 { get; set; }
        public virtual DbSet<SubMachine> SubMachine { get; set; }
        public virtual DbSet<TableHeaderValues> TableHeaderValues { get; set; }
        public virtual DbSet<TableHeaderViewList> TableHeaderViewList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SBNDINMS002;Initial Catalog=FMSB_Quality;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AcknowledgmentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("acknowledgmentView");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.Feedback).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<AcknowledgmentView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("acknowledgmentView2");

                entity.Property(e => e.AlertType).IsUnicode(false);

                entity.Property(e => e.BreakPointIdentifier).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.IssueOriginatingProcess).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.QaNum).IsUnicode(false);

                entity.Property(e => e.QaOriginator).IsUnicode(false);

                entity.Property(e => e.QualityAlertDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SuspectDateCode).IsUnicode(false);
            });

            modelBuilder.Entity<AdjustMinNomMax>(entity =>
            {
                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.Checksheet).IsUnicode(false);
            });

            modelBuilder.Entity<CharacteristicsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CharacteristicsView");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Gauge).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.NumberRef).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.WordValue).IsUnicode(false);
            });

            modelBuilder.Entity<CheckSheetCharacteristics>(entity =>
            {
                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Gauge).IsUnicode(false);

                entity.Property(e => e.NumberRef).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.WordValue).IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.CheckSheetCharacteristics)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckSheetCharacteristics_Machine");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.CheckSheetCharacteristics)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckSheetCharacteristics_checksheetType");
            });

            modelBuilder.Entity<CheckSheetCharacteristicsLog>(entity =>
            {
                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Gauge).IsUnicode(false);

                entity.Property(e => e.NumberRef).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.TriggerStatus).IsUnicode(false);

                entity.Property(e => e.WordValue).IsUnicode(false);
            });

            modelBuilder.Entity<ChecksheetLogin>(entity =>
            {
                entity.Property(e => e.Machinist).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.HasOne(d => d.ChecksheetType)
                    .WithMany(p => p.ChecksheetLogin)
                    .HasForeignKey(d => d.ChecksheetTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checksheet_Login_checksheetType");
            });

            modelBuilder.Entity<ChecksheetResults>(entity =>
            {
                entity.Property(e => e.ChecksheetName).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.HasOne(d => d.Characteristics)
                    .WithMany(p => p.ChecksheetResults)
                    .HasForeignKey(d => d.CharacteristicsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checksheet_Results_CheckSheetCharacteristics");

                entity.HasOne(d => d.ChecksheetLogin)
                    .WithMany(p => p.ChecksheetResults)
                    .HasForeignKey(d => d.ChecksheetLoginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checksheet_Results_Checksheet_Login");

                entity.HasOne(d => d.Frequency)
                    .WithMany(p => p.ChecksheetResults)
                    .HasForeignKey(d => d.FrequencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checksheet_Results_Machine_Frequency");

                entity.HasOne(d => d.SubMachine)
                    .WithMany(p => p.ChecksheetResults)
                    .HasForeignKey(d => d.SubMachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Checksheet_Results_SubMachine");
            });

            modelBuilder.Entity<ChecksheetType>(entity =>
            {
                entity.Property(e => e.ChecksheetType1).IsUnicode(false);
            });

            modelBuilder.Entity<CommentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("commentList");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SubMachine).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerComplaint>(entity =>
            {
                entity.Property(e => e.CriticalIssue).IsUnicode(false);

                entity.Property(e => e.NewIssue).IsUnicode(false);

                entity.Property(e => e.PirCom).IsUnicode(false);

                entity.Property(e => e.PrrCom).IsUnicode(false);

                entity.Property(e => e.QrCom).IsUnicode(false);
            });

            modelBuilder.Entity<DistinctExpectedTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("distinctExpectedTypes");

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);
            });

            modelBuilder.Entity<FrequencyList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("frequencyList");

                entity.Property(e => e.ChecksheetType).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Map).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<FrequencyMap>(entity =>
            {
                entity.Property(e => e.Checksheet).IsUnicode(false);

                entity.Property(e => e.Map).IsUnicode(false);
            });

            modelBuilder.Entity<Gauges>(entity =>
            {
                entity.Property(e => e.Gauge).IsUnicode(false);
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.Property(e => e.Machine1).IsUnicode(false);
            });

            modelBuilder.Entity<MachineFrequency>(entity =>
            {
                entity.Property(e => e.Map).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGaugeLog>(entity =>
            {
                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.Fix).IsUnicode(false);

                entity.Property(e => e.FixReason).IsUnicode(false);

                entity.Property(e => e.GageStation).IsUnicode(false);

                entity.Property(e => e.GageType).IsUnicode(false);

                entity.Property(e => e.Initials).IsUnicode(false);

                entity.Property(e => e.LineWeeklyMaint).IsUnicode(false);

                entity.Property(e => e.OtherComments).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Problem).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGaugeLogDeleted>(entity =>
            {
                entity.HasKey(e => e.IdPk)
                    .HasName("PK__MachineG__0148A341571DF1D5");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.Fix).IsUnicode(false);

                entity.Property(e => e.FixReason).IsUnicode(false);

                entity.Property(e => e.GageStation).IsUnicode(false);

                entity.Property(e => e.GageType).IsUnicode(false);

                entity.Property(e => e.Initials).IsUnicode(false);

                entity.Property(e => e.LineWeeklyMaint).IsUnicode(false);

                entity.Property(e => e.OtherComments).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Problem).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGaugeLogNotifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.DaysOfOccurence).IsUnicode(false);

                entity.Property(e => e.Recipients).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<QaEmails>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<QaReports>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("QaReports");

                entity.Property(e => e.AlertType).IsUnicode(false);

                entity.Property(e => e.BreakPointIdentifier).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IssueOriginatingProcess).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.QaNum).IsUnicode(false);

                entity.Property(e => e.QaOriginator).IsUnicode(false);

                entity.Property(e => e.QualityAlertDesc).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.SuspectDateCode).IsUnicode(false);
            });

            modelBuilder.Entity<QualityAlert>(entity =>
            {
                entity.Property(e => e.AlertType).IsUnicode(false);

                entity.Property(e => e.BreakPointIdentifier).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.IssueOriginatingProcess).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.QaOriginator).IsUnicode(false);

                entity.Property(e => e.QualityAlertDesc).IsUnicode(false);

                entity.Property(e => e.SuspectDateCode).IsUnicode(false);
            });

            modelBuilder.Entity<QualityAlertAcknowledgement>(entity =>
            {
                entity.Property(e => e.Feedback).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.Workcenter).IsUnicode(false);
            });

            modelBuilder.Entity<QualityAlertAttachments>(entity =>
            {
                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);
            });

            modelBuilder.Entity<ResultsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("resultsView");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.ChecksheetMach).IsUnicode(false);

                entity.Property(e => e.ChecksheetQuality).IsUnicode(false);

                entity.Property(e => e.ChecksheetType).IsUnicode(false);

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);

                entity.Property(e => e.Freq).IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Gauge).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.NumberRef).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SubMachine).IsUnicode(false);
            });

            modelBuilder.Entity<Resultview2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("resultview2");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.Checksheet).IsUnicode(false);

                entity.Property(e => e.ExpectedValueType).IsUnicode(false);

                entity.Property(e => e.Freq).IsUnicode(false);

                entity.Property(e => e.Frequency).IsUnicode(false);

                entity.Property(e => e.Gauge).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.NumberRef).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SubMachine).IsUnicode(false);
            });

            modelBuilder.Entity<SubMachine>(entity =>
            {
                entity.Property(e => e.SubMachine1).IsUnicode(false);
            });

            modelBuilder.Entity<TableHeaderValues>(entity =>
            {
                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<TableHeaderViewList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TableHeaderViewList");

                entity.Property(e => e.ChecksheetType).IsUnicode(false);

                entity.Property(e => e.HeaderValue).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SubMachine).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
