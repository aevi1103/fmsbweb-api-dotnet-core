using System;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=SBNDINMS002;Initial Catalog=Iconics;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder
                            ?? throw new ArgumentNullException(nameof(modelBuilder));

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
