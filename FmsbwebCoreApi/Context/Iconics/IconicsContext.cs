﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Iconics;

namespace FmsbwebCoreApi.Context.Iconics
{
    public partial class IconicsContext : DbContext
    {
        public IconicsContext()
        {
        }

        public IconicsContext(DbContextOptions<IconicsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KepserverMachineDowntime> KepserverMachineDowntimes { get; set; }
        public virtual DbSet<KepserverPermCountsHistory> KepserverPermCountsHistories { get; set; }
        public virtual DbSet<KepserverTagName> KepserverTagNames { get; set; }
        public virtual DbSet<KepserverTagNamesView> KepserverTagNamesViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KepserverMachineDowntime>(entity =>
            {
                entity.ToTable("KEPServer_MachineDowntime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CurrentVal)
                    .IsRequired()
                    .HasColumnName("currentVal")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DowntimeMinutes)
                    .HasColumnName("downtime_minutes")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndStamp)
                    .HasColumnName("end_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsInitialSave).HasColumnName("isInitialSave");

                entity.Property(e => e.OriginalEndStamp)
                    .HasColumnName("original_end_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalStartStamp)
                    .HasColumnName("original_start_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartStamp)
                    .HasColumnName("start_stamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnName("tagName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("time_stamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<KepserverPermCountsHistory>(entity =>
            {
                entity.ToTable("KEPServer_PermCounts_History");

                entity.HasIndex(e => e.TagName)
                    .HasName("NonClusteredIndex-20200701-164725");

                entity.HasIndex(e => e.TimeStamp)
                    .HasName("NonClusteredIndex-20200707-074256");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.CurrentCount).HasColumnName("currentCount");

                entity.Property(e => e.IsInitialSave).HasColumnName("isInitialSave");

                entity.Property(e => e.PreviousCount).HasColumnName("previousCount");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnName("tagName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeStamp)
                    .HasColumnName("timeStamp")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<KepserverTagName>(entity =>
            {
                entity.HasKey(e => e.TagName);

                entity.ToTable("KEPserverTagNames");

                entity.Property(e => e.TagName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("dept")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsLastCounter)
                    .HasColumnName("isLastCounter")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Line)
                    .HasColumnName("line")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Stamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KepserverTagNamesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KEPserverTagNames_view");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CellSide)
                    .IsRequired()
                    .HasColumnName("cellSide")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasColumnName("dept")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.IsLastCounter).HasColumnName("isLastCounter");

                entity.Property(e => e.Line)
                    .HasColumnName("line")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LineHxh)
                    .HasColumnName("line_hxh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineMapper)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName2)
                    .HasMaxLength(62)
                    .IsUnicode(false);

                entity.Property(e => e.Stamp).HasColumnType("datetime");

                entity.Property(e => e.TagId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}