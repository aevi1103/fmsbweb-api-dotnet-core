﻿// <auto-generated />
using System;
using FmsbwebCoreApi.Context.Intranet;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FmsbwebCoreApi.Migrations.Intranet
{
    [DbContext(typeof(IntranetContext))]
    [Migration("20200825170907_addSeedData")]
    partial class addSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("db_owner")
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Intranet.EolManning", b =>
                {
                    b.Property<int>("EolManningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EolvsEosId")
                        .HasColumnType("int");

                    b.Property<int>("OperatorId")
                        .HasColumnType("int");

                    b.Property<int>("OperatorJobId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("EolManningId");

                    b.HasIndex("EolvsEosId");

                    b.HasIndex("OperatorId");

                    b.HasIndex("OperatorJobId");

                    b.ToTable("EOLVS_EOS_MANNING","dbo");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Intranet.EolvsEos", b =>
                {
                    b.Property<int>("EolvsEosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("ActualRuntime")
                        .HasColumnName("Actual_Runtime")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<byte[]>("Attachment")
                        .HasColumnName("attachment")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal?>("ChangeoverHrs")
                        .HasColumnName("changeoverHrs")
                        .HasColumnType("decimal(18, 3)");

                    b.Property<string>("CoType")
                        .HasColumnName("co_type")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Com")
                        .HasColumnName("com")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("DowntimeCom")
                        .HasColumnName("downtime_com")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<int?>("Fs")
                        .HasColumnName("fs")
                        .HasColumnType("int");

                    b.Property<int>("Gross")
                        .HasColumnName("gross")
                        .HasColumnType("int");

                    b.Property<int>("Line")
                        .HasColumnName("line")
                        .HasColumnType("int");

                    b.Property<string>("MachDef25")
                        .HasColumnName("machDef_25")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("ManualTarget")
                        .HasColumnName("manual_target")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime?>("Modifieddate")
                        .HasColumnName("modifieddate")
                        .HasColumnType("datetime");

                    b.Property<int>("Ms")
                        .HasColumnName("ms")
                        .HasColumnType("int");

                    b.Property<string>("NonSchedReason")
                        .HasColumnName("Non_schedReason")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<decimal?>("NonSchedRuntime")
                        .HasColumnName("Non_schedRuntime")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<decimal>("NumPeople")
                        .HasColumnName("num_people")
                        .HasColumnType("decimal(18, 3)");

                    b.Property<int?>("OffLoads")
                        .HasColumnName("offLoads")
                        .HasColumnType("int");

                    b.Property<string>("Pn")
                        .HasColumnName("pn")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("QualityCom")
                        .HasColumnName("quality_com")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<DateTime>("ShiftDate")
                        .HasColumnName("shiftDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Shiftname")
                        .IsRequired()
                        .HasColumnName("shiftname")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("Supervisor")
                        .IsRequired()
                        .HasColumnName("supervisor")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<decimal?>("TargetRuntime")
                        .HasColumnName("Target_Runtime")
                        .HasColumnType("decimal(18, 5)");

                    b.Property<bool?>("ToolChanged")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("((0))");

                    b.HasKey("EolvsEosId");

                    b.ToTable("EOLVS_EOS","dbo");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Intranet.Operator", b =>
                {
                    b.Property<int>("OperatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("OperatorId");

                    b.ToTable("EOLVS_EOS_OPERATORS","dbo");

                    b.HasData(
                        new
                        {
                            OperatorId = 1,
                            FirstName = "Pedro",
                            LastName = "Anglero",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6159)
                        },
                        new
                        {
                            OperatorId = 2,
                            FirstName = "Joe",
                            LastName = "Stroud",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6236)
                        },
                        new
                        {
                            OperatorId = 3,
                            FirstName = "Ritchard",
                            LastName = "Krouse",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6242)
                        },
                        new
                        {
                            OperatorId = 4,
                            FirstName = "Gregory",
                            LastName = "Kuzmits",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6245)
                        },
                        new
                        {
                            OperatorId = 5,
                            FirstName = "Nick",
                            LastName = "Powers",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6254)
                        },
                        new
                        {
                            OperatorId = 6,
                            FirstName = "Bryan",
                            LastName = "Crowner",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6258)
                        },
                        new
                        {
                            OperatorId = 7,
                            FirstName = "Kenny",
                            LastName = "Plencner",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6262)
                        },
                        new
                        {
                            OperatorId = 8,
                            FirstName = "Michael",
                            LastName = "Plencner",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6265)
                        },
                        new
                        {
                            OperatorId = 9,
                            FirstName = "Paula",
                            LastName = "Smith",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6405)
                        },
                        new
                        {
                            OperatorId = 10,
                            FirstName = "Gary",
                            LastName = "Westerhouse",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6410)
                        },
                        new
                        {
                            OperatorId = 11,
                            FirstName = "Steve",
                            LastName = "Ehardt",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6413)
                        },
                        new
                        {
                            OperatorId = 12,
                            FirstName = "Rollie",
                            LastName = "Ball",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6417)
                        },
                        new
                        {
                            OperatorId = 13,
                            FirstName = "Curt",
                            LastName = "Webb",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6421)
                        },
                        new
                        {
                            OperatorId = 14,
                            FirstName = "Kevin",
                            LastName = "Rossaw",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6426)
                        },
                        new
                        {
                            OperatorId = 15,
                            FirstName = "Scott",
                            LastName = "Higbee",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6431)
                        },
                        new
                        {
                            OperatorId = 16,
                            FirstName = "Joe",
                            LastName = "Kil",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6435)
                        },
                        new
                        {
                            OperatorId = 17,
                            FirstName = "Tracey",
                            LastName = "Smith",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6439)
                        },
                        new
                        {
                            OperatorId = 18,
                            FirstName = "Dale",
                            LastName = "Beghtel",
                            TimeStamp = new DateTime(2020, 8, 25, 13, 9, 7, 216, DateTimeKind.Local).AddTicks(6443)
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Intranet.OperatorJob", b =>
                {
                    b.Property<int>("OperatorJobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("OperatorJobId");

                    b.ToTable("EOLVS_EOS_OPERATOR_JOBS","dbo");

                    b.HasData(
                        new
                        {
                            OperatorJobId = 1,
                            Job = "Okuma Operator",
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            OperatorJobId = 2,
                            Job = "Diamond Turn Operator",
                            TimeStamp = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Intranet.EolManning", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.Intranet.EolvsEos", "EolvsEos")
                        .WithMany()
                        .HasForeignKey("EolvsEosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.Intranet.Operator", "Operator")
                        .WithMany()
                        .HasForeignKey("OperatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FmsbwebCoreApi.Entity.Intranet.OperatorJob", "OperatorJob")
                        .WithMany()
                        .HasForeignKey("OperatorJobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
