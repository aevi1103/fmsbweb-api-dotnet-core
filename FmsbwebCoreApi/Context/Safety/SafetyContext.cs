using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Safety;

namespace FmsbwebCoreApi.Context.Safety
{
    public partial class SafetyContext : DbContext
    {
        public SafetyContext()
        {
        }

        public SafetyContext(DbContextOptions<SafetyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllIncidentsYear> AllIncidentsYear { get; set; }
        public virtual DbSet<AllIncidentsYearMonth> AllIncidentsYearMonth { get; set; }
        public virtual DbSet<AttachView> AttachView { get; set; }
        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<AuditIncidenceDeleted> AuditIncidenceDeleted { get; set; }
        public virtual DbSet<BodyPart> BodyPart { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<EmailNotificationLog> EmailNotificationLog { get; set; }
        public virtual DbSet<EmailsNotiRecipients> EmailsNotiRecipients { get; set; }
        public virtual DbSet<GenerateStackedChart> GenerateStackedChart { get; set; }
        public virtual DbSet<GetLaborHours> GetLaborHours { get; set; }
        public virtual DbSet<Incidence> Incidence { get; set; }
        public virtual DbSet<IncidenceHistory> IncidenceHistory { get; set; }
        public virtual DbSet<IncidentRates> IncidentRates { get; set; }
        public virtual DbSet<IncidentRatesNum> IncidentRatesNum { get; set; }
        public virtual DbSet<IncidentRatesWithLossTime> IncidentRatesWithLossTime { get; set; }
        public virtual DbSet<IncidentRatesWithLossTimeRates> IncidentRatesWithLossTimeRates { get; set; }
        public virtual DbSet<IncidentsByBodyPartYear> IncidentsByBodyPartYear { get; set; }
        public virtual DbSet<IncidentsByBodyPartYearMonth> IncidentsByBodyPartYearMonth { get; set; }
        public virtual DbSet<IncidentsByDeptYear> IncidentsByDeptYear { get; set; }
        public virtual DbSet<IncidentsByDeptYearMonth> IncidentsByDeptYearMonth { get; set; }
        public virtual DbSet<IncidentsByShiftYear> IncidentsByShiftYear { get; set; }
        public virtual DbSet<IncidentsByShiftYearMonth> IncidentsByShiftYearMonth { get; set; }
        public virtual DbSet<IncidentsBycausationYear> IncidentsBycausationYear { get; set; }
        public virtual DbSet<IncidentsBycausationYearMonth> IncidentsBycausationYearMonth { get; set; }
        public virtual DbSet<Injuries> Injuries { get; set; }
        public virtual DbSet<InjuryStat> InjuryStat { get; set; }
        public virtual DbSet<ManHours> ManHours { get; set; }
        public virtual DbSet<MonthsReference> MonthsReference { get; set; }
        public virtual DbSet<RatesChartView> RatesChartView { get; set; }
        public virtual DbSet<RecordableInjuriesDeptYearMonth> RecordableInjuriesDeptYearMonth { get; set; }
        public virtual DbSet<RecordableInjuriesYearMonth> RecordableInjuriesYearMonth { get; set; }
        public virtual DbSet<RecordableRecipients> RecordableRecipients { get; set; }
        public virtual DbSet<RecordablesYearMonth> RecordablesYearMonth { get; set; }
        public virtual DbSet<SafetyStatusRecords> SafetyStatusRecords { get; set; }
        public virtual DbSet<TempStacked> TempStacked { get; set; }
        public virtual DbSet<TempStackedNoDate> TempStackedNoDate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=SBNDINMS007;Initial Catalog=FMSB_SafetyIncidence;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllIncidentsYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllIncidents_Year");
            });

            modelBuilder.Entity<AllIncidentsYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AllIncidents_Year_Month");
            });

            modelBuilder.Entity<AttachView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("attach_view");

                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.Incidentid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_attachments_Incidence");
            });

            modelBuilder.Entity<AuditIncidenceDeleted>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<EmailsNotiRecipients>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK_EmailsNotificationRecipients");
            });

            modelBuilder.Entity<GenerateStackedChart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("generate_stackedChart");

                entity.Property(e => e.Mos).IsUnicode(false);
            });

            modelBuilder.Entity<GetLaborHours>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetLaborHours");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ManHours).IsUnicode(false);
            });

            modelBuilder.Entity<Incidence>(entity =>
            {
                entity.Property(e => e.DeletedFlagComment).IsUnicode(false);

                entity.Property(e => e.FmTipsNumber).IsUnicode(false);

                entity.Property(e => e.IsClosed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFmTipsCompleted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BodyPart)
                    .WithMany(p => p.Incidence)
                    .HasForeignKey(d => d.BodyPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_BodyPart");

                entity.HasOne(d => d.DeptNavigation)
                    .WithMany(p => p.Incidence)
                    .HasForeignKey(d => d.Dept)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_Dept");

                entity.HasOne(d => d.Injury)
                    .WithMany(p => p.Incidence)
                    .HasForeignKey(d => d.InjuryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_Injuries");
            });

            modelBuilder.Entity<IncidenceHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidenceHistory");
            });

            modelBuilder.Entity<IncidentRates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentRates");

                entity.Property(e => e.ManHours).IsUnicode(false);
            });

            modelBuilder.Entity<IncidentRatesNum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentRates_Num");
            });

            modelBuilder.Entity<IncidentRatesWithLossTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentRates_withLossTime");
            });

            modelBuilder.Entity<IncidentRatesWithLossTimeRates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentRates_withLossTimeRates");

                entity.Property(e => e.ManHours).IsUnicode(false);
            });

            modelBuilder.Entity<IncidentsByBodyPartYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByBodyPart_Year");
            });

            modelBuilder.Entity<IncidentsByBodyPartYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByBodyPart_Year_Month");
            });

            modelBuilder.Entity<IncidentsByDeptYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByDept_Year");
            });

            modelBuilder.Entity<IncidentsByDeptYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByDept_Year_Month");
            });

            modelBuilder.Entity<IncidentsByShiftYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByShift_Year");
            });

            modelBuilder.Entity<IncidentsByShiftYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsByShift_Year_Month");
            });

            modelBuilder.Entity<IncidentsBycausationYear>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsBYCausation_Year");
            });

            modelBuilder.Entity<IncidentsBycausationYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("IncidentsBYCausation_Year_Month");
            });

            modelBuilder.Entity<InjuryStat>(entity =>
            {
                entity.Property(e => e.Color).IsUnicode(false);
            });

            modelBuilder.Entity<MonthsReference>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mos).IsUnicode(false);
            });

            modelBuilder.Entity<RatesChartView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RatesChartView");
            });

            modelBuilder.Entity<RecordableInjuriesDeptYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecordableInjuriesDept_Year_Month");
            });

            modelBuilder.Entity<RecordableInjuriesYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RecordableInjuries_Year_Month");
            });

            modelBuilder.Entity<RecordableRecipients>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<RecordablesYearMonth>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Recordables_Year_Month");
            });

            modelBuilder.Entity<SafetyStatusRecords>(entity =>
            {
                entity.Property(e => e.CorrectiveAction).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ResponsiblePerson).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<TempStacked>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Mos).IsUnicode(false);
            });

            modelBuilder.Entity<TempStackedNoDate>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Label).IsUnicode(false);

                entity.Property(e => e.Series).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
