using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;

namespace FmsbwebCoreApi.Context.Fmsb2
{
    public partial class Fmsb2Context : DbContext
    {
        public Fmsb2Context()
        {
        }

        public Fmsb2Context(DbContextOptions<Fmsb2Context> options)
            : base(options)
        {
        }

        #region refs
        public virtual DbSet<CreateHxHview> CreateHxHview { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DowntimeDataList2> DowntimeDataList2 { get; set; }
        public virtual DbSet<EmailNotification> EmailNotification { get; set; }
        public virtual DbSet<FinanceDailyKpi> FinanceDailyKpi { get; set; }
        public virtual DbSet<FinanceDeptFcst> FinanceDeptFcst { get; set; }
        public virtual DbSet<FinanceFlashProjections> FinanceFlashProjections { get; set; }
        public virtual DbSet<FinanceLaborHoursView> FinanceLaborHoursView { get; set; }
        public virtual DbSet<LogisticsCustomer> LogisticsCustomer { get; set; }
        public virtual DbSet<LogisticsDollars> LogisticsDollars { get; set; }
        public virtual DbSet<LogisticsInventory> LogisticsInventory { get; set; }
        public virtual DbSet<LogisticsParts> LogisticsParts { get; set; }
        public virtual DbSet<LogisticsInventoryCostType> LogisticsInventoryCostTypes { get; set; }
        public virtual DbSet<LogisticsInventoryCostTarget> LogisticsInventoryCostTargets { get; set; }
        public virtual DbSet<LogisticCustomerName> LogisticCustomerNames { get; set; }
        public virtual DbSet<LogisticsInventoryLocation> LogisticsInventoryLocations { get; set; }
        public virtual DbSet<MachineList> MachineList { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<DowntimeOwner> DowntimeOwner { get; set; }
        public virtual DbSet<EndOfShiftReport> EndOfShiftReports { get; set; }
        public virtual DbSet<HxHProd> HxHProd { get; set; }
        public virtual DbSet<KpiTarget> KpiTarget { get; set; }
        public virtual DbSet<SwotTargetWithDeptId> SwotTargetWithDeptId { get; set; }
        public virtual DbSet<Oee> Oee { get; set; }


        #endregion

        #region Drop

        //public virtual DbSet<ActionImprovementList> ActionImprovementList { get; set; }
        //public virtual DbSet<AssemblyChangeover> AssemblyChangeover { get; set; }
        //public virtual DbSet<Attachments> Attachments { get; set; }
        //public virtual DbSet<ChecksExist> ChecksExist { get; set; }
        //public virtual DbSet<CheckSheet> CheckSheet { get; set; }
        //public virtual DbSet<ChecksResultsList> ChecksResultsList { get; set; }
        //public virtual DbSet<ChecksheetResult> ChecksheetResult { get; set; }
        //public virtual DbSet<DashBoardPlannedDown> DashBoardPlannedDown { get; set; }
        //public virtual DbSet<DefectEscalation> DefectEscalation { get; set; }
        //public virtual DbSet<DefectEscalationList> DefectEscalationList { get; set; }
        //public virtual DbSet<DefectGroup> DefectGroup { get; set; }
        //public virtual DbSet<DepartmentalComments> DepartmentalComments { get; set; }
        //public virtual DbSet<DeptReferences> DeptReferences { get; set; }
        //public virtual DbSet<EnableDisableEscalation> EnableDisableEscalation { get; set; }
        //public virtual DbSet<EscalationLog> EscalationLog { get; set; }
        //public virtual DbSet<EscalationLog2> EscalationLog2 { get; set; }
        //public virtual DbSet<EscalationLogList> EscalationLogList { get; set; }
        //public virtual DbSet<EscalationMsg> EscalationMsg { get; set; }
        //public virtual DbSet<EscalationReactions> EscalationReactions { get; set; }
        //public virtual DbSet<EscalationEmailsNoti> EscalationEmailsNoti { get; set; }
        //public virtual DbSet<FoundryCellCounter> FoundryCellCounter { get; set; }
        //public virtual DbSet<HeatMapLoginRec> HeatMapLoginRec { get; set; }
        //public virtual DbSet<HeatMapValues> HeatMapValues { get; set; }
        //public virtual DbSet<Inspectors> Inspectors { get; set; }
        //public virtual DbSet<LineTwoBolscrap> LineTwoBolscrap { get; set; }
        //public virtual DbSet<MachineCycleTimeMasterEntries> MachineCycleTimeMasterEntries { get; set; }
        //public virtual DbSet<MachineCycleTimeMasterRefs> MachineCycleTimeMasterRefs { get; set; }
        //public virtual DbSet<MachineCycleTimeMasterView> MachineCycleTimeMasterView { get; set; }
        //public virtual DbSet<MmComments> MmComments { get; set; }
        //public virtual DbSet<MonitorScale> MonitorScale { get; set; }
        //public virtual DbSet<MorningMeetingCom> MorningMeetingCom { get; set; }
        //public virtual DbSet<ProductionIssuesActions> ProductionIssuesActions { get; set; }
        //public virtual DbSet<Users> Users { get; set; }
        //public virtual DbSet<AfNewhxhData> AfNewhxhData { get; set; }
        //public virtual DbSet<AfNewhxhDataPn> AfNewhxhDataPn { get; set; }
        //public virtual DbSet<AfProductionSummary> AfProductionSummary { get; set; }
        //public virtual DbSet<AnodizeScrap> AnodizeScrap { get; set; }
        //public virtual DbSet<AssyChangeover> AssyChangeover { get; set; }
        //public virtual DbSet<AssyScrap> AssyScrap { get; set; }
        //public virtual DbSet<CurrentGrossProdEolMach> CurrentGrossProdEolMach { get; set; }

        #endregion


        public virtual DbSet<ActualCycles> ActualCycles { get; set; }
        public virtual DbSet<AuthorizeClocks> AuthorizeClocks { get; set; }
        public virtual DbSet<CavityList> CavityList { get; set; }
        public virtual DbSet<CellCavities> CellCavities { get; set; }
        public virtual DbSet<CheckSheetList> CheckSheetList { get; set; }
        public virtual DbSet<ClockNumList> ClockNumList { get; set; }
        public virtual DbSet<ClockNumberListConcat> ClockNumberListConcat { get; set; }
        public virtual DbSet<ComponentAreaView> ComponentAreaView { get; set; }
        public virtual DbSet<ComponentGroup> ComponentGroup { get; set; }
        public virtual DbSet<ComponentRecords> ComponentRecords { get; set; }
        public virtual DbSet<ComponentRefList> ComponentRefList { get; set; }
        public virtual DbSet<ComponentReference> ComponentReference { get; set; }
        public virtual DbSet<ComponentScrapManualEntry> ComponentScrapManualEntry { get; set; }
        public virtual DbSet<ComponentTraceability> ComponentTraceability { get; set; }
        public virtual DbSet<ComponentTypeReference> ComponentTypeReference { get; set; }
        public virtual DbSet<ComponentTypes> ComponentTypes { get; set; }
        public virtual DbSet<ComponentView> ComponentView { get; set; }
        public virtual DbSet<CostCenterSap> CostCenterSap { get; set; }
        public virtual DbSet<CreateHourList> CreateHourList { get; set; }
        public virtual DbSet<CreateHourList2> CreateHourList2 { get; set; }
        public virtual DbSet<CreateHxH> CreateHxH { get; set; }
        public virtual DbSet<CycleTime> CycleTime { get; set; }
        public virtual DbSet<CycleTimeList> CycleTimeList { get; set; }
        public virtual DbSet<CycleTimeMachining> CycleTimeMachining { get; set; }
        public virtual DbSet<Cyclelossfoundry> Cyclelossfoundry { get; set; }
        public virtual DbSet<DailyDefectsTrend> DailyDefectsTrend { get; set; }
        public virtual DbSet<DefectArea> DefectArea { get; set; }
        public virtual DbSet<DefectList> DefectList { get; set; }
        public virtual DbSet<DefectListWithGross> DefectListWithGross { get; set; }
        public virtual DbSet<Defects> Defects { get; set; }
        public virtual DbSet<DepartmentProd> DepartmentProd { get; set; }
        public virtual DbSet<DeptReferences2> DeptReferences2 { get; set; }
        public virtual DbSet<DistinctHour> DistinctHour { get; set; }
        public virtual DbSet<Downtime> Downtime { get; set; }
        public virtual DbSet<DowntimeDataList> DowntimeDataList { get; set; }
        public virtual DbSet<DowntimeDataList2Copy> DowntimeDataList2Copy { get; set; }
        public virtual DbSet<DowntimeDataListFmsb2> DowntimeDataListFmsb2 { get; set; }
        public virtual DbSet<DowntimeListGuid> DowntimeListGuid { get; set; }
        public virtual DbSet<DowntimeReason1> DowntimeReason1 { get; set; }
        public virtual DbSet<DowntimeReason2> DowntimeReason2 { get; set; }
        public virtual DbSet<DowntimeReason21> DowntimeReason21 { get; set; }
        public virtual DbSet<DowntimeReportRecipient> DowntimeReportRecipient { get; set; }
        public virtual DbSet<DowntimeReportRecipients> DowntimeReportRecipients { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EosComments> EosComments { get; set; }
        public virtual DbSet<FinVerification> FinVerification { get; set; }
        public virtual DbSet<FinanceDailyInput> FinanceDailyInput { get; set; }
        public virtual DbSet<FinanceFigures> FinanceFigures { get; set; }
        public virtual DbSet<FinanceLaborHours> FinanceLaborHours { get; set; }
        public virtual DbSet<FinancePpmh> FinancePpmh { get; set; }
        public virtual DbSet<FinishingVerification> FinishingVerification { get; set; }
        public virtual DbSet<Fmparts> Fmparts { get; set; }
        public virtual DbSet<FoundryCastingParamAccess> FoundryCastingParamAccess { get; set; }
        public virtual DbSet<FoundryCellCounterView> FoundryCellCounterView { get; set; }
        public virtual DbSet<FoundryCycleLossList> FoundryCycleLossList { get; set; }
        public virtual DbSet<FoundryGraphSummary> FoundryGraphSummary { get; set; }
        public virtual DbSet<FoundryParamAttachments> FoundryParamAttachments { get; set; }
        public virtual DbSet<FoundryParamAttachmentsTemp> FoundryParamAttachmentsTemp { get; set; }
        public virtual DbSet<FoundryParamAttachmentsTemp2> FoundryParamAttachmentsTemp2 { get; set; }
        public virtual DbSet<FoundryParamCharView> FoundryParamCharView { get; set; }
        public virtual DbSet<FoundryParamCharacteristics> FoundryParamCharacteristics { get; set; }
        public virtual DbSet<FoundryParamGroups> FoundryParamGroups { get; set; }
        public virtual DbSet<FoundryParamSheetIds> FoundryParamSheetIds { get; set; }
        public virtual DbSet<FoundryParamSheetView> FoundryParamSheetView { get; set; }
        public virtual DbSet<FoundryParamSheets> FoundryParamSheets { get; set; }
        public virtual DbSet<FoundryProductionSummary> FoundryProductionSummary { get; set; }
        public virtual DbSet<FoundryScrap> FoundryScrap { get; set; }
        public virtual DbSet<FurnaceRebuild> FurnaceRebuild { get; set; }
        public virtual DbSet<FurnaceReplacement> FurnaceReplacement { get; set; }
        public virtual DbSet<FurnaceReplacementExt> FurnaceReplacementExt { get; set; }
        public virtual DbSet<FurnaceShellNumbers> FurnaceShellNumbers { get; set; }
        public virtual DbSet<GetAfParts> GetAfParts { get; set; }
        public virtual DbSet<GetmachParts> GetmachParts { get; set; }
        public virtual DbSet<HourByHour> HourByHour { get; set; }
        public virtual DbSet<HourByHourEscalationActions> HourByHourEscalationActions { get; set; }
        public virtual DbSet<HourReference> HourReference { get; set; }
        public virtual DbSet<HourbyHourListRefs> HourbyHourListRefs { get; set; }
        public virtual DbSet<HourlyProduction> HourlyProduction { get; set; }
        public virtual DbSet<HourlyScrapList> HourlyScrapList { get; set; }
        public virtual DbSet<HourlyScrapListWithCellSide> HourlyScrapListWithCellSide { get; set; }
        public virtual DbSet<HxhOpsClockNum> HxhOpsClockNum { get; set; }


        public virtual DbSet<LogisticsCommentsView> LogisticsCommentsView { get; set; }

        public virtual DbSet<LogisticsDollarsView> LogisticsDollarsView { get; set; }

        public virtual DbSet<LogisticsInventoryView> LogisticsInventoryView { get; set; }
        public virtual DbSet<LogisticsMm> LogisticsMm { get; set; }
        public virtual DbSet<LogisticsPartInv> LogisticsPartInv { get; set; }

        public virtual DbSet<LogisticsScrap> LogisticsScrap { get; set; }
        public virtual DbSet<MachLineLoadLog> MachLineLoadLog { get; set; }
        public virtual DbSet<MachProductionSummary> MachProductionSummary { get; set; }
        public virtual DbSet<MachScrap> MachScrap { get; set; }
        public virtual DbSet<MachToolBreakage> MachToolBreakage { get; set; }
        public virtual DbSet<MachToolBreakageEmailRecipients> MachToolBreakageEmailRecipients { get; set; }

        public virtual DbSet<MachineGroup> MachineGroup { get; set; }
        public virtual DbSet<MachineGroupList> MachineGroupList { get; set; }
        public virtual DbSet<MachineGroupNumber> MachineGroupNumber { get; set; }
        public virtual DbSet<MachineGroupNumberList> MachineGroupNumberList { get; set; }
        public virtual DbSet<MachineLineLoadLogList> MachineLineLoadLogList { get; set; }

        public virtual DbSet<MachineLookup> MachineLookup { get; set; }
        public virtual DbSet<MachineLookupView> MachineLookupView { get; set; }
        public virtual DbSet<MachineOwners> MachineOwners { get; set; }
        public virtual DbSet<MachinePartProd> MachinePartProd { get; set; }
        public virtual DbSet<MachineProd> MachineProd { get; set; }

        public virtual DbSet<MachiningCombineDowntimeAll> MachiningCombineDowntimeAll { get; set; }
        public virtual DbSet<MachiningDieNumber> MachiningDieNumber { get; set; }
        public virtual DbSet<MachiningToolBreakageView> MachiningToolBreakageView { get; set; }


        public virtual DbSet<OaeBootStrapClass> OaeBootStrapClass { get; set; }
        public virtual DbSet<OaeBootstrapClassView> OaeBootstrapClassView { get; set; }

        public virtual DbSet<OaeEmailRecipients> OaeEmailRecipients { get; set; }
        public virtual DbSet<OaeEscalationActions> OaeEscalationActions { get; set; }
        public virtual DbSet<OaeEscalationLog> OaeEscalationLog { get; set; }
        public virtual DbSet<OaeEscalationLogView> OaeEscalationLogView { get; set; }
        public virtual DbSet<OaeEscalationSetting> OaeEscalationSetting { get; set; }
        public virtual DbSet<OaeEscalationSettingsView> OaeEscalationSettingsView { get; set; }
        public virtual DbSet<OaeLevelGetterView> OaeLevelGetterView { get; set; }
        public virtual DbSet<OaeMachineOwners> OaeMachineOwners { get; set; }
        public virtual DbSet<OaeescalationLogActionsView> OaeescalationLogActionsView { get; set; }
        public virtual DbSet<ParallelMachinesMach> ParallelMachinesMach { get; set; }
        public virtual DbSet<ParallelMachinesMachList> ParallelMachinesMachList { get; set; }
        public virtual DbSet<PartRefs> PartRefs { get; set; }
        public virtual DbSet<Prod> Prod { get; set; }
        public virtual DbSet<ProdScrap> ProdScrap { get; set; }
        public virtual DbSet<ProdScrap2> ProdScrap2 { get; set; }

        public virtual DbSet<ProductionScrap> ProductionScrap { get; set; }
        public virtual DbSet<ProductionSummaryv2> ProductionSummaryv2 { get; set; }
        public virtual DbSet<ProductionSummaryv3> ProductionSummaryv3 { get; set; }
        public virtual DbSet<ProductionUnion> ProductionUnion { get; set; }
        public virtual DbSet<ProductionView> ProductionView { get; set; }
        public virtual DbSet<ProductionViewSummary> ProductionViewSummary { get; set; }
        public virtual DbSet<ProgramRefs> ProgramRefs { get; set; }
        public virtual DbSet<Pso> Pso { get; set; }
        public virtual DbSet<Reason1List> Reason1List { get; set; }
        public virtual DbSet<Reason2List> Reason2List { get; set; }
        public virtual DbSet<Reason2v2List> Reason2v2List { get; set; }
        public virtual DbSet<RemoveGradeReference> RemoveGradeReference { get; set; }
        public virtual DbSet<Resolution> Resolution { get; set; }
        public virtual DbSet<RodReclaim> RodReclaim { get; set; }
        public virtual DbSet<RodReclaimView> RodReclaimView { get; set; }
        public virtual DbSet<RouteMachineId> RouteMachineId { get; set; }
        public virtual DbSet<SapCompParts> SapCompParts { get; set; }
        public virtual DbSet<SapCompPartsBom> SapCompPartsBom { get; set; }
        public virtual DbSet<SapComponentScrapList> SapComponentScrapList { get; set; }
        public virtual DbSet<SapComponentScrapList1> SapComponentScrapList1 { get; set; }
        public virtual DbSet<SapCostCenter> SapCostCenter { get; set; }
        public virtual DbSet<SapscrapList> SapscrapList { get; set; }
        public virtual DbSet<ScrapHourRefs> ScrapHourRefs { get; set; }
        public virtual DbSet<ScrapHxh> ScrapHxh { get; set; }
        public virtual DbSet<ScrapHxhScrapUnion> ScrapHxhScrapUnion { get; set; }
        public virtual DbSet<ScrapRatesParts> ScrapRatesParts { get; set; }
        public virtual DbSet<ScrapRatesPartsFoundryCopy> ScrapRatesPartsFoundryCopy { get; set; }
        public virtual DbSet<ScrapRatesbyDefect> ScrapRatesbyDefect { get; set; }
        public virtual DbSet<ScrapRatesbyDefectFoundryCopy> ScrapRatesbyDefectFoundryCopy { get; set; }
        public virtual DbSet<ScrapSummary> ScrapSummary { get; set; }
        public virtual DbSet<ScrapView> ScrapView { get; set; }
        public virtual DbSet<ScrapViewLayout> ScrapViewLayout { get; set; }
        public virtual DbSet<ScrapViewName> ScrapViewName { get; set; }
        public virtual DbSet<Scscrap> Scscrap { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<SkirtCoatScreenLife> SkirtCoatScreenLife { get; set; }
        public virtual DbSet<SkirtCoatScreenView> SkirtCoatScreenView { get; set; }
        public virtual DbSet<SwotNetTargetEscalation> SwotNetTargetEscalation { get; set; }
        public virtual DbSet<SwotProfile> SwotProfile { get; set; }
        public virtual DbSet<SwotTargetEscalationView> SwotTargetEscalationView { get; set; }

        public virtual DbSet<SwotTargets> SwotTargets { get; set; }
        public virtual DbSet<TemporaryLevelGetterOae> TemporaryLevelGetterOae { get; set; }

        public virtual DbSet<TwentyFourHours> TwentyFourHours { get; set; }
        public virtual DbSet<SapBOM> SapBom { get; set; }

        public virtual DbSet<AnodizeChecklist> AnodizeChecklist { get; set; }
        public virtual DbSet<AnodizeChecklistEntries> AnodizeChecklistEntries { get; set; }
        public virtual DbSet<StockSafetyDays> StockSafetyDays { get; set; }
        public virtual DbSet<ProjectTracker> ProjectTracker { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.Entity<ActualCycles>(entity =>
            {
                entity.HasIndex(e => new { e.Hourid, e.HourNum })
                    .HasName("NonClusteredIndex-20171108-154232");
            });

            modelBuilder.Entity<AfNewhxhData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_newhxhData");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<AfNewhxhDataPn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_newhxhData_pn");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<AfProductionSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Af_ProductionSummary");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<AnodizeScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AnodizeScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<AssemblyChangeover>(entity =>
            {
                entity.Property(e => e.FromPart).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.ToPart).IsUnicode(false);
            });

            modelBuilder.Entity<AssyChangeover>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("assyChangeover");

                entity.Property(e => e.ClockNums).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.FromPart).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Question).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.ToPart).IsUnicode(false);

