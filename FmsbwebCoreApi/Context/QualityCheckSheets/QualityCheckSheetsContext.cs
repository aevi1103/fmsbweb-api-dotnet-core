using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.FmsbMvc;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using NUnit.Framework;
using Machine = FmsbwebCoreApi.Entity.QualityCheckSheets.Machine;
using SubMachine = FmsbwebCoreApi.Entity.QualityCheckSheets.SubMachine;

namespace FmsbwebCoreApi.Context.QualityCheckSheets
{
    public partial class QualityCheckSheetsContext : DbContext
    {
        public QualityCheckSheetsContext()
        {
        }

        public QualityCheckSheetsContext(DbContextOptions<QualityCheckSheetsContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<SubMachine> SubMachines { get; set; }
        public virtual DbSet<ControlMethod> ControlMethods { get; set; }
        public virtual DbSet<OrganizationPart> OrganizationParts { get; set; }
        public virtual DbSet<DisplayAs> DisplayAs { get; set; }
        public virtual DbSet<Characteristic> Characteristics { get; set; }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ControlMethod>().HasData(new ControlMethod { ControlMethodId = 1, Method = "Machining Check Sheet" });
            modelBuilder.Entity<ControlMethod>().HasData(new ControlMethod { ControlMethodId = 2, Method = "Quality Inspection Summary" });

            var counter = 1;
            var innerCounter = 1;
            for (var i = 1; i < 10; i++)
            {
                modelBuilder.Entity<Line>().HasData(new Line { LineId = i, Value = i.ToString() });

                var machines = new List<string> { "Okuma SP", "Turmat", "Chiron SP", "Drill", "Diamond Turn SP", "Accuriser" };

                if (i < 4) continue;

                foreach (var machine in machines)
                {
                    var machineId = counter++;

                    modelBuilder.Entity<Machine>().HasData(new Machine
                    {
                        MachineId = machineId,
                        LineId = i,
                        Value = machine
                    });

                    if (machine.ToLower().Contains("okuma"))
                    {
                        foreach (var okuma in new List<string> { "OK1", "OK2", "OK3" })
                        {
                            modelBuilder.Entity<SubMachine>().HasData(new SubMachine { SubMachineId = innerCounter++, MachineId = machineId, Value = okuma });
                        }
                    }

                    if (machine.ToLower().Contains("chiron"))
                    {
                        foreach (var chiron in new List<string> { "Chiron 1", "Chiron 2" })
                        {
                            modelBuilder.Entity<SubMachine>().HasData(new SubMachine { SubMachineId = innerCounter++, MachineId = machineId, Value = chiron });
                        }
                    }

                    if (machine.ToLower().Contains("diamond turn"))
                    {
                        foreach (var dt in new List<string> { "DT1", "DT2" })
                        {
                            modelBuilder.Entity<SubMachine>().HasData(new SubMachine { SubMachineId = innerCounter++, MachineId = machineId, Value = dt });
                        }
                    }

                    if (machine.ToLower().Contains("turmat"))
                    {
                        modelBuilder.Entity<SubMachine>().HasData(new SubMachine { SubMachineId = innerCounter++, MachineId = machineId, Value = "Turmat" });
                    }

                    if (machine.ToLower().Contains("accuriser"))
                    {
                        modelBuilder.Entity<SubMachine>().HasData(new SubMachine { SubMachineId = innerCounter++, MachineId = machineId, Value = "Accuriser" });
                    }
                }
            }

            var displays = new List<string> { "Number", "Percent", "Degrees", "NegativePositive", "PassFail", "Positive", "Reference" };
            var displayCounter = 1;
            foreach (var display in displays)
            {
                modelBuilder.Entity<DisplayAs>().HasData(new DisplayAs { DisplayAsId = displayCounter++, Display = display });
            }

            var parts = new List<OrganizationPart>()
            {
                new OrganizationPart
                {
                    LeftHandPart = "81309",
                    RightHandPart = "81310"
                },
                new OrganizationPart
                {
                    LeftHandPart = "81311",
                    RightHandPart = "81312"
                },
                new OrganizationPart
                {
                    LeftHandPart = "81313",
                    RightHandPart = "81314"
                }
            };

            var partCounter = 1;
            foreach (var part in parts)
            {
                part.OrganizationPartId = partCounter++;
                modelBuilder.Entity<OrganizationPart>().HasData(part);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null) throw new ArgumentNullException(nameof(modelBuilder));

            SeedData(modelBuilder);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
