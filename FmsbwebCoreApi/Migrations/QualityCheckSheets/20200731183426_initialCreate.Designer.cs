﻿// <auto-generated />
using System;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FmsbwebCoreApi.Migrations.QualityCheckSheets
{
    [DbContext(typeof(QualityCheckSheetsContext))]
    [Migration("20200731183426_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.Characteristic", b =>
                {
                    b.Property<int>("CharacteristicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ControlMethodId")
                        .HasColumnType("int");

                    b.Property<int>("DisplayAsId")
                        .HasColumnType("int");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<string>("Gauge")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HelperText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Max")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Min")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Nom")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("OrganizationPartId")
                        .HasColumnType("int");

                    b.Property<bool?>("PassFail")
                        .HasColumnType("bit");

                    b.Property<string>("ReferenceNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CharacteristicId");

                    b.HasIndex("ControlMethodId");

                    b.HasIndex("DisplayAsId");

                    b.HasIndex("MachineId");

                    b.HasIndex("OrganizationPartId");

                    b.ToTable("Characteristics");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.ControlMethod", b =>
                {
                    b.Property<int>("ControlMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("ControlMethodId");

                    b.ToTable("ControlMethods");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.DisplayAs", b =>
                {
                    b.Property<int>("DisplayAsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("DisplayAsId");

                    b.ToTable("DisplayAs");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.Line", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LineId");

                    b.ToTable("Lines");

                    b.HasData(
                        new
                        {
                            LineId = 1,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 934, DateTimeKind.Local).AddTicks(879),
                            Value = "1"
                        },
                        new
                        {
                            LineId = 2,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(249),
                            Value = "2"
                        },
                        new
                        {
                            LineId = 3,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(458),
                            Value = "3"
                        },
                        new
                        {
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(486),
                            Value = "4"
                        },
                        new
                        {
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1250),
                            Value = "5"
                        },
                        new
                        {
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1674),
                            Value = "6"
                        },
                        new
                        {
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1974),
                            Value = "7"
                        },
                        new
                        {
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2329),
                            Value = "8"
                        },
                        new
                        {
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2687),
                            Value = "9"
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.Machine", b =>
                {
                    b.Property<int>("MachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MachineId");

                    b.HasIndex("LineId");

                    b.ToTable("Machines");

                    b.HasData(
                        new
                        {
                            MachineId = 1,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(609),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 2,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1042),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 3,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1066),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 4,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1135),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 5,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1158),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 6,
                            LineId = 4,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1226),
                            Value = "Accuriser"
                        },
                        new
                        {
                            MachineId = 7,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1275),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 8,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1366),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 9,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1389),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 10,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1454),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 11,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1476),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 12,
                            LineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1650),
                            Value = "Accuriser"
                        },
                        new
                        {
                            MachineId = 13,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1697),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 14,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1781),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 15,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1803),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 16,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1867),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 17,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1889),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 18,
                            LineId = 6,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1953),
                            Value = "Accuriser"
                        },
                        new
                        {
                            MachineId = 19,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2051),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 20,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2138),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 21,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2160),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 22,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2223),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 23,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2245),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 24,
                            LineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2308),
                            Value = "Accuriser"
                        },
                        new
                        {
                            MachineId = 25,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2350),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 26,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2432),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 27,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2454),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 28,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2582),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 29,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2603),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 30,
                            LineId = 8,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2666),
                            Value = "Accuriser"
                        },
                        new
                        {
                            MachineId = 31,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2710),
                            Value = "Okuma SP"
                        },
                        new
                        {
                            MachineId = 32,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2791),
                            Value = "Turmat"
                        },
                        new
                        {
                            MachineId = 33,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2812),
                            Value = "Chiron SP"
                        },
                        new
                        {
                            MachineId = 34,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2876),
                            Value = "Drill"
                        },
                        new
                        {
                            MachineId = 35,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2898),
                            Value = "Diamond Turn SP"
                        },
                        new
                        {
                            MachineId = 36,
                            LineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(3005),
                            Value = "Accuriser"
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.OrganizationPart", b =>
                {
                    b.Property<int>("OrganizationPartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LeftHandPart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RightHandPart")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("OrganizationPartId");

                    b.ToTable("OrganizationParts");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.SubMachine", b =>
                {
                    b.Property<int>("SubMachineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MachineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubMachineId");

                    b.HasIndex("MachineId");

                    b.ToTable("SubMachines");

                    b.HasData(
                        new
                        {
                            SubMachineId = 1,
                            MachineId = 1,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(909),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 2,
                            MachineId = 1,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(990),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 3,
                            MachineId = 1,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1015),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 4,
                            MachineId = 3,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1092),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 5,
                            MachineId = 3,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1112),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 6,
                            MachineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1186),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 7,
                            MachineId = 5,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1206),
                            Value = "DT2"
                        },
                        new
                        {
                            SubMachineId = 8,
                            MachineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1302),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 9,
                            MachineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1323),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 10,
                            MachineId = 7,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1344),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 11,
                            MachineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1413),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 12,
                            MachineId = 9,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1433),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 13,
                            MachineId = 11,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1607),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 14,
                            MachineId = 11,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1630),
                            Value = "DT2"
                        },
                        new
                        {
                            SubMachineId = 15,
                            MachineId = 13,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1719),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 16,
                            MachineId = 13,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1739),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 17,
                            MachineId = 13,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1758),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 18,
                            MachineId = 15,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1826),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 19,
                            MachineId = 15,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1846),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 20,
                            MachineId = 17,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1913),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 21,
                            MachineId = 17,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(1933),
                            Value = "DT2"
                        },
                        new
                        {
                            SubMachineId = 22,
                            MachineId = 19,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2076),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 23,
                            MachineId = 19,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2096),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 24,
                            MachineId = 19,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2116),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 25,
                            MachineId = 21,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2183),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 26,
                            MachineId = 21,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2203),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 27,
                            MachineId = 23,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2268),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 28,
                            MachineId = 23,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2288),
                            Value = "DT2"
                        },
                        new
                        {
                            SubMachineId = 29,
                            MachineId = 25,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2372),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 30,
                            MachineId = 25,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2392),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 31,
                            MachineId = 25,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2411),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 32,
                            MachineId = 27,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2533),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 33,
                            MachineId = 27,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2558),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 34,
                            MachineId = 29,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2627),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 35,
                            MachineId = 29,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2646),
                            Value = "DT2"
                        },
                        new
                        {
                            SubMachineId = 36,
                            MachineId = 31,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2731),
                            Value = "OK1"
                        },
                        new
                        {
                            SubMachineId = 37,
                            MachineId = 31,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2751),
                            Value = "OK2"
                        },
                        new
                        {
                            SubMachineId = 38,
                            MachineId = 31,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2770),
                            Value = "OK3"
                        },
                        new
                        {
                            SubMachineId = 39,
                            MachineId = 33,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2836),
                            Value = "Chiron 1"
                        },
                        new
                        {
                            SubMachineId = 40,
                            MachineId = 33,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2855),
                            Value = "Chiron 2"
                        },
                        new
                        {
                            SubMachineId = 41,
                            MachineId = 35,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2963),
                            Value = "DT1"
                        },
                        new
                        {
                            SubMachineId = 42,
                            MachineId = 35,
                            TimeStamp = new DateTime(2020, 7, 31, 14, 34, 25, 938, DateTimeKind.Local).AddTicks(2983),
                            Value = "DT2"
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.Characteristic", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.ControlMethod", "ControlMethod")
                        .WithMany()
                        .HasForeignKey("ControlMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.DisplayAs", "DisplayAs")
                        .WithMany()
                        .HasForeignKey("DisplayAsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.OrganizationPart", "OrganizationPart")
                        .WithMany()
                        .HasForeignKey("OrganizationPartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.Machine", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.Line", "Line")
                        .WithMany()
                        .HasForeignKey("LineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.QualityCheckSheets.SubMachine", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.QualityCheckSheets.Machine", "Machine")
                        .WithMany()
                        .HasForeignKey("MachineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
