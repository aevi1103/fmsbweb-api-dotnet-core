using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Intranet;

namespace FmsbwebCoreApi.Context.Intranet
{
    public partial class IntranetContext : DbContext
    {
        public IntranetContext()
        {
        }

        public IntranetContext(DbContextOptions<IntranetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EolvsEos> EolvsEos { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopy2> FmsbMasterProdPartsCopy2 { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopyDashboard> FmsbMasterProdPartsCopyDashboard { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopyDashboardProgram> FmsbMasterProdPartsCopyDashboardProgram { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopyView> FmsbMasterProdPartsCopyView { get; set; }
        public virtual DbSet<FmsbMasterProdPartsFoundrySapScrap> FmsbMasterProdPartsFoundrySapScrap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=SBNDINMS002;Initial Catalog=FMO_Intranet;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.HasAnnotation("Relational:DefaultSchema", "db_owner");

            modelBuilder.Entity<EolvsEos>(entity =>
            {
                entity.Property(e => e.CoType).IsUnicode(false);

                entity.Property(e => e.Com).IsUnicode(false);

                entity.Property(e => e.DowntimeCom).IsUnicode(false);

                entity.Property(e => e.MachDef25).IsUnicode(false);

                entity.Property(e => e.QualityCom).IsUnicode(false);

                entity.Property(e => e.Shiftname).IsUnicode(false);

                entity.Property(e => e.Supervisor).IsUnicode(false);

                entity.Property(e => e.ToolChanged).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopy2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy2", "dbo");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.FoundryPart).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopyDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy_dashboard", "dbo");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopyDashboardProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy_dashboard_program", "dbo");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy_view", "dbo");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsFoundrySapScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_foundry_sapScrap", "dbo");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
