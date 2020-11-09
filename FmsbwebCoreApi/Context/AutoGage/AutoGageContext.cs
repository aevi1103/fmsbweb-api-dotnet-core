using Microsoft.EntityFrameworkCore;
using FmsbwebCoreApi.Entity.AutoGage;

namespace FmsbwebCoreApi.Context.AutoGage
{
    public partial class AutoGageContext : DbContext
    {
        public AutoGageContext()
        {
        }

        public AutoGageContext(DbContextOptions<AutoGageContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoGage2View> AutoGage2View { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoGage2View>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AutoGage2View");

                entity.Property(e => e.DefectFound).IsUnicode(false);

                entity.Property(e => e.DefectFoundHighSpec).IsUnicode(false);

                entity.Property(e => e.DefectFoundLowSpec).IsUnicode(false);

                entity.Property(e => e.DefectOnly).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Grade).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.MeasurementResult).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Part2).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
