using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Context.SAP
{
    public partial class SapContext : DbContext
    {
        public SapContext()
        {
        }

        public SapContext(DbContextOptions<SapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AutoGageScrapCodes> AutoGageScrapCodes { get; set; }
        public virtual DbSet<AvgShipDayPart> AvgShipDayPart { get; set; }
        public virtual DbSet<DistictAreas> DistictAreas { get; set; }
        public virtual DbSet<DistinctPrograms> DistinctPrograms { get; set; }
        public virtual DbSet<DistinctScrap> DistinctScrap { get; set; }
        public virtual DbSet<DmaxParts> DmaxParts { get; set; }
        public virtual DbSet<EscalationMessage> EscalationMessage { get; set; }
        public virtual DbSet<EscalationRecipients> EscalationRecipients { get; set; }
        public virtual DbSet<ExcludedProgram> ExcludedProgram { get; set; }
        public virtual DbSet<InvProgramTargets> InvProgramTargets { get; set; }
        public virtual DbSet<KpiTargets> KpiTargets { get; set; }
        public virtual DbSet<MachineMapping> MachineMapping { get; set; }
        public virtual DbSet<Production> Production { get; set; }
        public virtual DbSet<Production2> Production2 { get; set; }
        public virtual DbSet<Production2Summary> Production2Summary { get; set; }
        public virtual DbSet<Production2SummaryShift> Production2SummaryShift { get; set; }
        public virtual DbSet<ProductionTemp> ProductionTemp { get; set; }
        public virtual DbSet<RawMatInv> RawMatInv { get; set; }
        public virtual DbSet<SapDump2> SapDump2 { get; set; }
        public virtual DbSet<SapDumpNew> SapDumpNew { get; set; }
        public virtual DbSet<SapDumpNewUnpivot> SapDumpNewUnpivot { get; set; }
        public virtual DbSet<SapDumpNewView> SapDumpNewView { get; set; }
        public virtual DbSet<SapDumpNewView2> SapDumpNewView2 { get; set; }
        public virtual DbSet<SapDumpView2> SapDumpView2 { get; set; }
        public virtual DbSet<SapProd> SapProd { get; set; }
        public virtual DbSet<SapProdOrders> SapProdOrders { get; set; }
        public virtual DbSet<SapScrapView> SapScrapView { get; set; }
        public virtual DbSet<SapscrapWithShiftDates> SapscrapWithShiftDates { get; set; }
        public virtual DbSet<Scrap> Scrap { get; set; }
        public virtual DbSet<Scrap2> Scrap2 { get; set; }
        public virtual DbSet<Scrap2Summary> Scrap2Summary { get; set; }
        public virtual DbSet<Scrap2Summary2> Scrap2Summary2 { get; set; }
        public virtual DbSet<Scrap2SummaryByHour> Scrap2SummaryByHour { get; set; }
        public virtual DbSet<Scrap2SummaryByHourOperationNumber> Scrap2SummaryByHourOperationNumber { get; set; }
        public virtual DbSet<Scrap2SummaryInputMaterial> Scrap2SummaryInputMaterial { get; set; }
        public virtual DbSet<Scrap2SummaryMos> Scrap2SummaryMos { get; set; }
        public virtual DbSet<ScrapAreaCode> ScrapAreaCode { get; set; }
        public virtual DbSet<ScrapEscalation> ScrapEscalation { get; set; }
        public virtual DbSet<ScrapEscalationLog> ScrapEscalationLog { get; set; }
        public virtual DbSet<ScrapTemp> ScrapTemp { get; set; }
        public virtual DbSet<SlocOrder> SlocOrder { get; set; }
        public virtual DbSet<ViewPrograms> ViewPrograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=SBNDINMS007;Initial Catalog=SAP_Imports;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AutoGageScrapCodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AutoGageScrapCodes");

                entity.Property(e => e.Defect).IsUnicode(false);
            });

            modelBuilder.Entity<AvgShipDayPart>(entity =>
            {
                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.AvgShipDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Show).HasDefaultValueSql("((1))");

                entity.Property(e => e.SkidQty).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DistictAreas>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DistictAreas");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<DistinctPrograms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DistinctPrograms");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);
            });

            modelBuilder.Entity<DistinctScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DistinctScrap");

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);
            });

            modelBuilder.Entity<DmaxParts>(entity =>
            {
                entity.Property(e => e.MaterialDmax).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationMessage>(entity =>
            {
                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationRecipients>(entity =>
            {
                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.EmailRecipients).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ExcludedProgram>(entity =>
            {
                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.Stamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<InvProgramTargets>(entity =>
            {
                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.Sloc).IsUnicode(false);
            });

            modelBuilder.Entity<KpiTargets>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DeptId).IsUnicode(false);

                entity.Property(e => e.Kpi).IsUnicode(false);
            });

            modelBuilder.Entity<MachineMapping>(entity =>
            {
                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MachineMapping1).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);
            });

            modelBuilder.Entity<Production>(entity =>
            {
                entity.Property(e => e.EnteredTime).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.ExportFileName).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.UoM).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Production2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Production2");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Production2Summary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Production2_Summary");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<Production2SummaryShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Production2_Summary_Shift");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionTemp>(entity =>
            {
                entity.Property(e => e.EnteredTime).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.ExportFileName).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.UoM).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<RawMatInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RawMatInv");

                entity.Property(e => e.First).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.MaterialDescription).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.TypeSap).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDump2>(entity =>
            {
                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.MaterialDescription).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDumpNew>(entity =>
            {
                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.MaterialDescription).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDumpNewUnpivot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAP_Dump_New_Unpivot");

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDumpNewView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAP_Dump_New_View");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.MaterialDescription).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.TypeSap).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDumpNewView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAP_Dump_New_View2");

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapDumpView2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sapDumpView2");

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.MaterialDescription).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.ValuationClass).IsUnicode(false);
            });

            modelBuilder.Entity<SapProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SapProd");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.Material).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<SapProdOrders>(entity =>
            {
                entity.Property(e => e.ActFinishTimeExecutn).IsUnicode(false);

                entity.Property(e => e.ActStartDateExecution).IsUnicode(false);

                entity.Property(e => e.Activity).IsUnicode(false);

                entity.Property(e => e.OperationUnit).IsUnicode(false);

                entity.Property(e => e.OperationsShortText).IsUnicode(false);

                entity.Property(e => e.SystemStatus).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<SapScrapView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SapScrapView");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.UkTime).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<SapscrapWithShiftDates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAPScrapWithShiftDates");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap>(entity =>
            {
                entity.Property(e => e.EnteredTime).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.ExportFileName).IsUnicode(false);

                entity.Property(e => e.InputMaterialNumber).IsUnicode(false);

                entity.Property(e => e.IsPurchashed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPurchashedExclude).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumberLoc).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.ScrapGroup).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.InputMaterialNumber).IsUnicode(false);

                entity.Property(e => e.IsAutoGaugeScrap2).IsUnicode(false);

                entity.Property(e => e.IsPurchashedExclude2).IsUnicode(false);

                entity.Property(e => e.Ispurchashed2).IsUnicode(false);

                entity.Property(e => e.Machine2).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumberLoc).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2Summary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_Summary");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2Summary2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_Summary2");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.InputMaterialNumber).IsUnicode(false);

                entity.Property(e => e.IsAutoGaugeScrap2).IsUnicode(false);

                entity.Property(e => e.IsPurchashedExclude2).IsUnicode(false);

                entity.Property(e => e.Ispurchashed2).IsUnicode(false);

                entity.Property(e => e.Machine2).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumberLoc).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2SummaryByHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_SummaryByHour");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.Machine2).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2SummaryByHourOperationNumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_SummaryByHour_OperationNumber");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.Machine2).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumberLoc).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2SummaryInputMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_Summary_InputMaterial");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.InputMaterialNumber).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Scrap2SummaryMos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap2_Summary_mos");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.MachineHxh).IsUnicode(false);

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.ScrapAreaCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapAreaCode>(entity =>
            {
                entity.Property(e => e.ScrapAreaCode1).ValueGeneratedNever();

                entity.Property(e => e.ColorCode).IsUnicode(false);

                entity.Property(e => e.ScrapAreaName).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapEscalation>(entity =>
            {
                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.HasOne(d => d.EscalationMsg)
                    .WithMany(p => p.ScrapEscalation)
                    .HasForeignKey(d => d.EscalationMsgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapEscalations_EscalationMessage");

                entity.HasOne(d => d.EscalationRecipient)
                    .WithMany(p => p.ScrapEscalation)
                    .HasForeignKey(d => d.EscalationRecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapEscalations_EscalationRecipients");
            });

            modelBuilder.Entity<ScrapEscalationLog>(entity =>
            {
                entity.Property(e => e.AcknowledgeComment).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);

                entity.HasOne(d => d.ScrapEscalation)
                    .WithMany(p => p.ScrapEscalationLog)
                    .HasForeignKey(d => d.ScrapEscalationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapEscalationLog_Scrap_Escalation");
            });

            modelBuilder.Entity<ScrapTemp>(entity =>
            {
                entity.Property(e => e.EnteredTime).IsUnicode(false);

                entity.Property(e => e.EnteredUser).IsUnicode(false);

                entity.Property(e => e.ExportFileName).IsUnicode(false);

                entity.Property(e => e.InputMaterialNumber).IsUnicode(false);

                entity.Property(e => e.IsPurchashed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPurchashedExclude).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumber).IsUnicode(false);

                entity.Property(e => e.OperationNumberLoc).IsUnicode(false);

                entity.Property(e => e.ScrapCode).IsUnicode(false);

                entity.Property(e => e.ScrapDesc).IsUnicode(false);

                entity.Property(e => e.ScrapGroup).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Uom).IsUnicode(false);

                entity.Property(e => e.WorkCenter).IsUnicode(false);
            });

            modelBuilder.Entity<SlocOrder>(entity =>
            {
                entity.Property(e => e.Sloc).IsUnicode(false);

                entity.Property(e => e.Slocname).IsUnicode(false);
            });

            modelBuilder.Entity<ViewPrograms>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Programs");

                entity.Property(e => e.Program).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