                entity.Property(e => e.YesNo).IsUnicode(false);
            });

            modelBuilder.Entity<AssyScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssyScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);
            });

            modelBuilder.Entity<AuthorizeClocks>(entity =>
            {
                entity.HasIndex(e => new { e.Clocknum, e.MachineId })
                    .HasName("NonClusteredIndex-20171108-154214");
            });

            modelBuilder.Entity<CavityList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CavityList");

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<CheckSheetList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CheckSheetList");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<ChecksExist>(entity =>
            {
                entity.Property(e => e.Page).IsUnicode(false);
            });

            modelBuilder.Entity<ChecksResultsList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChecksResultsList");

                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<ClockNumList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClockNumList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<ClockNumberListConcat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ClockNumberListConcat");

                entity.Property(e => e.ClockNums).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentAreaView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComponentAreaView");

                entity.Property(e => e.ClockNum).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentGroup>(entity =>
            {
                entity.Property(e => e.ComponentCategory).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentRecords>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentRefList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComponentRefList");

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentReference>(entity =>
            {
                entity.HasIndex(e => new { e.Defectid, e.Machineid })
                    .HasName("NonClusteredIndex-20171108-154302");

                entity.Property(e => e.Component).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentScrapManualEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComponentScrapManualEntry");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.ComponentCategory).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentTraceability>(entity =>
            {
                entity.Property(e => e.ComponentPart).IsUnicode(false);

                entity.Property(e => e.JulianDateCode).IsUnicode(false);

                entity.Property(e => e.LotNumber).IsUnicode(false);

                entity.Property(e => e.PistonPartOverride).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentTypeReference>(entity =>
            {
                entity.Property(e => e.ComponentId).IsUnicode(false);

                entity.Property(e => e.ComponentName).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentTypes>(entity =>
            {
                entity.Property(e => e.Component).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ComponentView");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.ComponentCategory).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<CostCenterSap>(entity =>
            {
                entity.Property(e => e.CostCenter).ValueGeneratedNever();

                entity.Property(e => e.Dept).IsUnicode(false);
            });

            modelBuilder.Entity<CreateHourList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CreateHourList");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<CreateHourList2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CreateHourList2");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<CreateHxH>(entity =>
            {
                entity.HasIndex(e => new { e.Deptid, e.Machineid })
                    .HasName("NonClusteredIndex-20171108-153906");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<CreateHxHview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CreateHxHView");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<HxHProd>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("hxhProd");
            });

            modelBuilder.Entity<CurrentGrossProdEolMach>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CurrentGrossProd_EOL_Mach");
            });

            modelBuilder.Entity<CycleTime>(entity =>
            {
                entity.HasIndex(e => new { e.MachineId, e.Part })
                    .HasName("NonClusteredIndex-20171108-154323");
            });

            modelBuilder.Entity<CycleTimeList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CycleTImeList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<CycleTimeMachining>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cycleTimeMachining");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<Cyclelossfoundry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("cyclelossfoundry");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Reason1).IsUnicode(false);

                entity.Property(e => e.Reason2).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DailyDefectsTrend>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DailyDefectsTrend");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DefectArea>(entity =>
            {
                entity.HasIndex(e => e.DefectArea1)
                    .HasName("NonClusteredIndex-20171108-154151");

                entity.Property(e => e.DefectArea1).IsUnicode(false);
            });

            modelBuilder.Entity<DefectEscalationList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DefectEscalationList");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<DefectList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DefectList");

                entity.Property(e => e.AreaDefect).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);
            });

            modelBuilder.Entity<DefectListWithGross>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DefectListWithGross");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<Defects>(entity =>
            {
                entity.HasIndex(e => new { e.DefectName, e.DefectAreaId })
                    .HasName("NonClusteredIndex-20171108-154131");

                entity.Property(e => e.DefectId).ValueGeneratedNever();

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.HasOne(d => d.DefectArea)
                    .WithMany(p => p.Defects)
                    .HasForeignKey(d => d.DefectAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Defects_DefectArea");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.DeptName)
                    .HasName("NonClusteredIndex-20171108-154106");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DepartmentProd");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentalComments>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Manager).IsUnicode(false);
            });

            modelBuilder.Entity<DeptReferences>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.DeptRef).IsUnicode(false);
            });

            modelBuilder.Entity<DeptReferences2>(entity =>
            {
                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.DeptLinkOldDb).IsUnicode(false);
            });

            modelBuilder.Entity<DistinctHour>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DistinctHour");
            });

            modelBuilder.Entity<Downtime>(entity =>
            {
                entity.HasIndex(e => new { e.HxhId, e.Reason1Id, e.Reason2Id, e.MachineGroupId, e.MachineNumberId })
                    .HasName("NonClusteredIndex-20171108-154431");
            });

            modelBuilder.Entity<DowntimeDataList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DowntimeDataList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeDataList2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DowntimeDataList2");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeDataList2Copy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeDataListFmsb2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DowntimeDataList_fmsb2");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeListGuid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DowntimeList_GUID");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeReason1>(entity =>
            {
                entity.HasIndex(e => e.DeptId)
                    .HasName("NonClusteredIndex-20171108-154512");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.DowntimeReason1)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DowntimeReason1_Department");
            });

            modelBuilder.Entity<DowntimeReason2>(entity =>
            {
                entity.HasIndex(e => e.DeptId)
                    .HasName("NonClusteredIndex-20171108-154528");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.DowntimeReason2)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DowntimeReason2_Department");
            });

            modelBuilder.Entity<DowntimeReason21>(entity =>
            {
                entity.HasIndex(e => new { e.Deptid, e.Reason1id, e.Reason2 })
                    .HasName("NonClusteredIndex-20171111-132126");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.DowntimeReason21)
                    .HasForeignKey(d => d.Deptid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DowntimeReason2.1_Department");

                entity.HasOne(d => d.Reason1)
                    .WithMany(p => p.DowntimeReason21)
                    .HasForeignKey(d => d.Reason1id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DowntimeReason2.1_DowntimeReason1");
            });

            modelBuilder.Entity<DowntimeReportRecipient>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<DowntimeReportRecipients>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<EmailNotification>(entity =>
            {
                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Employees");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<EosComments>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationEmailsNoti>(entity =>
            {
                entity.Property(e => e.AlarmType).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationLog>(entity =>
            {
                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationLog2>(entity =>
            {
                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationLogList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EscalationLogList");

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationMsg>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<EscalationReactions>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.ReactionComment).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceDailyInput>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceDailyKpi>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceDeptFcst>(entity =>
            {
                entity.Property(e => e.Dept).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceFigures>(entity =>
            {
                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceLaborHours>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FinanceLaborHoursView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Finance_LaborHours_View");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FinancePpmh>(entity =>
            {
                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Month).IsUnicode(false);

                entity.Property(e => e.Stamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FinishingVerification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FinishingVerification");

                entity.Property(e => e.ClockNums).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<Fmparts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMParts");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Sappart).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryCastingParamAccess>(entity =>
            {
                entity.Property(e => e.Access).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryCellCounterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryCellCounterView");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.ClockNums).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryCycleLossList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryCycleLossList");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Reason1).IsUnicode(false);

                entity.Property(e => e.Reason2).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryGraphSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryGraphSummary");

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamAttachments>(entity =>
            {
                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.ImageType).IsUnicode(false);

                entity.HasOne(d => d.FndryParam)
                    .WithMany(p => p.FoundryParamAttachments)
                    .HasForeignKey(d => d.FndryParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoundryParamAttachments_FoundryParamSheetIds");
            });

            modelBuilder.Entity<FoundryParamAttachmentsTemp>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageType).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamAttachmentsTemp2>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContentType).IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ImageType).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamCharView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryParamCharView");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamCharacteristics>(entity =>
            {
                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.FoundryParamCharacteristics)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoundryParamCharacteristics_FoundryParamGroups");
            });

            modelBuilder.Entity<FoundryParamGroups>(entity =>
            {
                entity.Property(e => e.GroupName).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamSheetView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryParamSheetView");

                entity.Property(e => e.Characteristics).IsUnicode(false);

                entity.Property(e => e.GroupName).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryParamSheets>(entity =>
            {
                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);

                entity.HasOne(d => d.Characteristic)
                    .WithMany(p => p.FoundryParamSheets)
                    .HasForeignKey(d => d.CharacteristicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoundryParamSheets_FoundryParamCharacteristics");

                entity.HasOne(d => d.Param)
                    .WithMany(p => p.FoundryParamSheets)
                    .HasForeignKey(d => d.ParamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoundryParamSheets_FoundryParamSheetIds");
            });

            modelBuilder.Entity<FoundryProductionSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Foundry_ProductionSummary");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<FoundryScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<FurnaceRebuild>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.ThingsToLookFor).IsUnicode(false);

                entity.HasOne(d => d.FurnaceShell)
                    .WithMany(p => p.FurnaceRebuild)
                    .HasForeignKey(d => d.FurnaceShellid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FurnaceRebuild_FurnaceShellNumbers");
            });

            modelBuilder.Entity<FurnaceReplacement>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UsedDays).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.FurnaceShell)
                    .WithMany(p => p.FurnaceReplacement)
                    .HasForeignKey(d => d.FurnaceShellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FurnaceReplacement_FurnaceShellNumbers");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.FurnaceReplacement)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FurnaceReplacement_Machines");
            });

            modelBuilder.Entity<FurnaceReplacementExt>(entity =>
            {
                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Side).IsUnicode(false);
            });

            modelBuilder.Entity<FurnaceShellNumbers>(entity =>
            {
                entity.Property(e => e.ShellNumber).IsUnicode(false);
            });

            modelBuilder.Entity<GetAfParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GetAfParts");
            });

            modelBuilder.Entity<GetmachParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("getmachParts");
            });

            modelBuilder.Entity<HeatMapLoginRec>(entity =>
            {
                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<HourByHour>(entity =>
            {
                entity.HasIndex(e => new { e.Hour, e.Pn, e.HourId })
                    .HasName("NonClusteredIndex-20171108-154610");

                entity.HasOne(d => d.HourNavigation)
                    .WithMany(p => p.HourByHour)
                    .HasForeignKey(d => d.HourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourByHour_CreateHxH");
            });

            modelBuilder.Entity<HourByHourEscalationActions>(entity =>
            {
                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Owner).IsUnicode(false);
            });

            modelBuilder.Entity<HourReference>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<HourbyHourListRefs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HourbyHourListRefs");

                entity.Property(e => e.BootstrapClass).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<HourlyProduction>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HourlyProduction");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<HourlyScrapList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HourlyScrapList");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<HourlyScrapListWithCellSide>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HourlyScrapList_withCellSide");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<HxhOpsClockNum>(entity =>
            {
                entity.HasOne(d => d.Hxh)
                    .WithMany(p => p.HxhOpsClockNum)
                    .HasForeignKey(d => d.Hxhid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HxhOpsClockNum_CreateHxH");
            });

            modelBuilder.Entity<LineTwoBolscrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("lineTwoBOLScrap");

                entity.Property(e => e.BCode).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsCommentsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("logisticsCommentsView");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Customer).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsCustomer>(entity =>
            {
                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Customer).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsDollars>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsDollarsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("logisticsDollarsView");

                entity.Property(e => e.Category).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsInventory>(entity =>
            {
                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsInventoryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("logisticsInventoryView");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);
            });

            modelBuilder.Entity<LogisticsParts>(entity =>
            {
                entity.Property(e => e.Part).IsUnicode(false);

                entity.Property(e => e.Program).IsUnicode(false);
            });

            modelBuilder.Entity<MachLineLoadLog>(entity =>
            {
                entity.Property(e => e.BCode).IsUnicode(false);

                entity.Property(e => e.Clorindo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gsa).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MachProductionSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mach_ProductionSummary");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachToolBreakage>(entity =>
            {
                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.SupervisorClock).IsUnicode(false);
            });

            modelBuilder.Entity<MachToolBreakageEmailRecipients>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PK_ToolBreakageEmailsRecipients");

                entity.Property(e => e.Email).IsUnicode(false);
            });

            modelBuilder.Entity<MachineCycleTimeMasterEntries>(entity =>
            {
                entity.Property(e => e.Stamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MachineCycleTimeMasterRefs>(entity =>
            {
                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Stamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MachineCycleTimeMasterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineCycleTimeMasterView");

                entity.Property(e => e.DayShift).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGroupList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineGroupList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGroupNumber>(entity =>
            {
                entity.Property(e => e.MachineNumber).IsUnicode(false);
            });

            modelBuilder.Entity<MachineGroupNumberList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineGroupNumberList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);
            });

            modelBuilder.Entity<MachineLineLoadLogList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineLineLoadLogList");

                entity.Property(e => e.Barcode).IsUnicode(false);

                entity.Property(e => e.BasketStartQty).IsUnicode(false);

                entity.Property(e => e.Cell).IsFixedLength();

                entity.Property(e => e.MachShift).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.SapPart).IsUnicode(false);
            });

            modelBuilder.Entity<MachineList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineMapper).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<MachineLookupView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineLookupView");

                entity.Property(e => e.MainMachine).IsUnicode(false);

                entity.Property(e => e.RefMachine).IsUnicode(false);
            });

            modelBuilder.Entity<MachineOwners>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineOwners");

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<MachinePartProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachinePartProd");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachineProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachineProd");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<Machines>(entity =>
            {
                entity.HasIndex(e => new { e.MachineName, e.DeptId })
                    .HasName("NonClusteredIndex-20171108-153956");

                entity.Property(e => e.MachineMapper).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Machines)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Machines_Department");
            });

            modelBuilder.Entity<MachiningCombineDowntimeAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachiningCombineDowntimeAll");

                entity.Property(e => e.DtEntry).IsUnicode(false);

                entity.Property(e => e.MachName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<MachiningDieNumber>(entity =>
            {
                entity.Property(e => e.DieNumber).IsUnicode(false);
            });

            modelBuilder.Entity<MachiningToolBreakageView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MachiningToolBreakageView");

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.SupervisorClock).IsUnicode(false);
            });

            modelBuilder.Entity<MmComments>(entity =>
            {
                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Issue).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MorningMeetingCom>(entity =>
            {
                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.Issue).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<OaeBootStrapClass>(entity =>
            {
                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<OaeBootstrapClassView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("oaeBootstrapClass_View");

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<OaeEmailRecipients>(entity =>
            {
                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<OaeEscalationLogView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OaeEscalationLogView");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<OaeEscalationSettingsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OaeEscalationSettings_view");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<OaeLevelGetterView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OaeLevelGetterView");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<OaeescalationLogActionsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OAEEscalationLogActionsView");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ParallelMachinesMachList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ParallelMachines_MachList");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MachineNumber).IsUnicode(false);
            });

            modelBuilder.Entity<PartRefs>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Prod>(entity =>
            {
                entity.Property(e => e.Approved).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Prod)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_Department");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Prod)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_Machines");

                entity.HasOne(d => d.ShiftNavigation)
                    .WithMany(p => p.Prod)
                    .HasForeignKey(d => d.Shift)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prod_Shift");
            });

            modelBuilder.Entity<ProdScrap>(entity =>
            {
                entity.Property(e => e.Shift).IsUnicode(false);

                entity.HasOne(d => d.DefectArea)
                    .WithMany(p => p.ProdScrap)
                    .HasForeignKey(d => d.DefectAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdScrap_DefectArea");

                entity.HasOne(d => d.Defect)
                    .WithMany(p => p.ProdScrap)
                    .HasForeignKey(d => d.DefectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdScrap_Defects");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ProdScrap)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdScrap_Department");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ProdScrap)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdScrap_Machines");

                entity.HasOne(d => d.ShiftNavigation)
                    .WithMany(p => p.ProdScrap)
                    .HasForeignKey(d => d.Shift)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdScrap_Shift");
            });

            modelBuilder.Entity<ProdScrap2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProdScrap2");

                entity.Property(e => e.AssyLoad).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionIssuesActions>(entity =>
            {
                entity.Property(e => e.Actions).IsUnicode(false);

                entity.Property(e => e.Issue).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionSummaryv2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionSummaryv2");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionSummaryv3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionSummaryv3");

                entity.Property(e => e.CellSide).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionUnion");

                entity.Property(e => e.CellSideFoundry).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionView");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MainMachine).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ProductionViewSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductionViewSummary");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MainMachine).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<Pso>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Reason1List>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reason1List");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<Reason2List>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Reason2List");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<Reason2v2List>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("reason2v2List");

                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<RemoveGradeReference>(entity =>
            {
                entity.Property(e => e.Partwithsuffix).IsUnicode(false);

                entity.Property(e => e.Part).IsUnicode(false);
            });

            modelBuilder.Entity<Resolution>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Resolution");

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Resolution1).IsUnicode(false);
            });

            modelBuilder.Entity<RodReclaim>(entity =>
            {
                entity.Property(e => e.ClockNum).IsUnicode(false);

                entity.Property(e => e.PartNum).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<RodReclaimView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RodReclaimView");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.ComponentCategory).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);
            });

            modelBuilder.Entity<SapCompParts>(entity =>
            {
                entity.Property(e => e.SapCompPart).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<SapCompPartsBom>(entity =>
            {
                entity.Property(e => e.FmPart).IsUnicode(false);

                entity.Property(e => e.P1a).IsUnicode(false);

                entity.Property(e => e.SadDesc).IsUnicode(false);

                entity.Property(e => e.SapPart).IsUnicode(false);
            });

            modelBuilder.Entity<SapComponentScrapList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SapComponentScrapList");

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Sappart).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SapComponentScrapList1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SapComponentScrapList1");

                entity.Property(e => e.Component).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Sappart).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Stat).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SapscrapList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAPScrapList");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Sappart).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapHourRefs>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScrapHourRefs");

                entity.Property(e => e.HtmlInputId).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapHxh>(entity =>
            {
                entity.HasIndex(e => new { e.Hxhid, e.Defectid, e.HourNum })
                    .HasName("NonClusteredIndex-20171108-153825");

                entity.HasOne(d => d.Hxh)
                    .WithMany(p => p.ScrapHxh)
                    .HasForeignKey(d => d.Hxhid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapHxh_CreateHxH");
            });

            modelBuilder.Entity<ScrapHxhScrapUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap_hxh_scrap_union");

                entity.Property(e => e.AssyLoad).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Page).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapRatesParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScrapRatesParts");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapRatesPartsFoundryCopy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Pn).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Shiftdate).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapRatesbyDefect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScrapRatesbyDefect");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapRatesbyDefectFoundryCopy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScrapSummary");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DeptRef).IsUnicode(false);

                entity.Property(e => e.GrossScrapRef).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<ScrapView>(entity =>
            {
                entity.HasIndex(e => new { e.DeptId, e.DefectAreaId, e.DefectId, e.MachineId, e.ViewName })
                    .HasName("NonClusteredIndex-20171108-154704");

                entity.HasOne(d => d.DefectArea)
                    .WithMany(p => p.ScrapView)
                    .HasForeignKey(d => d.DefectAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapView_DefectArea");

                entity.HasOne(d => d.Defect)
                    .WithMany(p => p.ScrapView)
                    .HasForeignKey(d => d.DefectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapView_Defects");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ScrapView)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapView_Department");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ScrapView)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScrapView_Machines");

                entity.HasOne(d => d.ViewNameNavigation)
                    .WithMany(p => p.ScrapView)
                    .HasForeignKey(d => d.ViewName)
                    .HasConstraintName("FK_ScrapView_ScrapViewName");
            });

            modelBuilder.Entity<ScrapViewLayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ScrapViewLayout");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.AreaDefect).IsUnicode(false);

                entity.Property(e => e.Defect).IsUnicode(false);

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.HtmlInputId).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);
            });

            modelBuilder.Entity<Scscrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SCScrap");

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.DefectName).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.Property(e => e.Shift1).IsUnicode(false);
            });

            modelBuilder.Entity<SkirtCoatScreenLife>(entity =>
            {
                entity.Property(e => e.JulianDate).IsUnicode(false);

                entity.Property(e => e.MeshColor).IsUnicode(false);

                entity.Property(e => e.MeshNumber).IsUnicode(false);

                entity.Property(e => e.RemovalReason).IsUnicode(false);

                entity.Property(e => e.RevDate).IsUnicode(false);

                entity.Property(e => e.ScrapReason).IsUnicode(false);

                entity.Property(e => e.ScreenPartNum).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SkirtCoatScreenView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkirtCoatScreenView");

                entity.Property(e => e.ClockNums).IsUnicode(false);

                entity.Property(e => e.JulianDate).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);

                entity.Property(e => e.MeshColor).IsUnicode(false);

                entity.Property(e => e.MeshNumber).IsUnicode(false);

                entity.Property(e => e.RemovalReason).IsUnicode(false);

                entity.Property(e => e.RevDate).IsUnicode(false);

                entity.Property(e => e.ScrapReason).IsUnicode(false);

                entity.Property(e => e.ScreenPartNum).IsUnicode(false);

                entity.Property(e => e.Shift).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SwotNetTargetEscalation>(entity =>
            {
                entity.Property(e => e.EmailRecipients).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SwotProfile>(entity =>
            {
                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Lines).IsUnicode(false);

                entity.Property(e => e.Profile).IsUnicode(false);
            });

            modelBuilder.Entity<SwotTargetEscalationView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SWOT_TargetEscalationView");

                entity.Property(e => e.EmailRecipients).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SwotTargetWithDeptId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SWOT_Target_WithDeptId");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.MachineName).IsUnicode(false);
            });

            modelBuilder.Entity<SwotTargets>(entity =>
            {
                entity.Property(e => e.IsPriority).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Shift).IsUnicode(false);
            });

            modelBuilder.Entity<TwentyFourHours>(entity =>
            {
                entity.HasNoKey();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
