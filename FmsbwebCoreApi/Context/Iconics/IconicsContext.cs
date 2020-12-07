using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Iconics;

namespace FmsbwebCoreApi.Context.Iconics
{
    public partial class IconicsContext : DbContext
    {
        public IconicsContext()
        {
        }

        public IconicsContext(DbContextOptions<IconicsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KepserverMachineDowntime> KepserverMachineDowntime { get; set; }
        public virtual DbSet<KepserverTagNamesView> KepserverTagNamesView { get; set; }
        public virtual DbSet<KepServerTagName> KepServerTagNames { get; set; }

        public virtual DbSet<KepServerTagNameGroup> KepServerTagNameGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            // set initial values
            var tags = new List<dynamic>
            {
                new
                {
                    Line = "A2",
                    Tag =  "Assembly.A2_PACKOUT.A2_PACKOUT_APC",
                    WorkCenter = "ASBY0002",
                    Guid = "01b888a3-00ca-4736-96ae-1636dc7ec914"
                },
                new
                {
                    Line = "A3",
                    Tag =  "Assembly.A3.A3_APC",
                    WorkCenter = "ASBY0003",
                    Guid = "bd9eae20-60c7-44cd-ae2e-96c5f015f82e"
                },
                new
                {
                    Line = "A4",
                    Tag =  "Assembly.A4_M3.A4_M3_APC",
                    WorkCenter = "ASBY0004",
                    Guid = "77e6d96c-f58d-46ea-a00d-5f962cfaf67b"
                },
                new
                {
                    Line = "A5",
                    Tag =  "Assembly.A5.A5_APC",
                    WorkCenter = "ASBY0005",
                    Guid = "c26e4341-8e94-48f8-9eb6-fd2c5061bae3"
                },
                new
                {
                    Line = "A6",
                    Tag =  "Assembly.A6_M2.A6_M2_APC",
                    WorkCenter = "ASBY0006",
                    Guid = "f5ede641-fb76-40d5-924b-5d28ceea1ac9"
                },
                new
                {
                    Line = "A7",
                    Tag =  "Assembly.A7_M3.A7_M3_APC",
                    WorkCenter = "ASBY0007",
                    Guid = "1ace746f-f44f-47c4-bb9c-6c49fc550488"
                },
                new
                {
                    Line = "A8",
                    Tag =  "Assembly.A8.A8_APC",
                    WorkCenter = "ASBY0008",
                    Guid = "13667af3-8a37-456a-8d65-5e98627af1ad"
                },
                new
                {
                    Line = "A9",
                    Tag =  "Assembly.A9_M3.A9_M3_APC",
                    WorkCenter = "ASBY0009",
                    Guid = "3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2"
                },
            };

            foreach (var tag in tags)
            {
                modelBuilder.Entity<KepServerTagNameGroup>().HasData(new KepServerTagNameGroup
                {
                    KepServerTagNameGroupId = new Guid(tag.Guid),
                    GroupName = tag.Line,
                    TagName = tag.Tag,
                    Department = "Assembly",
                    WorkCenter = tag.WorkCenter,
                    TimeStamp = DateTime.Now
                });
            }

            modelBuilder.Entity<KepserverMachineDowntime>(entity =>
            {
                entity.Property(e => e.CurrentVal).IsUnicode(false);

                entity.Property(e => e.TagName).IsUnicode(false);
            });

            modelBuilder.Entity<KepserverTagNamesView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KEPserverTagNames_view");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DataType).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.LineHxh).IsUnicode(false);

                entity.Property(e => e.MachineMapper).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineName2).IsUnicode(false);

                entity.Property(e => e.TagId).IsUnicode(false);

                entity.Property(e => e.TagName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
