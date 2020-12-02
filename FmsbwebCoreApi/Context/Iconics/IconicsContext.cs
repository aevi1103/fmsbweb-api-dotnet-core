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

        public virtual DbSet<KepServerTagNameMonitor> KepServerTagNameMonitors { get; set; }
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
                    Tag =  "A2_PACKOUT_APC",
                    LineGuid = "01b888a3-00ca-4736-96ae-1636dc7ec914",
                    TagGuid = "b37a8885-7889-407f-a44a-3cbcf3ee1a14"
                },
                new
                {
                    Line = "A3",
                    Tag =  "A3_APC",
                    LineGuid = "bd9eae20-60c7-44cd-ae2e-96c5f015f82e",
                    TagGuid = "9f1aabaf-fc1e-437e-8af3-2e3e17aa4192"
                },
                new
                {
                    Line = "A4",
                    Tag =  "A4_M3_APC",
                    LineGuid = "77e6d96c-f58d-46ea-a00d-5f962cfaf67b",
                    TagGuid = "d81f4aca-b172-4e2d-b138-85fca35fdb48"
                },
                new
                {
                    Line = "A5",
                    Tag =  "A5_APC",
                    LineGuid = "c26e4341-8e94-48f8-9eb6-fd2c5061bae3",
                    TagGuid = "978337b6-98c6-4f65-97da-bed63b415e4a"
                },
                new
                {
                    Line = "A6",
                    Tag =  "A6_M2_APC",
                    LineGuid = "f5ede641-fb76-40d5-924b-5d28ceea1ac9",
                    TagGuid = "bb1862ce-201c-40b1-be25-c6f13f8ec6b1"
                },
                new
                {
                    Line = "A7",
                    Tag =  "A7_M3_APC",
                    LineGuid = "1ace746f-f44f-47c4-bb9c-6c49fc550488",
                    TagGuid = "e6273b83-641d-4669-8003-be5bdd928093"
                },
                new
                {
                    Line = "A8",
                    Tag =  "A8_APC",
                    LineGuid = "13667af3-8a37-456a-8d65-5e98627af1ad",
                    TagGuid = "d43a0be0-32cc-4e28-9f74-88d10c04b6a8"
                },
                new
                {
                    Line = "A9",
                    Tag =  "A9_M3_APC",
                    LineGuid = "3ea0d0fe-9c1b-4171-baa1-aa5b6e6422e2",
                    TagGuid = "61a26041-c823-427b-be03-9a10f37e344a"
                },
            };

            foreach (var tag in tags)
            {
                modelBuilder.Entity<KepServerTagNameGroup>().HasData(new KepServerTagNameGroup
                {
                    KepServerTagNameGroupId = new Guid(tag.LineGuid),
                    GroupName = tag.Line,
                    Department = "Assembly",
                    TimeStamp = DateTime.Now
                });

                modelBuilder.Entity<KepServerTagNameMonitor>().HasData(new KepServerTagNameMonitor
                {
                    Id = new Guid(tag.TagGuid),
                    KepServerTagNameGroupId = new Guid(tag.LineGuid),
                    TagName = tag.Tag,
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
