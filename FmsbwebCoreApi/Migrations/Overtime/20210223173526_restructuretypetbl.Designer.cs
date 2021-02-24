﻿// <auto-generated />
using System;
using FmsbwebCoreApi.Context.Overtime;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FmsbwebCoreApi.Migrations.Overtime
{
    [DbContext(typeof(OvertimeContext))]
    [Migration("20210223173526_restructuretypetbl")]
    partial class restructuretypetbl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Employee", b =>
                {
                    b.Property<int>("ClockNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateHired")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ClockNumber");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Overtime", b =>
                {
                    b.Property<int>("OvertimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClockNumber")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Hours")
                        .HasColumnType("float");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OvertimeId");

                    b.HasIndex("ClockNumber");

                    b.ToTable("Overtime");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Type", b =>
                {
                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TypeName");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Employee", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.Overtime.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FmsbwebCoreApi.Entity.Overtime.Overtime", b =>
                {
                    b.HasOne("FmsbwebCoreApi.Entity.Overtime.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("ClockNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
