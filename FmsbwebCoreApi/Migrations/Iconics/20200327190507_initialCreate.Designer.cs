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
    [Migration("20200327190507_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
