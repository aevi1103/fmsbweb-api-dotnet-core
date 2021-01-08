using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.FmsbOee;
using FmsbwebCoreApi.Enums;
using Microsoft.EntityFrameworkCore;
using MachineGroup = FmsbwebCoreApi.Entity.Fmsb2.MachineGroup;
using Oee = FmsbwebCoreApi.Entity.FmsbOee.Oee;

namespace FmsbwebCoreApi.Context.FmsbOee
{
    public partial class FmsbOeeContext : DbContext
    {
        public FmsbOeeContext()
        {
        }

        public FmsbOeeContext(DbContextOptions<FmsbOeeContext> options) : base(options)
        {
        }

        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Oee> Oee { get; set; }
        public virtual DbSet<ClockNumber> ClockNumbers { get; set; }
        public virtual DbSet<Entity.FmsbOee.MachineGroup> MachineGroups { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<PrimaryReason> PrimaryReasons { get; set; }
        public virtual DbSet<SecondaryReason> SecondaryReasons { get; set; }
        public virtual DbSet<DowntimeEvent> DowntimeEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            var tags = new List<dynamic>
            {
                new
                {
                    Line = "A2",
                    Tag =  "Assembly.A2_PACKOUT.A2_PACKOUT_APC",
                    WorkCenter = "ASBY0002",
                    Guid = "01b888a3-00ca-4736-96ae-1636dc7ec914",
                    CycleTime = (decimal) 5,
                    InspectionLocation = ScrapInspectionLocation.After,
                    Machine = "Assembly 2"
                },
                new
                {
                    Line = "A3",
                    Tag =  "Assembly.A3.A3_APC",
                    WorkCenter = "ASBY0003",
                    Guid = "bd9eae20-60c7-44cd-ae2e-96c5f015f82e",
                    CycleTime = (decimal)11,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 3"
                },
                new
                {
                    Line = "A4",
                    Tag =  "Assembly.A4_M3.A4_M3_APC",
                    WorkCenter = "ASBY0004",
                    Guid = "77e6d96c-f58d-46ea-a00d-5f962cfaf67b",
                    CycleTime = (decimal)8.4,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 4"
                },
                new
                {
                    Line = "A5",
                    Tag =  "Assembly.A5.A5_APC",
                    WorkCenter = "ASBY0005",
                    Guid = "c26e4341-8e94-48f8-9eb6-fd2c5061bae3",
                    CycleTime = (decimal)8,
                    InspectionLocation = ScrapInspectionLocation.After,
                    Machine = "Assembly 5"
                },
                new
                {
                    Line = "A6",
                    Tag =  "Assembly.A6_M2.A6_M2_APC",
                    WorkCenter = "ASBY0006",
                    Guid = "f5ede641-fb76-40d5-924b-5d28ceea1ac9",
                    CycleTime = (decimal)8,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 6"
                },
                new
                {
                    Line = "A7",
                    Tag =  "Assembly.A7_M3.A7_M3_APC",
                    WorkCenter = "ASBY0007",
                    Guid = "1ace746f-f44f-47c4-bb9c-6c49fc550488",
                    CycleTime = (decimal)9,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 7"
                },
                new
                {
                    Line = "A8",
                    Tag =  "Assembly.A8.A8_APC",
                    WorkCenter = "ASBY0008",
                    Guid = "13667af3-8a37-456a-8d65-5e98627af1ad",
                    CycleTime = (decimal)12,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 8"
                },
                new
                {
                    Line = "A9",
                    Tag =  "Assembly.A9_M3.A9_M3_APC",
                    WorkCenter = "ASBY0009",
                    Guid = "3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2",
                    CycleTime =(decimal)8.5,
                    InspectionLocation = ScrapInspectionLocation.Before,
                    Machine = "Assembly 9"
                },
            };

            foreach (var tag in tags)
            {
                modelBuilder.Entity<Line>().HasData(new Line
                {
                    LineId = new Guid(tag.Guid),
                    GroupName = tag.Line,
                    TagName = tag.Tag,
                    Department = "Assembly",
                    WorkCenter = tag.WorkCenter,
                    DateModified = DateTime.Now,
                    CycleTimeSeconds = tag.CycleTime,
                    ScrapInspectionLocation = tag.InspectionLocation,
                    MachineName = tag.Machine
                });
            }

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
