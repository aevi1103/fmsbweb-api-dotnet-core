using System;
using System.Collections.Generic;
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
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<OperatorJob> OperatorJobs { get; set; }
        public virtual DbSet<EolManning> EolManning { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OperatorJob>().HasData(new OperatorJob { OperatorJobId = 1, Job = "Okuma Operator", TimeStamp = DateTime.Now });
            modelBuilder.Entity<OperatorJob>().HasData(new OperatorJob { OperatorJobId = 2, Job = "Diamond Turn Operator", TimeStamp = DateTime.Now });

            var operators = new List<Operator>
            {
                new Operator {FirstName = "Kevin", LastName = "Dimmett"},
                new Operator {FirstName = "Pedro", LastName = "Anglero"},
                new Operator {FirstName = "Joe", LastName = "Stroud"},
                new Operator {FirstName = "Ritchard", LastName = "Krouse"},
                new Operator {FirstName = "Gregory", LastName = "Kuzmits"},
                new Operator {FirstName = "Nick", LastName = "Powers"},
                new Operator {FirstName = "Bryan", LastName = "Crowner"},
                new Operator {FirstName = "Kenny", LastName = "Plencner"},
                new Operator {FirstName = "Michael", LastName = "Plencner"},
                new Operator {FirstName = "Paula", LastName = "Smith"},
                new Operator {FirstName = "Gary", LastName = "Westerhouse"},
                new Operator {FirstName = "Steve", LastName = "Ehardt"},
                new Operator {FirstName = "Rollie", LastName = "Ball"},
                new Operator {FirstName = "Curt", LastName = "Webb"},
                new Operator {FirstName = "Kevin", LastName = "Rossaw"},
                new Operator {FirstName = "Scott", LastName = "Higbee"},
                new Operator {FirstName = "Joe", LastName = "Kil"},
                new Operator {FirstName = "Tracey", LastName = "Smith"},
                new Operator {FirstName = "Dale", LastName = "Beghtel"}
            };

            for (var i = 0; i < operators.Count; i++)
            {
                var op = operators[i];
                op.OperatorId = i+1;
                op.TimeStamp = DateTime.Now;
                modelBuilder.Entity<Operator>().HasData(op);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            SeedData(modelBuilder);

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
