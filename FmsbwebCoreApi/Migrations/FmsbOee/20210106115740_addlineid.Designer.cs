﻿// <auto-generated />
using System;
using FmsbwebCoreApi.Context.FmsbOee;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FmsbwebCoreApi.Migrations.FmsbOee
{
    [DbContext(typeof(FmsbOeeContext))]
    [Migration("20210106115740_addlineid")]
    partial class addlineid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.ClockNumber", b =>
                {
                    b.Property<Guid>("ClockNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Clock")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ClockNumberId");

                    b.HasIndex("OeeId");

                    b.ToTable("ClockNumbers");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.DowntimeEvent", b =>
                {
                    b.Property<Guid>("DowntimeEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Downtime")
                        .HasColumnType("int");

                    b.Property<int>("DowntimeEventType")
                        .HasColumnType("int");

                    b.Property<Guid>("MachineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SecondaryReasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("DowntimeEventId");

                    b.HasIndex("MachineId");

                    b.HasIndex("OeeId");

                    b.HasIndex("SecondaryReasonId");

                    b.ToTable("DowntimeEvents");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.Line", b =>
                {
                    b.Property<Guid>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CycleTimeSeconds")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<int>("ScrapInspectionLocation")
                        .HasColumnType("int");

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkCenter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LineId");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            LineId = new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                            CycleTimeSeconds = 5m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 767, DateTimeKind.Local).AddTicks(736),
                            Department = "Assembly",
                            GroupName = "A2",
                            ScrapInspectionLocation = 2,
                            TagName = "Assembly.A2_PACKOUT.A2_PACKOUT_APC",
                            WorkCenter = "ASBY0002"
                        },
                        new
                        {
                            LineId = new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                            CycleTimeSeconds = 11m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(792),
                            Department = "Assembly",
                            GroupName = "A3",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A3.A3_APC",
                            WorkCenter = "ASBY0003"
                        },
                        new
                        {
                            LineId = new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                            CycleTimeSeconds = 8.4m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1275),
                            Department = "Assembly",
                            GroupName = "A4",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A4_M3.A4_M3_APC",
                            WorkCenter = "ASBY0004"
                        },
                        new
                        {
                            LineId = new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                            CycleTimeSeconds = 8m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1366),
                            Department = "Assembly",
                            GroupName = "A5",
                            ScrapInspectionLocation = 2,
                            TagName = "Assembly.A5.A5_APC",
                            WorkCenter = "ASBY0005"
                        },
                        new
                        {
                            LineId = new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                            CycleTimeSeconds = 8m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(1440),
                            Department = "Assembly",
                            GroupName = "A6",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A6_M2.A6_M2_APC",
                            WorkCenter = "ASBY0006"
                        },
                        new
                        {
                            LineId = new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                            CycleTimeSeconds = 9m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2050),
                            Department = "Assembly",
                            GroupName = "A7",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A7_M3.A7_M3_APC",
                            WorkCenter = "ASBY0007"
                        },
                        new
                        {
                            LineId = new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                            CycleTimeSeconds = 12m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2163),
                            Department = "Assembly",
                            GroupName = "A8",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A8.A8_APC",
                            WorkCenter = "ASBY0008"
                        },
                        new
                        {
                            LineId = new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                            CycleTimeSeconds = 8.5m,
                            DateModified = new DateTime(2021, 1, 6, 6, 57, 39, 783, DateTimeKind.Local).AddTicks(2233),
                            Department = "Assembly",
                            GroupName = "A9",
                            ScrapInspectionLocation = 1,
                            TagName = "Assembly.A9_M3.A9_M3_APC",
                            WorkCenter = "ASBY0009"
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.Machine", b =>
                {
                    b.Property<Guid>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MachineGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MachineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MachineId");

                    b.HasIndex("MachineGroupId");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.MachineGroup", b =>
                {
                    b.Property<Guid>("MachineGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MachineGroupId");

                    b.ToTable("MachineGroups");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.Oee", b =>
                {
                    b.Property<Guid>("OeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("OeeId");

                    b.HasIndex("LineId");

                    b.ToTable("Oee");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.PrimaryReason", b =>
                {
                    b.Property<Guid>("PrimaryReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrimaryReasonId");

                    b.ToTable("PrimaryReasons");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.SecondaryReason", b =>
                {
                    b.Property<Guid>("SecondaryReasonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PrimaryReasonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SecondaryReasonId");

                    b.HasIndex("PrimaryReasonId");

                    b.ToTable("SecondaryReasons");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.ClockNumber", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.Oee", "Oee")
                        .WithMany()
                        .HasForeignKey("OeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.DowntimeEvent", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.Oee", "Oee")
                        .WithMany()
                        .HasForeignKey("OeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.SecondaryReason", "SecondaryReason")
                        .WithMany()
                        .HasForeignKey("SecondaryReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.Machine", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.MachineGroup", "MachineGroup")
                        .WithMany()
                        .HasForeignKey("MachineGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.Oee", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.Line", "Line")
                        .WithMany()
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.FmsbOee.SecondaryReason", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.FmsbOee.PrimaryReason", "PrimaryReason")
                        .WithMany()
                        .HasForeignKey("PrimaryReasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
