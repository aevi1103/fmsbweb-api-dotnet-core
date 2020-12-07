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
    [Migration("20201204185659_removeMOnitorTable2")]
    partial class removeMOnitorTable2
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
                    b.Property<Guid>("KepServerTagNameGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("KepServerTagNameGroupId");

                    b.ToTable("KepServerTagNameGroups");

                    b.HasData(
                        new
                        {
                            KepServerTagNameGroupId = new Guid("01b888a3-00ca-4736-96ae-1636dc7ec914"),
                            Department = "Assembly",
                            GroupName = "A2",
                            TagName = "Assembly.A2_PACKOUT.A2_PACKOUT_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 848, DateTimeKind.Local).AddTicks(2034)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("bd9eae20-60c7-44cd-ae2e-96c5f015f82e"),
                            Department = "Assembly",
                            GroupName = "A3",
                            TagName = "Assembly.A3.A3_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(4883)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("77e6d96c-f58d-46ea-a00d-5f962cfaf67b"),
                            Department = "Assembly",
                            GroupName = "A4",
                            TagName = "Assembly.A4_M3.A4_M3_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5012)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("c26e4341-8e94-48f8-9eb6-fd2c5061bae3"),
                            Department = "Assembly",
                            GroupName = "A5",
                            TagName = "Assembly.A5.A5_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5039)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("f5ede641-fb76-40d5-924b-5d28ceea1ac9"),
                            Department = "Assembly",
                            GroupName = "A6",
                            TagName = "Assembly.A6_M2.A6_M2_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5074)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("1ace746f-f44f-47c4-bb9c-6c49fc550488"),
                            Department = "Assembly",
                            GroupName = "A7",
                            TagName = "Assembly.A7_M3.A7_M3_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5103)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("13667af3-8a37-456a-8d65-5e98627af1ad"),
                            Department = "Assembly",
                            GroupName = "A8",
                            TagName = "Assembly.A8.A8_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5128)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"),
                            Department = "Assembly",
                            GroupName = "A9",
                            TagName = "Assembly.A9_M3.A9_M3_APC",
                            TimeStamp = new DateTime(2020, 12, 4, 13, 56, 58, 849, DateTimeKind.Local).AddTicks(5152)
                        });
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
#pragma warning restore 612, 618
        }
    }
}
