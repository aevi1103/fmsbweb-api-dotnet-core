﻿// <auto-generated />
using System;
using FmsbwebCoreApi.Context.Iconics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FmsbwebCoreApi.Migrations.Iconics
{
    [DbContext(typeof(IconicsContext))]
    [Migration("20201124203835_AddTables")]
    partial class AddTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepServerTagName", b =>
                {
                    b.Property<string>("TagName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept")
                        .HasColumnName("dept")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsLastCounter")
                        .HasColumnName("isLastCounter")
                        .HasColumnType("bit");

                    b.Property<string>("Line")
                        .HasColumnName("line")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Stamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("TagId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagName");

                    b.ToTable("KEPserverTagNames");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepServerTagNameGroup", b =>
                {
                    b.Property<int>("KepServerTagNameGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("KepServerTagNameGroupId");

                    b.ToTable("KepServerTagNameGroups");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepServerTagNameMonitor", b =>
                {
                    b.Property<int>("KepServerTagNameMonitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KepServerTagNameGroupId")
                        .HasColumnType("int");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("KepServerTagNameMonitorId");

                    b.HasIndex("KepServerTagNameGroupId");

                    b.HasIndex("TagName");

                    b.ToTable("KepServerTagNameMonitors");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepserverMachineDowntime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentVal")
                        .IsRequired()
                        .HasColumnName("currentVal")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<decimal?>("DowntimeMinutes")
                        .HasColumnName("downtime_minutes")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("EndStamp")
                        .HasColumnName("end_stamp")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsInitialSave")
                        .HasColumnName("isInitialSave")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("OriginalEndStamp")
                        .HasColumnName("original_end_stamp")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("OriginalStartStamp")
                        .HasColumnName("original_start_stamp")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("StartStamp")
                        .HasColumnName("start_stamp")
                        .HasColumnType("datetime");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnName("tagName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnName("time_stamp")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("KEPServer_MachineDowntime");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepServerTagNameMonitor", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.Iconics.KepServerTagNameGroup", "KepServerTagNameGroup")
                        .WithMany()
                        .HasForeignKey("KepServerTagNameGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.Iconics.KepServerTagName", "KepServerTagName")
                        .WithMany()
                        .HasForeignKey("TagName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}