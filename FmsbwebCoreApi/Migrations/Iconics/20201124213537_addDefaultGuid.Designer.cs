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
    [Migration("20201124213537_addDefaultGuid")]
    partial class addDefaultGuid
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

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(5)")
                        .HasMaxLength(5);

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("KepServerTagNameGroupId");

                    b.ToTable("KepServerTagNameGroups");

                    b.HasData(
                        new
                        {
                            KepServerTagNameGroupId = new Guid("3554f89b-06b6-4c2d-a774-a5ea62197997"),
                            GroupName = "A2",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 77, DateTimeKind.Local).AddTicks(2817)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("4e7f855a-1999-4848-b811-06ac81c2c431"),
                            GroupName = "A3",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5269)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("0445d260-273d-44fe-af79-46a8a38b7b27"),
                            GroupName = "A4",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5392)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("87dde5c2-6177-4831-bd4d-8ad613767b43"),
                            GroupName = "A5",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5418)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("6425df41-847a-4fee-b3d3-0d3935370dcc"),
                            GroupName = "A6",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5451)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("c86e18f2-5ce9-401f-aa2d-2a3a35e96efa"),
                            GroupName = "A7",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5481)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("72723b26-5652-4d82-9bc3-eac81a74b022"),
                            GroupName = "A8",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5504)
                        },
                        new
                        {
                            KepServerTagNameGroupId = new Guid("e9f14765-bb45-4dd1-adbc-be7cb3d49c8c"),
                            GroupName = "A9",
                            TimeStamp = new DateTime(2020, 11, 24, 16, 35, 37, 78, DateTimeKind.Local).AddTicks(5526)
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Iconics.KepServerTagNameMonitor", b =>
                {
                    b.Property<int>("KepServerTagNameMonitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("KepServerTagNameGroupId")
                        .HasColumnType("uniqueidentifier");

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
