﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Safety;

#nullable disable

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

        public virtual DbSet<Attachment> Attachments { get; set; }
        public virtual DbSet<BodyPart> BodyParts { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<EmailNotificationLog> EmailNotificationLogs { get; set; }
        public virtual DbSet<EmailsNotiRecipient> EmailsNotiRecipients { get; set; }
        public virtual DbSet<Incidence> Incidences { get; set; }
        public virtual DbSet<IncidenceDeletedRecord> IncidenceDeletedRecords { get; set; }
        public virtual DbSet<Injury> Injuries { get; set; }
        public virtual DbSet<InjuryStat> InjuryStats { get; set; }
        public virtual DbSet<ManHour> ManHours { get; set; }
        public virtual DbSet<RecordableRecipient> RecordableRecipients { get; set; }
        public virtual DbSet<SafetyStatusRecord> SafetyStatusRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.Incidentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_attachments_Incidence");
            });

            modelBuilder.Entity<EmailsNotiRecipient>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK_EmailsNotificationRecipients");
            });

            modelBuilder.Entity<Incidence>(entity =>
            {
                entity.Property(e => e.DeletedFlagComment).IsUnicode(false);

                entity.Property(e => e.FmTipsNumber).IsUnicode(false);

                entity.Property(e => e.IsClosed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsFmTipsCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Mitigated).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.HasOne(d => d.BodyPart)
                    .WithMany(p => p.Incidences)
                    .HasForeignKey(d => d.BodyPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_BodyPart");

                entity.HasOne(d => d.DeptNavigation)
                    .WithMany(p => p.Incidences)
                    .HasForeignKey(d => d.Dept)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_Dept");

                entity.HasOne(d => d.Injury)
                    .WithMany(p => p.Incidences)
                    .HasForeignKey(d => d.InjuryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_Injuries");

                entity.HasOne(d => d.InjuryStat)
                    .WithMany(p => p.Incidences)
                    .HasForeignKey(d => d.InjuryStatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Incidence_InjuryStat");
            });

            modelBuilder.Entity<IncidenceDeletedRecord>(entity =>
            {
                entity.Property(e => e.DeletedFlagComment).IsUnicode(false);

                entity.Property(e => e.FmTipsNumber).IsUnicode(false);
            });

            modelBuilder.Entity<InjuryStat>(entity =>
            {
                entity.Property(e => e.Color).IsUnicode(false);
            });

            modelBuilder.Entity<RecordableRecipient>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<SafetyStatusRecord>(entity =>
            {
                entity.Property(e => e.CorrectiveAction).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ResponsiblePerson).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}