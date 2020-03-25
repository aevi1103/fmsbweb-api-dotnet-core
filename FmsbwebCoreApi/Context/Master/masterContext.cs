using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FmsbwebCoreApi.Entity.Master;

namespace FmsbwebCoreApi.Context.Master
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AFDailyOutputProgram> AFDailyOutputProgram { get; set; }
        public virtual DbSet<AfAll> AfAll { get; set; }
        public virtual DbSet<AfAllAnod> AfAllAnod { get; set; }
        public virtual DbSet<AfAllAssy> AfAllAssy { get; set; }
        public virtual DbSet<AfAllEos> AfAllEos { get; set; }
        public virtual DbSet<AfAllEosUnion> AfAllEosUnion { get; set; }
        public virtual DbSet<AfAllEosUnion2> AfAllEosUnion2 { get; set; }
        public virtual DbSet<AfAllEosUnion2Transferred> AfAllEosUnion2Transferred { get; set; }
        public virtual DbSet<AfAllEosUnion3> AfAllEosUnion3 { get; set; }
        public virtual DbSet<AfAllMachineDowntime> AfAllMachineDowntime { get; set; }
        public virtual DbSet<AfAllSc> AfAllSc { get; set; }
        public virtual DbSet<AfAllUnion> AfAllUnion { get; set; }
        public virtual DbSet<AfAllUnion2> AfAllUnion2 { get; set; }
        public virtual DbSet<AfAnodDowntime> AfAnodDowntime { get; set; }
        public virtual DbSet<AfAnodDowntime2> AfAnodDowntime2 { get; set; }
        public virtual DbSet<AfAssyDowntime> AfAssyDowntime { get; set; }
        public virtual DbSet<AfManningView> AfManningView { get; set; }
        public virtual DbSet<AfManningdataentry> AfManningdataentry { get; set; }
        public virtual DbSet<AfOaeOeeEos> AfOaeOeeEos { get; set; }
        public virtual DbSet<AfOaeOeeEosTransfered> AfOaeOeeEosTransfered { get; set; }
        public virtual DbSet<AfOaeProgram> AfOaeProgram { get; set; }
        public virtual DbSet<AfOaeProgram2> AfOaeProgram2 { get; set; }
        public virtual DbSet<AfScDowntime> AfScDowntime { get; set; }
        public virtual DbSet<AfScDowntime2> AfScDowntime2 { get; set; }
        public virtual DbSet<AfmanningSummary> AfmanningSummary { get; set; }
        public virtual DbSet<AnodizeDefectHistory> AnodizeDefectHistory { get; set; }
        public virtual DbSet<AnodizeDefectHistory2> AnodizeDefectHistory2 { get; set; }
        public virtual DbSet<AsmSwitchboard> AsmSwitchboard { get; set; }
        public virtual DbSet<AssemblyDefectHistory> AssemblyDefectHistory { get; set; }
        public virtual DbSet<AssemblyScrapRate> AssemblyScrapRate { get; set; }
        public virtual DbSet<AssyComponentList> AssyComponentList { get; set; }
        public virtual DbSet<AssyComponentScrap> AssyComponentScrap { get; set; }
        public virtual DbSet<ComponentViewScrap> ComponentViewScrap { get; set; }
        public virtual DbSet<DeptLineRefs> DeptLineRefs { get; set; }
        public virtual DbSet<DieShotHistory> DieShotHistory { get; set; }
        public virtual DbSet<DtTables> DtTables { get; set; }
        public virtual DbSet<EooDefectsList> EooDefectsList { get; set; }
        public virtual DbSet<EooExcelDownload> EooExcelDownload { get; set; }
        public virtual DbSet<EooTotalView> EooTotalView { get; set; }
        public virtual DbSet<EooUpstreamScrap> EooUpstreamScrap { get; set; }
        public virtual DbSet<EosA2> EosA2 { get; set; }
        public virtual DbSet<EosA3> EosA3 { get; set; }
        public virtual DbSet<EosA4> EosA4 { get; set; }
        public virtual DbSet<EosA5> EosA5 { get; set; }
        public virtual DbSet<EosA6> EosA6 { get; set; }
        public virtual DbSet<EosA7> EosA7 { get; set; }
        public virtual DbSet<EosA8> EosA8 { get; set; }
        public virtual DbSet<EosAnod> EosAnod { get; set; }
        public virtual DbSet<EosAssy> EosAssy { get; set; }
        public virtual DbSet<EosSc> EosSc { get; set; }
        public virtual DbSet<FmConvertSapPart> FmConvertSapPart { get; set; }
        public virtual DbSet<FmsbMasterDefects> FmsbMasterDefects { get; set; }
        public virtual DbSet<FmsbMasterDefectsCopy> FmsbMasterDefectsCopy { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopyView> FmsbMasterProdPartsCopyView { get; set; }
        public virtual DbSet<FmsbMasterProdPartsCopyViewL3Gmet4> FmsbMasterProdPartsCopyViewL3Gmet4 { get; set; }
        public virtual DbSet<Foundry5FsDefectView> Foundry5FsDefectView { get; set; }
        public virtual DbSet<Foundry5PartsView> Foundry5PartsView { get; set; }
        public virtual DbSet<FoundryDefectRates> FoundryDefectRates { get; set; }
        public virtual DbSet<FoundryDefectRates2> FoundryDefectRates2 { get; set; }
        public virtual DbSet<FoundryDieShotCounts> FoundryDieShotCounts { get; set; }
        public virtual DbSet<FoundryDieShotCountsUnfiltered> FoundryDieShotCountsUnfiltered { get; set; }
        public virtual DbSet<FoundryEooDefectEos> FoundryEooDefectEos { get; set; }
        public virtual DbSet<FoundryEooPartsEos> FoundryEooPartsEos { get; set; }
        public virtual DbSet<FoundryEoodefectHistory> FoundryEoodefectHistory { get; set; }
        public virtual DbSet<Gp12DefectList> Gp12DefectList { get; set; }
        public virtual DbSet<Gp12Parts> Gp12Parts { get; set; }
        public virtual DbSet<Gp12PartsInsected> Gp12PartsInsected { get; set; }
        public virtual DbSet<Gp12ScrapData> Gp12ScrapData { get; set; }
        public virtual DbSet<Gp12ScrapView> Gp12ScrapView { get; set; }
        public virtual DbSet<MachEooDefect> MachEooDefect { get; set; }
        public virtual DbSet<ManningAllDept> ManningAllDept { get; set; }
        public virtual DbSet<MhAfoeeData> MhAfoeeData { get; set; }
        public virtual DbSet<MhOnlineComments> MhOnlineComments { get; set; }
        public virtual DbSet<MhTblCurrentParts> MhTblCurrentParts { get; set; }
        public virtual DbSet<MhTblCycleTimes> MhTblCycleTimes { get; set; }
        public virtual DbSet<MhView> MhView { get; set; }
        public virtual DbSet<MmAf> MmAf { get; set; }
        public virtual DbSet<MrrEosLink> MrrEosLink { get; set; }
        public virtual DbSet<MrrscrapDetails> MrrscrapDetails { get; set; }
        public virtual DbSet<MrrscrapView> MrrscrapView { get; set; }
        public virtual DbSet<Mrrview> Mrrview { get; set; }
        public virtual DbSet<PrAfonly> PrAfonly { get; set; }
        public virtual DbSet<PrAfonlyFilter> PrAfonlyFilter { get; set; }
        public virtual DbSet<SapAfScrapUpload> SapAfScrapUpload { get; set; }
        public virtual DbSet<Sbndinnt01FmoMasterDboTblAssembly7> Sbndinnt01FmoMasterDboTblAssembly7 { get; set; }
        public virtual DbSet<ScrapTopAnod> ScrapTopAnod { get; set; }
        public virtual DbSet<ScrapTopAssy> ScrapTopAssy { get; set; }
        public virtual DbSet<ScrapTopSc> ScrapTopSc { get; set; }
        public virtual DbSet<Sheet2> Sheet2 { get; set; }
        public virtual DbSet<ShiftlyA2> ShiftlyA2 { get; set; }
        public virtual DbSet<ShiftlyA3> ShiftlyA3 { get; set; }
        public virtual DbSet<ShiftlyA6> ShiftlyA6 { get; set; }
        public virtual DbSet<ShiftlyA7> ShiftlyA7 { get; set; }
        public virtual DbSet<ShiftlyAnod> ShiftlyAnod { get; set; }
        public virtual DbSet<ShiftlyNewAssyAll> ShiftlyNewAssyAll { get; set; }
        public virtual DbSet<ShiftlySc> ShiftlySc { get; set; }
        public virtual DbSet<ShiftyA4> ShiftyA4 { get; set; }
        public virtual DbSet<ShiftyA5> ShiftyA5 { get; set; }
        public virtual DbSet<ShiftyA8> ShiftyA8 { get; set; }
        public virtual DbSet<SkirtCoatDailyView> SkirtCoatDailyView { get; set; }
        public virtual DbSet<SkirtCoatDefectHistory> SkirtCoatDefectHistory { get; set; }
        public virtual DbSet<SkirtCoatDefectHistory2> SkirtCoatDefectHistory2 { get; set; }
        public virtual DbSet<SkirtCoatScrapParts> SkirtCoatScrapParts { get; set; }
        public virtual DbSet<TblA3chgOvrChkSheet> TblA3chgOvrChkSheet { get; set; }
        public virtual DbSet<TblA3dailyChkSheet> TblA3dailyChkSheet { get; set; }
        public virtual DbSet<TblA3v> TblA3v { get; set; }
        public virtual DbSet<TblAfcycleTimes> TblAfcycleTimes { get; set; }
        public virtual DbSet<TblAnodize> TblAnodize { get; set; }
        public virtual DbSet<TblArchiveFoundry> TblArchiveFoundry { get; set; }
        public virtual DbSet<TblArchiveFoundryDetails> TblArchiveFoundryDetails { get; set; }
        public virtual DbSet<TblAssembly1> TblAssembly1 { get; set; }
        public virtual DbSet<TblAssembly2> TblAssembly2 { get; set; }
        public virtual DbSet<TblAssembly3> TblAssembly3 { get; set; }
        public virtual DbSet<TblAssembly4> TblAssembly4 { get; set; }
        public virtual DbSet<TblAssembly5> TblAssembly5 { get; set; }
        public virtual DbSet<TblAssembly6> TblAssembly6 { get; set; }
        public virtual DbSet<TblAssembly7> TblAssembly7 { get; set; }
        public virtual DbSet<TblAssembly8> TblAssembly8 { get; set; }
        public virtual DbSet<TblAssemblyAll> TblAssemblyAll { get; set; }
        public virtual DbSet<TblAssemblyEos> TblAssemblyEos { get; set; }
        public virtual DbSet<TblAssemblyRejectCompList> TblAssemblyRejectCompList { get; set; }
        public virtual DbSet<TblAssemblyRejects> TblAssemblyRejects { get; set; }
        public virtual DbSet<TblAssemblyVi> TblAssemblyVi { get; set; }
        public virtual DbSet<TblAssemblyVparts> TblAssemblyVparts { get; set; }
        public virtual DbSet<TblAssyProd> TblAssyProd { get; set; }
        public virtual DbSet<TblBrokenRings> TblBrokenRings { get; set; }
        public virtual DbSet<TblCastingGroups> TblCastingGroups { get; set; }
        public virtual DbSet<TblCfd> TblCfd { get; set; }
        public virtual DbSet<TblCoating> TblCoating { get; set; }
        public virtual DbSet<TblCoatingBk> TblCoatingBk { get; set; }
        public virtual DbSet<TblCoatingDetails> TblCoatingDetails { get; set; }
        public virtual DbSet<TblCoatingDetailsBk> TblCoatingDetailsBk { get; set; }
        public virtual DbSet<TblCompList> TblCompList { get; set; }
        public virtual DbSet<TblCompanyInfo> TblCompanyInfo { get; set; }
        public virtual DbSet<TblComponentList> TblComponentList { get; set; }
        public virtual DbSet<TblComponentScrap> TblComponentScrap { get; set; }
        public virtual DbSet<TblCostCenter> TblCostCenter { get; set; }
        public virtual DbSet<TblCycleTime> TblCycleTime { get; set; }
        public virtual DbSet<TblCycleTimeMach> TblCycleTimeMach { get; set; }
        public virtual DbSet<TblDateShift> TblDateShift { get; set; }
        public virtual DbSet<TblDateShiftAf> TblDateShiftAf { get; set; }
        public virtual DbSet<TblDateShiftBad> TblDateShiftBad { get; set; }
        public virtual DbSet<TblDateShiftBad2> TblDateShiftBad2 { get; set; }
        public virtual DbSet<TblDateShiftNew> TblDateShiftNew { get; set; }
        public virtual DbSet<TblDepts> TblDepts { get; set; }
        public virtual DbSet<TblDieHistory> TblDieHistory { get; set; }
        public virtual DbSet<TblDies> TblDies { get; set; }
        public virtual DbSet<TblDownTime> TblDownTime { get; set; }
        public virtual DbSet<TblDowntimeCounts> TblDowntimeCounts { get; set; }
        public virtual DbSet<TblDowntimeList> TblDowntimeList { get; set; }
        public virtual DbSet<TblEmployeeInformation> TblEmployeeInformation { get; set; }
        public virtual DbSet<TblEosreport> TblEosreport { get; set; }
        public virtual DbSet<TblFdryHistory> TblFdryHistory { get; set; }
        public virtual DbSet<TblFdryPartParameters> TblFdryPartParameters { get; set; }
        public virtual DbSet<TblFoundry> TblFoundry { get; set; }
        public virtual DbSet<TblFoundryDetails> TblFoundryDetails { get; set; }
        public virtual DbSet<TblFoundryDetailsXxx> TblFoundryDetailsXxx { get; set; }
        public virtual DbSet<TblFoundryTemp> TblFoundryTemp { get; set; }
        public virtual DbSet<TblFoundryTempdetails> TblFoundryTempdetails { get; set; }
        public virtual DbSet<TblFoundryXxx> TblFoundryXxx { get; set; }
        public virtual DbSet<TblHepSummary> TblHepSummary { get; set; }
        public virtual DbSet<TblHepworth> TblHepworth { get; set; }
        public virtual DbSet<TblInspect> TblInspect { get; set; }
        public virtual DbSet<TblInspectDetails> TblInspectDetails { get; set; }
        public virtual DbSet<TblLineCount> TblLineCount { get; set; }
        public virtual DbSet<TblMachineAssociations> TblMachineAssociations { get; set; }
        public virtual DbSet<TblMachineNames> TblMachineNames { get; set; }
        public virtual DbSet<TblMachines> TblMachines { get; set; }
        public virtual DbSet<TblMail> TblMail { get; set; }
        public virtual DbSet<TblMail2> TblMail2 { get; set; }
        public virtual DbSet<TblManualPackout> TblManualPackout { get; set; }
        public virtual DbSet<TblMaxProdFactors> TblMaxProdFactors { get; set; }
        public virtual DbSet<TblMrrhold> TblMrrhold { get; set; }
        public virtual DbSet<TblMrrholdDetails> TblMrrholdDetails { get; set; }
        public virtual DbSet<TblOeedownTimeDetails> TblOeedownTimeDetails { get; set; }
        public virtual DbSet<TblOperators> TblOperators { get; set; }
        public virtual DbSet<TblPartAssembly2> TblPartAssembly2 { get; set; }
        public virtual DbSet<TblPartGrades> TblPartGrades { get; set; }
        public virtual DbSet<TblPartOrientations> TblPartOrientations { get; set; }
        public virtual DbSet<TblPartRouting> TblPartRouting { get; set; }
        public virtual DbSet<TblPartsOfInterest> TblPartsOfInterest { get; set; }
        public virtual DbSet<TblPartsPurchased> TblPartsPurchased { get; set; }
        public virtual DbSet<TblPartsSold> TblPartsSold { get; set; }
        public virtual DbSet<TblPersonnel> TblPersonnel { get; set; }
        public virtual DbSet<TblPistonIdAs400> TblPistonIdAs400 { get; set; }
        public virtual DbSet<TblPistonsPurchased> TblPistonsPurchased { get; set; }
        public virtual DbSet<TblPistonsSold> TblPistonsSold { get; set; }
        public virtual DbSet<TblPlrtrace> TblPlrtrace { get; set; }
        public virtual DbSet<TblPostAssembly> TblPostAssembly { get; set; }
        public virtual DbSet<TblPostAssemblyDetails> TblPostAssemblyDetails { get; set; }
        public virtual DbSet<TblRingAssemblies> TblRingAssemblies { get; set; }
        public virtual DbSet<TblRingAssemblyAdjust> TblRingAssemblyAdjust { get; set; }
        public virtual DbSet<TblRingAssemblyCount> TblRingAssemblyCount { get; set; }
        public virtual DbSet<TblRingAssemblyDetails> TblRingAssemblyDetails { get; set; }
        public virtual DbSet<TblRingAssemblyIssued> TblRingAssemblyIssued { get; set; }
        public virtual DbSet<TblRingAssemblyParts> TblRingAssemblyParts { get; set; }
        public virtual DbSet<TblRoute> TblRoute { get; set; }
        public virtual DbSet<TblRouteList> TblRouteList { get; set; }
        public virtual DbSet<TblRoutePart> TblRoutePart { get; set; }
        public virtual DbSet<TblRoutePartList> TblRoutePartList { get; set; }
        public virtual DbSet<TblRouteScrap> TblRouteScrap { get; set; }
        public virtual DbSet<TblScodes> TblScodes { get; set; }
        public virtual DbSet<TblScrapCodes> TblScrapCodes { get; set; }
        public virtual DbSet<TblScrapCounts> TblScrapCounts { get; set; }
        public virtual DbSet<TblScrapList> TblScrapList { get; set; }
        public virtual DbSet<TblSkirtCoat> TblSkirtCoat { get; set; }
        public virtual DbSet<TblSkirtCoatCount> TblSkirtCoatCount { get; set; }
        public virtual DbSet<TblSpecialData> TblSpecialData { get; set; }
        public virtual DbSet<TblStdHours> TblStdHours { get; set; }
        public virtual DbSet<TblSupervisors> TblSupervisors { get; set; }
        public virtual DbSet<TblTinPlate> TblTinPlate { get; set; }
        public virtual DbSet<TblTolerances> TblTolerances { get; set; }
        public virtual DbSet<TblTwtags> TblTwtags { get; set; }
        public virtual DbSet<TblUsers> TblUsers { get; set; }
        public virtual DbSet<TblWebMail> TblWebMail { get; set; }
        public virtual DbSet<TblkpValues> TblkpValues { get; set; }
        public virtual DbSet<Tblprotopartparameters> Tblprotopartparameters { get; set; }
        public virtual DbSet<TblxtDefectCategory> TblxtDefectCategory { get; set; }
        public virtual DbSet<TblxtDepart> TblxtDepart { get; set; }
        public virtual DbSet<TblxtPart> TblxtPart { get; set; }
        public virtual DbSet<TblxtPartAssembly> TblxtPartAssembly { get; set; }
        public virtual DbSet<TblxtPartFmly> TblxtPartFmly { get; set; }
        public virtual DbSet<TblxtProcess> TblxtProcess { get; set; }
        public virtual DbSet<TblxtScrapDept> TblxtScrapDept { get; set; }
        public virtual DbSet<TblxtScrapDeptArea> TblxtScrapDeptArea { get; set; }
        public virtual DbSet<TblxtScrapDeptAreaDef> TblxtScrapDeptAreaDef { get; set; }
        public virtual DbSet<TmpInspSummary> TmpInspSummary { get; set; }
        public virtual DbSet<ViewAnodizeReport2016> ViewAnodizeReport2016 { get; set; }
        public virtual DbSet<ViewAssy2> ViewAssy2 { get; set; }
        public virtual DbSet<ViewAssy3> ViewAssy3 { get; set; }
        public virtual DbSet<ViewAssy4> ViewAssy4 { get; set; }
        public virtual DbSet<ViewAssy5> ViewAssy5 { get; set; }
        public virtual DbSet<ViewAssy6> ViewAssy6 { get; set; }
        public virtual DbSet<ViewAssy7> ViewAssy7 { get; set; }
        public virtual DbSet<ViewAssy8> ViewAssy8 { get; set; }
        public virtual DbSet<ViewAssyDowntime> ViewAssyDowntime { get; set; }
        public virtual DbSet<ViewAssyDtloss> ViewAssyDtloss { get; set; }
        public virtual DbSet<ViewAssyRejects> ViewAssyRejects { get; set; }
        public virtual DbSet<ViewAssyScrap> ViewAssyScrap { get; set; }
        public virtual DbSet<ViewFoundryscrapAF> ViewFoundryscrapAF { get; set; }
        public virtual DbSet<ViewSc2016> ViewSc2016 { get; set; }
        public virtual DbSet<ViewScrapCountsArea> ViewScrapCountsArea { get; set; }
        public virtual DbSet<ViewTotalAnodAssy> ViewTotalAnodAssy { get; set; }
        public virtual DbSet<ViewTotalAssyAssy> ViewTotalAssyAssy { get; set; }
        public virtual DbSet<ViewTotalFoundryAssy> ViewTotalFoundryAssy { get; set; }
        public virtual DbSet<ViewTotalMachAssy> ViewTotalMachAssy { get; set; }
        public virtual DbSet<ViewTotalScAssy> ViewTotalScAssy { get; set; }
        public virtual DbSet<VwAnodizeByDateShiftLinePart> VwAnodizeByDateShiftLinePart { get; set; }
        public virtual DbSet<VwCastingPartTranslate> VwCastingPartTranslate { get; set; }
        public virtual DbSet<VwDateShifts> VwDateShifts { get; set; }
        public virtual DbSet<VwDefects> VwDefects { get; set; }
        public virtual DbSet<VwDefectsNumericOnly> VwDefectsNumericOnly { get; set; }
        public virtual DbSet<VwSkirtcoatByDateShiftLinePart> VwSkirtcoatByDateShiftLinePart { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=SBNDINMS002;Initial Catalog=FMO_Master;Integrated Security=False;User ID=rontoa20;Password=aebbie17;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.Entity<AFDailyOutputProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("A&F_Daily_output_program");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Af_all");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllAnod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_anod");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_assy");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllEos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_EOS");

                entity.Property(e => e.Dept).IsUnicode(false);
            });

            modelBuilder.Entity<AfAllEosUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_EOS_union");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllEosUnion2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_EOS_union2");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllEosUnion2Transferred>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllEosUnion3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_EOS_union3");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllMachineDowntime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_allMachineDowntime");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllSc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_sc");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_union");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAllUnion2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_all_union2");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAnodDowntime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Af_AnodDowntime");

                entity.Property(e => e.AnodizeId).ValueGeneratedOnAdd();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAnodDowntime2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_anodDowntime2");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Defect).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfAssyDowntime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_assyDowntime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AfManningView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_manning_view");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.TinPlateId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AfManningdataentry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_manningdataentry");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfOaeOeeEos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_OAE_OEE_EOS");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfOaeOeeEosTransfered>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfOaeProgram>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_OAE_Program");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfOaeProgram2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_OAE_Program2");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Part2).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfScDowntime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_scDowntime");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.SkirtCoatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AfScDowntime2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("af_scDowntime2");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Defect).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AfmanningSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AFManningSummary");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AnodizeDefectHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AnodizeDefectHistory");

                entity.Property(e => e.Defect).IsUnicode(false);
            });

            modelBuilder.Entity<AnodizeDefectHistory2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AnodizeDefectHistory2");

                entity.Property(e => e.AnodizeId).ValueGeneratedOnAdd();

                entity.Property(e => e.Defect).IsUnicode(false);

                entity.Property(e => e.DefectArea).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<AsmSwitchboard>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<AssemblyDefectHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssemblyDefectHistory");

                entity.Property(e => e.DefectArea).IsUnicode(false);
            });

            modelBuilder.Entity<AssemblyScrapRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssemblyScrapRate");
            });

            modelBuilder.Entity<AssyComponentList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssyComponent_List");

                entity.Property(e => e.ScrapId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<AssyComponentScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AssyComponentScrap");

                entity.Property(e => e.InputStat).IsUnicode(false);
            });

            modelBuilder.Entity<ComponentViewScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Component_view_scrap");
            });

            modelBuilder.Entity<DeptLineRefs>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.DeptName)
                    .HasName("NonClusteredIndex-20171113-101301");

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);
            });

            modelBuilder.Entity<DieShotHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DieShotHistory");
            });

            modelBuilder.Entity<DtTables>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Source).IsUnicode(false);
            });

            modelBuilder.Entity<EooExcelDownload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOO_Excel_Download");

                entity.Property(e => e.Pn).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EooTotalView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOO_Total_view");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Pn).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EooUpstreamScrap>(entity =>
            {
                entity.HasOne(d => d.SkitCoat)
                    .WithMany(p => p.EooUpstreamScrap)
                    .HasForeignKey(d => d.SkitCoatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EOO_UpstreamScrap_tblSkirtCoat");
            });

            modelBuilder.Entity<EosA2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A2");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A3");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A4");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A5");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A6");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A7");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosA8>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_A8");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosAnod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_Anod");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.OaeCom).IsUnicode(false);

                entity.Property(e => e.OtherCom).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<EosAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_Assy");
            });

            modelBuilder.Entity<EosSc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EOS_SC");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Oaecom).IsUnicode(false);

                entity.Property(e => e.OtherCom).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ScrapCom).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmConvertSapPart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("fm_convert_SAP_part");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Sappart).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterDefects>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_MasterDefects");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterDefectsCopy>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy_view");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FmsbMasterProdPartsCopyViewL3Gmet4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FMSB_Master_Prod_Parts_copy_view_l3_gmet4");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Line).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<Foundry5FsDefectView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("foundry_5_fs_defect_view");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<Foundry5PartsView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("foundry_5_parts_view");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FoundryDefectRates>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryDefectRates");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();
            });

            modelBuilder.Entity<FoundryDefectRates2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryDefectRates_2");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Part).IsFixedLength();
            });

            modelBuilder.Entity<FoundryDieShotCounts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryDieShotCounts");
            });

            modelBuilder.Entity<FoundryDieShotCountsUnfiltered>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FoundryDieShotCounts_Unfiltered");
            });

            modelBuilder.Entity<FoundryEooDefectEos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Foundry_EOO_Defect_EOS");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FoundryEooPartsEos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Foundry_EOO_Parts_EOS");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<FoundryEoodefectHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Foundry_EOODefect_History");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<Gp12PartsInsected>(entity =>
            {
                entity.Property(e => e.Date).IsFixedLength();
            });

            modelBuilder.Entity<Gp12ScrapView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GP12_ScrapView");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MachEooDefect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Mach_EOO_Defect");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ManningAllDept>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ManningAllDept");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Shiftname).IsFixedLength();
            });

            modelBuilder.Entity<MhAfoeeData>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mh_AFOeeData");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<MhOnlineComments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mh_OnlineComments");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<MhTblCurrentParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mh_tblCurrentParts");
            });

            modelBuilder.Entity<MhTblCycleTimes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mh_tblCycleTimes");

                entity.Property(e => e.PartId).IsFixedLength();
            });

            modelBuilder.Entity<MhView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("mh_View");

                entity.Property(e => e.CoatingId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<MmAf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MM_AF");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Machine).IsUnicode(false);
            });

            modelBuilder.Entity<MrrEosLink>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MRR_EOS_Link");

                entity.Property(e => e.Mrrnum).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<MrrscrapDetails>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MrrscrapView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MRRScrap_View");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.CostCenter).IsUnicode(false);
            });

            modelBuilder.Entity<Mrrview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MRRView");

                entity.Property(e => e.Catagory).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.LastOp).IsFixedLength();

                entity.Property(e => e.Mrrnum).IsUnicode(false);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<PrAfonly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("pr_AFOnly");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<PrAfonlyFilter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("pr_AFOnlyFilter");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<SapAfScrapUpload>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SAP_af_ScrapUpload");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();
            });

            modelBuilder.Entity<Sbndinnt01FmoMasterDboTblAssembly7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sbndinnt01_FMO_Master_dbo_tblAssembly7", "production");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ScrapTopAnod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap_Top_Anod");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ScrapTopAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap_Top_Assy");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ScrapTopSc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Scrap_Top_SC");

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<Sheet2>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<ShiftlyA2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_a2");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftlyA3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_a3");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftlyA6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_a6");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftlyA7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_a7");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftlyAnod>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_anod");

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftlyNewAssyAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_new_assyAll");

                entity.Property(e => e.Mnt).IsUnicode(false);
            });

            modelBuilder.Entity<ShiftlySc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shiftly_sc");

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftyA4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shifty_a4");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftyA5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shifty_a5");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ShiftyA8>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("shifty_a8");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<SkirtCoatDailyView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkirtCoat_DailyView");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.SkirtCoatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SkirtCoatDefectHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkirtCoatDefectHistory");
            });

            modelBuilder.Entity<SkirtCoatDefectHistory2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkirtCoatDefectHistory2");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.Part).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.SkirtCoatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SkirtCoatScrapParts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkirtCoatScrap_Parts");

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.SkirtCoatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblA3chgOvrChkSheet>(entity =>
            {
                entity.HasKey(e => new { e.Vdate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .IsClustered(false);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TblA3dailyChkSheet>(entity =>
            {
                entity.HasKey(e => new { e.Vdate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .IsClustered(false);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.InkBlackStripe).HasDefaultValueSql("(0)");

                entity.Property(e => e.InkJetCrown).HasDefaultValueSql("(0)");

                entity.Property(e => e.Ucrload).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblA3v>(entity =>
            {
                entity.HasKey(e => new { e.Vdate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .IsClustered(false);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();
            });

            modelBuilder.Entity<TblAfcycleTimes>(entity =>
            {
                entity.Property(e => e.ProcessId).IsUnicode(false);
            });

            modelBuilder.Entity<TblAnodize>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAnodizeKey")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(5)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.MachineHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PersonnelHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.PostAnodize).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.Rejects).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.TestScrap).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblArchiveFoundry>(entity =>
            {
                entity.HasKey(e => e.FdryId)
                    .HasName("PK_tblArchiveFdry");

                entity.HasIndex(e => e.EvenDieNr);

                entity.HasIndex(e => e.FdryDate);

                entity.HasIndex(e => e.FdryId);

                entity.HasIndex(e => e.OddDieNr);

                entity.HasIndex(e => e.OperatorId);

                entity.HasIndex(e => e.PartId);

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.EvenDieNr).IsFixedLength();

                entity.Property(e => e.MachineLetter).IsFixedLength();

                entity.Property(e => e.OddDieNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblArchiveFoundryDetails>(entity =>
            {
                entity.HasKey(e => new { e.FdryId, e.OddEven, e.ScrapId });

                entity.HasIndex(e => e.FdryId);

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.OddEven).HasDefaultValueSql("(0)");

                entity.Property(e => e.ScrapId).IsFixedLength();

                entity.HasOne(d => d.Fdry)
                    .WithMany(p => p.TblArchiveFoundryDetails)
                    .HasForeignKey(d => d.FdryId)
                    .HasConstraintName("FK_tblArchiveFoundryDetails_tblArchiveFoundry");
            });

            modelBuilder.Entity<TblAssembly1>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly1Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(5)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.PackOutTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PersonnelHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrcameraRejectCounter).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrcameraRejectGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpinCradleCounter).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpinCradleGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpinDepthCounter).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpinDepthGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpromessColorCounter).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrpromessColorGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrwrongPartCounter).HasDefaultValueSql("(0)");

                entity.Property(e => e.SrwrongPartGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly2>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly2Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.AssyScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(5)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.LaserScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlate).HasDefaultValueSql("(0)");

                entity.Property(e => e.PackOutTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackInsp).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.VisionScrap).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly3>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly3Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleRunTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleStopTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(8)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Dial1Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeExpander).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeOrientation).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD1toD2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD2toD3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimePaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeReject).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectFixAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGoodToRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectPaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip1Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip2Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeOiler).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimePinInsertion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeRodLoad).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Production).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBackwardRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBrokenLcr).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectMissingCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapCirclip).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapExp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapLowerComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapPin).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapUpperComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectUnseatedCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Rejects).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpanderQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.PostAssemblyInsp).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLandScratch).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackPinsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRingsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RailQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty2).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly4>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly4Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.AssyScrap).HasDefaultValueSql("((0))");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("((5))");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("((0))");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.Handling).HasDefaultValueSql("((0))");

                entity.Property(e => e.LaserScrap).HasDefaultValueSql("((0))");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadAnodizingPost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadAnodizingPre).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadFoundryPost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadFoundryPre).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadHandlingPost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadHandlingPre).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadMachiningPost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadMachiningPre).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadSkirtCoatPost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadSkirtCoatPre).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadTinPlatePost).HasDefaultValueSql("((0))");

                entity.Property(e => e.NadTinPlatePre).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackOutTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.PistonRejects).HasDefaultValueSql("((0))");

                entity.Property(e => e.PistonScrap).HasDefaultValueSql("((0))");

                entity.Property(e => e.PrePackInsp).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.Rework).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisionScrap).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAssembly5>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly5Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Confirmed).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(5)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.HasMrr).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.PackOutTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.ReworkColor).HasDefaultValueSql("(0)");

                entity.Property(e => e.ReworkGradePin).HasDefaultValueSql("(0)");

                entity.Property(e => e.ReworkWeight).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Transferred).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly6>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly6Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.AssyScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(5)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.LaserScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizingPost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizingPre).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundryPost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundryPre).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadHandlingPost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadHandlingPre).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachiningPost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachiningPre).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoatPost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoatPre).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlatePost).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlatePre).HasDefaultValueSql("(0)");

                entity.Property(e => e.PackOutTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PistonRejects).HasDefaultValueSql("(0)");

                entity.Property(e => e.PistonScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackInsp).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.VisionScrap).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly7>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly7Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleRunTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleStopTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(8)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Dial1Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeExpander).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeOrientation).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD1toD2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD2toD3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimePaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeReject).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectFixAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGoodToRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectPaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip1Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip2Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeOiler).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimePinInsertion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeRodLoad).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Production).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBackwardRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBrokenLcr).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectMissingCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapCirclip).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapExp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapLowerComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapPin).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapUpperComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectUnseatedCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Rejects).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpanderQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.PostAssemblyInsp).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLandScratch).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackPinsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRingsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RailQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty2).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssembly8>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssembly8Key")
                    .IsUnique();

                entity.Property(e => e.ActualProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.CirclipQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleRunTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleStopTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.CycleTime).HasDefaultValueSql("(8)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Dial1Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeExpander).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeLrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeOrientation).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUcring).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1FtimeUrail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial1Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD1toD2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeD2toD3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimePaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeReject).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectFixAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGoodToRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectGrade).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectPaint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndRerun).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial2ScrapStripAndScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Ftime).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip1Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClip2Ins).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeOiler).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimePinInsertion).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeRodLoad).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeUnload).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3FtimeVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Production).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBackwardRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectBrokenLcr).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectClipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectForce).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectMissingCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapCirclip).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapExp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapLowerComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapPin).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRail).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapRod).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectScrapUpperComp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectUnseatedCmpnt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectVision).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Rejects).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3RejectsScrap1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Dial3Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitMeeting).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtNoAuth).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpanderQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlate).HasDefaultValueSql("(0)");

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.PostAssemblyInsp).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackCirclipUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackExpUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackHandling).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLandScratch).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrmissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackLcrucrunseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackPinsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsMissing).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRailsUnseated).HasDefaultValueSql("(0)");

                entity.Property(e => e.PrePackRingsTight).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RailQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Rework).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty2).HasDefaultValueSql("(0)");

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Scrap).HasDefaultValueSql("(0)");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty2).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblAssemblyAll>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Anod).HasDefaultValueSql("((0))");

                entity.Property(e => e.AnodGross).HasDefaultValueSql("((0))");

                entity.Property(e => e.Assy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CoMin).HasDefaultValueSql("((0))");

                entity.Property(e => e.CoParts).HasDefaultValueSql("((0))");

                entity.Property(e => e.Fs).HasDefaultValueSql("((0))");

                entity.Property(e => e.Gross).HasDefaultValueSql("((0))");

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.Mnt).IsUnicode(false);

                entity.Property(e => e.Ms).HasDefaultValueSql("((0))");

                entity.Property(e => e.Sc).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScGross).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Target).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAssemblyEos>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblAssemblyRejects>(entity =>
            {
                entity.Property(e => e.Reviewed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblAssemblyVi>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblAssemblyVIKey")
                    .IsUnique();

                entity.Property(e => e.Asy00).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy01).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy02).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy03).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy04).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy05).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy06).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy07).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy08).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy09).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy10).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy11).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy12).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy13).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy14).HasDefaultValueSql("(0)");

                entity.Property(e => e.Asy15).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart01).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart02).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart03).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart04).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart05).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart06).HasDefaultValueSql("(0)");

                entity.Property(e => e.AsyPart07).HasDefaultValueSql("(0)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Inspector).IsFixedLength();

                entity.Property(e => e.NonAsy01).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonAsy02).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonAsy03).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonAsy04).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonAsy05).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap01).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap02).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap03).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap04).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap05).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap06).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap07).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap08).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap09).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap10).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap11).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap12).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap13).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap14).HasDefaultValueSql("(0)");

                entity.Property(e => e.NonScrap15).HasDefaultValueSql("(0)");

                entity.Property(e => e.NrReviewed).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblAssemblyVparts>(entity =>
            {
                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Asy00Code).IsFixedLength();

                entity.Property(e => e.Asy01Code).IsFixedLength();

                entity.Property(e => e.Asy02Code).IsFixedLength();

                entity.Property(e => e.Asy03Code).IsFixedLength();

                entity.Property(e => e.Asy04Code).IsFixedLength();

                entity.Property(e => e.Asy05Code).IsFixedLength();

                entity.Property(e => e.Asy06Code).IsFixedLength();

                entity.Property(e => e.Asy07Code).IsFixedLength();

                entity.Property(e => e.Asy08Code).IsFixedLength();

                entity.Property(e => e.Asy09Code).IsFixedLength();

                entity.Property(e => e.Asy10Code).IsFixedLength();

                entity.Property(e => e.Asy11Code).IsFixedLength();

                entity.Property(e => e.Asy12Code).IsFixedLength();

                entity.Property(e => e.Asy13Code).IsFixedLength();

                entity.Property(e => e.Asy14Code).IsFixedLength();

                entity.Property(e => e.Asy15Code).IsFixedLength();

                entity.Property(e => e.NonAsy01Code).IsFixedLength();

                entity.Property(e => e.NonAsy02Code).IsFixedLength();

                entity.Property(e => e.NonAsy03Code).IsFixedLength();

                entity.Property(e => e.NonAsy04Code).IsFixedLength();

                entity.Property(e => e.NonAsy05Code).IsFixedLength();

                entity.Property(e => e.NonAsy06Code).IsFixedLength();

                entity.Property(e => e.NonAsy07Code).IsFixedLength();

                entity.Property(e => e.NonAsy08Code).IsFixedLength();

                entity.Property(e => e.NonAsy09Code).IsFixedLength();

                entity.Property(e => e.NonAsy10Code).IsFixedLength();
            });

            modelBuilder.Entity<TblAssyProd>(entity =>
            {
                entity.Property(e => e.Stat).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MachineCodeNavigation)
                    .WithMany(p => p.TblAssyProd)
                    .HasForeignKey(d => d.MachineCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_Assy_Prod_tbl_MachineNames");
            });

            modelBuilder.Entity<TblBrokenRings>(entity =>
            {
                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblCastingGroups>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .IsClustered(false);

                entity.HasIndex(e => e.PartId)
                    .HasName("IXU_tblCastingGroups_PartID")
                    .IsUnique();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.CastGroup).IsFixedLength();
            });

            modelBuilder.Entity<TblCfd>(entity =>
            {
                entity.Property(e => e.Cfd).ValueGeneratedNever();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblCoating>(entity =>
            {
                entity.HasKey(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId });

                entity.HasIndex(e => e.CoatDate);

                entity.HasIndex(e => e.CoatingId);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.ProcessId);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.CoatingId).ValueGeneratedOnAdd();

                entity.Property(e => e.DtAwaitDunnage).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitParts).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtAwaitPersonnel).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtBreakdowns).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtMinorBreaks).HasDefaultValueSql("(0)");

                entity.Property(e => e.DtSetups).HasDefaultValueSql("(0)");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.GradeOrient).IsFixedLength();

                entity.Property(e => e.PlannedDownTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.ShiftTime).HasDefaultValueSql("(0)");

                entity.Property(e => e.TargetProduction).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.TblCoating)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCoating_tblxtDepart");
            });

            modelBuilder.Entity<TblCoatingBk>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.GradeOrient).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblCoatingDetails>(entity =>
            {
                entity.HasKey(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId, e.DefectId });

                entity.HasIndex(e => e.CoatDate);

                entity.HasIndex(e => e.CoatingId);

                entity.HasIndex(e => e.DefectId);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => e.Run);

                entity.HasIndex(e => e.Shift);

                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .HasName("IX_tblCoatingDetails_ForeignKey");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.EntryType)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.TblCoating)
                    .WithMany(p => p.TblCoatingDetails)
                    .HasForeignKey(d => new { d.CoatDate, d.Shift, d.DepartmentId, d.Run, d.RunNr, d.PartId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCoatingDetails_tblCoating");
            });

            modelBuilder.Entity<TblCoatingDetailsBk>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EntryType).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblCompanyInfo>(entity =>
            {
                entity.HasIndex(e => e.ZipCode);

                entity.Property(e => e.Fax).IsFixedLength();

                entity.Property(e => e.FedIdnr).IsFixedLength();

                entity.Property(e => e.Phone).IsFixedLength();

                entity.Property(e => e.Secure).HasDefaultValueSql("(0)");

                entity.Property(e => e.State).IsFixedLength();

                entity.Property(e => e.StateIdnr).IsFixedLength();

                entity.Property(e => e.TollFree).IsFixedLength();

                entity.Property(e => e.ZipCode).IsFixedLength();
            });

            modelBuilder.Entity<TblComponentScrap>(entity =>
            {
                entity.HasOne(d => d.ComponentCodeNavigation)
                    .WithMany(p => p.TblComponentScrap)
                    .HasForeignKey(d => d.ComponentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ComponentScrap_tbl_CompList");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.TblComponentScrap)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ComponentScrap_tbl_Assy_Prod");
            });

            modelBuilder.Entity<TblCostCenter>(entity =>
            {
                entity.Property(e => e.CostCenter).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblCycleTime>(entity =>
            {
                entity.HasOne(d => d.MachineCodeNavigation)
                    .WithOne(p => p.TblCycleTime)
                    .HasForeignKey<TblCycleTime>(d => d.MachineCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_CycleTime_tbl_MachineNames");
            });

            modelBuilder.Entity<TblCycleTimeMach>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblDateShift>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblDateShiftAf>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblDateShiftBad>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblDateShiftBad2>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblDateShiftNew>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblDepts>(entity =>
            {
                entity.HasKey(e => e.Dept)
                    .IsClustered(false);

                entity.HasIndex(e => e.Dept)
                    .HasName("IX_tblDepts_Dept")
                    .IsUnique();

                entity.Property(e => e.Dept).IsFixedLength();
            });

            modelBuilder.Entity<TblDieHistory>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblDies>(entity =>
            {
                entity.HasKey(e => new { e.DieNr, e.PartId })
                    .IsClustered(false);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => new { e.DieNr, e.PartId, e.DieDate, e.DieComment, e.CastHist })
                    .HasName("_dta_index_tblDies_11_1208495484__K1_K2_K4_K5_K6");

                entity.Property(e => e.DieNr)
                    .IsFixedLength()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.CastHist).HasDefaultValueSql("(0)");

                entity.Property(e => e.OddEven).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.TblDies)
                    .HasForeignKey(d => d.PartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDies_tblCastingGroups");
            });

            modelBuilder.Entity<TblDownTime>(entity =>
            {
                entity.HasKey(e => e.FdryId)
                    .IsClustered(false);

                entity.HasIndex(e => e.FdryId)
                    .HasName("IXU_tblDowntime_FdryID")
                    .IsUnique();

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.S01).HasDefaultValueSql("(0)");

                entity.Property(e => e.S02).HasDefaultValueSql("(0)");

                entity.Property(e => e.S03).HasDefaultValueSql("(0)");

                entity.Property(e => e.S04).HasDefaultValueSql("(0)");

                entity.Property(e => e.S05).HasDefaultValueSql("(0)");

                entity.Property(e => e.S06).HasDefaultValueSql("(0)");

                entity.Property(e => e.S07).HasDefaultValueSql("(0)");

                entity.Property(e => e.S08).HasDefaultValueSql("(0)");

                entity.Property(e => e.S09).HasDefaultValueSql("(0)");

                entity.Property(e => e.U01).HasDefaultValueSql("(0)");

                entity.Property(e => e.U02).HasDefaultValueSql("(0)");

                entity.Property(e => e.U03).HasDefaultValueSql("(0)");

                entity.Property(e => e.U04).HasDefaultValueSql("(0)");

                entity.Property(e => e.U05).HasDefaultValueSql("(0)");

                entity.Property(e => e.U06).HasDefaultValueSql("(0)");

                entity.Property(e => e.U07).HasDefaultValueSql("(0)");

                entity.Property(e => e.U08).HasDefaultValueSql("(0)");

                entity.Property(e => e.U09).HasDefaultValueSql("(0)");

                entity.Property(e => e.U10).HasDefaultValueSql("(0)");

                entity.Property(e => e.U11).HasDefaultValueSql("(0)");

                entity.Property(e => e.U12).HasDefaultValueSql("(0)");

                entity.Property(e => e.U13).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Fdry)
                    .WithOne(p => p.TblDownTime)
                    .HasForeignKey<TblDownTime>(d => d.FdryId)
                    .HasConstraintName("FK_tblDownTime_tblFoundry");
            });

            modelBuilder.Entity<TblDowntimeCounts>(entity =>
            {
                entity.HasOne(d => d.DowntimeCodeNavigation)
                    .WithMany(p => p.TblDowntimeCounts)
                    .HasForeignKey(d => d.DowntimeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DowntimeCounts_tbl_DowntimeList");

                entity.HasOne(d => d.P)
                    .WithMany(p => p.TblDowntimeCounts)
                    .HasForeignKey(d => d.Pid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_DowntimeCounts_tbl_Assy_Prod");
            });

            modelBuilder.Entity<TblDowntimeList>(entity =>
            {
                entity.HasKey(e => e.DowntimeCode)
                    .HasName("PK_tbl_Downtime");
            });

            modelBuilder.Entity<TblEmployeeInformation>(entity =>
            {
                entity.HasKey(e => e.Clk)
                    .IsClustered(false);

                entity.HasIndex(e => e.Dept)
                    .HasName("IX_tblEmployeeInformation_Dept");

                entity.HasIndex(e => e.FullNameCalced)
                    .HasName("IXU_tblEmployeeInformation_FullNameCalced")
                    .IsUnique();

                entity.HasIndex(e => e.Jobtitle)
                    .HasName("IX_tblEmployeeInformation_JobTitle");

                entity.HasIndex(e => e.LastName);

                entity.HasIndex(e => e.Shift)
                    .HasName("IX_tblEmployeeInformation_Shift");

                entity.HasIndex(e => e.ZipCode);

                entity.Property(e => e.Clk).ValueGeneratedNever();

                entity.Property(e => e.Homephone).IsFixedLength();

                entity.Property(e => e.Leave).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.State).IsFixedLength();

                entity.Property(e => e.Supervisor).HasDefaultValueSql("(0)");

                entity.Property(e => e.Terminated).HasDefaultValueSql("(0)");

                entity.Property(e => e.Training).IsFixedLength();

                entity.Property(e => e.WorkOvertime).HasDefaultValueSql("(0)");

                entity.Property(e => e.ZipCode).IsFixedLength();
            });

            modelBuilder.Entity<TblEosreport>(entity =>
            {
                entity.Property(e => e.ChemInv).IsFixedLength();

                entity.Property(e => e.CocartInv).IsFixedLength();

                entity.Property(e => e.LayeredAudit).IsFixedLength();

                entity.Property(e => e.NonConform).IsFixedLength();

                entity.Property(e => e.ScreenInv).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.StopObs).IsFixedLength();
            });

            modelBuilder.Entity<TblFdryHistory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cavity)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cell)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Core)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Shift)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatGroup)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblFdryPartParameters>(entity =>
            {
                entity.HasKey(e => new { e.PartNumber, e.LadleType });
            });

            modelBuilder.Entity<TblFoundry>(entity =>
            {
                entity.HasIndex(e => e.EvenDieNr);

                entity.HasIndex(e => e.FdryDate);

                entity.HasIndex(e => e.FdryId);

                entity.HasIndex(e => e.OddDieNr);

                entity.HasIndex(e => e.OldId);

                entity.HasIndex(e => e.OperatorId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => new { e.PartId, e.EvenDieNr, e.OddDieNr, e.FdryDate, e.TotalCast })
                    .HasName("_dta_index_tblFoundry_11_1570260799__K4_K15_K14_K3_K13");

                entity.HasIndex(e => new { e.PartId, e.FdryDate, e.OddDieNr, e.EvenDieNr, e.TotalCast })
                    .HasName("_dta_index_tblFoundry_11_1570260799__K4_K3_K14_K15_K13");

                entity.Property(e => e.EvenDieNr).IsFixedLength();

                entity.Property(e => e.MachineLetter).IsFixedLength();

                entity.Property(e => e.OddDieNr).IsFixedLength();

                entity.Property(e => e.OldId).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblFoundryDetails>(entity =>
            {
                entity.HasKey(e => new { e.FdryId, e.OddEven, e.ScrapId });

                entity.HasIndex(e => e.FdryId);

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.OddEven).HasDefaultValueSql("(0)");

                entity.Property(e => e.ScrapId).IsFixedLength();

                entity.HasOne(d => d.Fdry)
                    .WithMany(p => p.TblFoundryDetails)
                    .HasForeignKey(d => d.FdryId)
                    .HasConstraintName("FK_tblFoundryDetails_tblFoundry");
            });

            modelBuilder.Entity<TblFoundryDetailsXxx>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.OddEven).HasDefaultValueSql("(0)");

                entity.Property(e => e.ScrapId).IsFixedLength();
            });

            modelBuilder.Entity<TblFoundryTemp>(entity =>
            {
                entity.Property(e => e.EvenDieNr).IsFixedLength();

                entity.Property(e => e.MachineLetter).IsFixedLength();

                entity.Property(e => e.OddDieNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblFoundryTempdetails>(entity =>
            {
                entity.HasKey(e => new { e.FdryId, e.OddEven, e.ScrapId });

                entity.Property(e => e.FdryId).HasDefaultValueSql("(0)");

                entity.Property(e => e.OddEven).HasDefaultValueSql("(0)");

                entity.Property(e => e.ScrapId).IsFixedLength();

                entity.HasOne(d => d.Fdry)
                    .WithMany(p => p.TblFoundryTempdetails)
                    .HasForeignKey(d => d.FdryId)
                    .HasConstraintName("FK_tblFoundryTEMPDetails_tblFoundryTEMP");
            });

            modelBuilder.Entity<TblFoundryXxx>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EvenDieNr).IsFixedLength();

                entity.Property(e => e.FdryId).ValueGeneratedOnAdd();

                entity.Property(e => e.MachineLetter).IsFixedLength();

                entity.Property(e => e.OddDieNr).IsFixedLength();

                entity.Property(e => e.OldId).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<TblHepSummary>(entity =>
            {
                entity.HasKey(e => e.SummaryId)
                    .IsClustered(false);

                entity.HasIndex(e => e.SummarizedAs);

                entity.HasIndex(e => e.SummaryId);

                entity.Property(e => e.SummaryId).IsFixedLength();

                entity.Property(e => e.Dept).IsFixedLength();
            });

            modelBuilder.Entity<TblHepworth>(entity =>
            {
                entity.HasKey(e => new { e.DefectDepartment, e.HepworthId })
                    .IsClustered(false);

                entity.Property(e => e.DefectDepartment).IsFixedLength();

                entity.Property(e => e.HepworthId).IsFixedLength();
            });

            modelBuilder.Entity<TblInspect>(entity =>
            {
                entity.HasKey(e => new { e.InspDate, e.Shift, e.Line, e.Run, e.RunNr, e.PartId });

                entity.HasIndex(e => e.InspDate);

                entity.HasIndex(e => e.InspectId)
                    .HasName("IIX_tblInspect_nspectID");

                entity.HasIndex(e => e.PartId);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.InspectId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblInspectDetails>(entity =>
            {
                entity.HasKey(e => new { e.InspDate, e.Shift, e.Line, e.Run, e.RunNr, e.PartId, e.DefectId });

                entity.HasIndex(e => e.DefectId);

                entity.HasIndex(e => e.InspDate);

                entity.HasIndex(e => e.InspectId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => new { e.InspDate, e.Shift, e.Line, e.Run, e.RunNr, e.PartId })
                    .HasName("IX_tblInspectDetails_ForeignKey");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.EntryType)
                    .IsFixedLength()
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.Quantity).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.TblInspect)
                    .WithMany(p => p.TblInspectDetails)
                    .HasForeignKey(d => new { d.InspDate, d.Shift, d.Line, d.Run, d.RunNr, d.PartId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblInspectDetails_tblInspect");
            });

            modelBuilder.Entity<TblLineCount>(entity =>
            {
                entity.HasKey(e => e.LineNr)
                    .IsClustered(false);
            });

            modelBuilder.Entity<TblMachineAssociations>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblMail>(entity =>
            {
                entity.Property(e => e.IndGroup).IsFixedLength();
            });

            modelBuilder.Entity<TblMail2>(entity =>
            {
                entity.Property(e => e.IndGroup).IsFixedLength();
            });

            modelBuilder.Entity<TblManualPackout>(entity =>
            {
                entity.Property(e => e.Confirmed).HasDefaultValueSql("(0)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.HasMrr).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadTinPlate).HasDefaultValueSql("(0)");

                entity.Property(e => e.PackoutTotal).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Transferred).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblMaxProdFactors>(entity =>
            {
                entity.HasKey(e => e.Line)
                    .IsClustered(false);

                entity.Property(e => e.HoursPerShift).HasDefaultValueSql("(0)");

                entity.Property(e => e.SecondsPerCycle).HasDefaultValueSql("(0)");

                entity.Property(e => e.ShiftsPerWeek).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblMrrhold>(entity =>
            {
                entity.HasKey(e => new { e.Mrryear, e.Mrrcode });

                entity.HasIndex(e => e.Cfdid);

                entity.HasIndex(e => e.DefectId);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.Mrrcode);

                entity.HasIndex(e => e.Mrryear);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => new { e.IncidentDate, e.Shift, e.DepartmentId, e.Line, e.Run, e.RunNr })
                    .HasName("IX_tblMRRHold_ForeignKey_tblCoating");

                entity.HasIndex(e => new { e.IncidentDate, e.Shift, e.Line, e.Run, e.RunNr, e.PartId })
                    .HasName("IX_tblMRRHold_ForeignKey_tblInspect");

                entity.HasIndex(e => new { e.Mrrcode, e.Mrryear, e.IncidentDate, e.Shift, e.Line, e.Run, e.RunNr, e.PartId, e.DefectId, e.Quantity })
                    .HasName("tblMRRHold26");

                entity.HasIndex(e => new { e.PartId, e.DefectId, e.Shift, e.Line, e.Run, e.RunNr, e.Mrrcode, e.Mrryear, e.DepartmentId, e.Quantity, e.IncidentDate })
                    .HasName("_dta_index_tblMRRHold_8_1651693132__K10_K11_K4_K7_K8_K9_K2_K1_K5_K12_K3");

                entity.Property(e => e.Catagory).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DispOtherBy).IsFixedLength();

                entity.Property(e => e.DispScrapBy).IsFixedLength();

                entity.Property(e => e.DispScrapDetails).IsFixedLength();

                entity.Property(e => e.DispSortScrapBy).IsFixedLength();

                entity.Property(e => e.LastOp).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Run)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.RunNr)
                    .IsFixedLength()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.SapdocumentNumber).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Sloc).IsFixedLength();
            });

            modelBuilder.Entity<TblMrrholdDetails>(entity =>
            {
                entity.HasIndex(e => e.Id);

                entity.HasIndex(e => e.Mrrcode);

                entity.HasIndex(e => e.Mrryear);

                entity.HasIndex(e => new { e.Mrryear, e.Mrrcode })
                    .HasName("IX_tblMRRHoldDetails_FK_MRRHold");

                entity.HasIndex(e => new { e.Mrryear, e.Mrrcode, e.ResolutionDate, e.ToScrap, e.ToGood })
                    .HasName("tblMRRHoldDetails34");

                entity.Property(e => e.Mrrcode).HasDefaultValueSql("(0)");

                entity.Property(e => e.Mrryear).HasDefaultValueSql("(0)");

                entity.Property(e => e.ResolutionBy).IsFixedLength();

                entity.Property(e => e.ToGood).HasDefaultValueSql("(0)");

                entity.Property(e => e.ToScrap).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.Mrr)
                    .WithMany(p => p.TblMrrholdDetails)
                    .HasForeignKey(d => new { d.Mrryear, d.Mrrcode })
                    .HasConstraintName("FK_tblMRRHoldDetails_tblMRRHold");
            });

            modelBuilder.Entity<TblOeedownTimeDetails>(entity =>
            {
                entity.HasKey(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId });

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();
            });

            modelBuilder.Entity<TblOperators>(entity =>
            {
                entity.HasKey(e => e.OperatorId)
                    .IsClustered(false);

                entity.Property(e => e.OperatorId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPartAssembly2>(entity =>
            {
                entity.Property(e => e.PartId).IsFixedLength();
            });

            modelBuilder.Entity<TblPartGrades>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.Grade });

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();
            });

            modelBuilder.Entity<TblPartOrientations>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.Orientation });

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Orientation).IsFixedLength();
            });

            modelBuilder.Entity<TblPartRouting>(entity =>
            {
                entity.Property(e => e.PartId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Anodize).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy4).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy5).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assy6).HasDefaultValueSql("(0)");

                entity.Property(e => e.PadPrint).HasDefaultValueSql("(0)");

                entity.Property(e => e.Phosphate).HasDefaultValueSql("(0)");

                entity.Property(e => e.SkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.TinPlate).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblPartsOfInterest>(entity =>
            {
                entity.Property(e => e.PartId).IsUnicode(false);
            });

            modelBuilder.Entity<TblPartsPurchased>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PartNr)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ponumber)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPartsSold>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PartNr)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPersonnel>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .IsClustered(false);

                entity.HasIndex(e => e.CodeId);
            });

            modelBuilder.Entity<TblPistonIdAs400>(entity =>
            {
                entity.HasKey(e => e.GlpartId)
                    .HasName("PK_tblPurchacedPartIDs");

                entity.Property(e => e.GlpartId)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BuySell)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();
            });

            modelBuilder.Entity<TblPistonsPurchased>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Ponumber)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPistonsSold>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PartId)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TblPlrtrace>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__tblPLRTrace__40DCD857");
            });

            modelBuilder.Entity<TblPostAssembly>(entity =>
            {
                entity.HasKey(e => new { e.Padate, e.Shift, e.PartId, e.RunNr })
                    .IsClustered(false);

                entity.HasIndex(e => e.Padate)
                    .HasName("IX_tblPostAssembly_CoatDate");

                entity.HasIndex(e => e.PartId);

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Inspector).IsFixedLength();
            });

            modelBuilder.Entity<TblPostAssemblyDetails>(entity =>
            {
                entity.HasKey(e => new { e.Padate, e.Shift, e.PartId, e.Description, e.RunNr });

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();
            });

            modelBuilder.Entity<TblRingAssemblies>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.PartGroupId })
                    .IsClustered(false);

                entity.HasIndex(e => e.PartGroupId)
                    .HasName("IX_tblRingAssemblies_RingPartID");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.HasOne(d => d.PartGroup)
                    .WithMany(p => p.TblRingAssemblies)
                    .HasForeignKey(d => d.PartGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRingAssemblies_tblRingAssemblyParts");
            });

            modelBuilder.Entity<TblRingAssemblyAdjust>(entity =>
            {
                entity.HasKey(e => new { e.RingPartId, e.AdjustDate })
                    .IsClustered(false);

                entity.Property(e => e.Adjustment).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblRingAssemblyCount>(entity =>
            {
                entity.HasKey(e => new { e.PartGroupId, e.CountDate })
                    .IsClustered(false);

                entity.HasIndex(e => e.PartGroupId);

                entity.Property(e => e.CclipCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.LcompCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.RailCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodCount).HasDefaultValueSql("(0)");

                entity.Property(e => e.UcompCount).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.PartGroup)
                    .WithMany(p => p.TblRingAssemblyCount)
                    .HasForeignKey(d => d.PartGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRingAssemblyCount_tblRingAssemblyParts");
            });

            modelBuilder.Entity<TblRingAssemblyDetails>(entity =>
            {
                entity.HasKey(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .IsClustered(false);

                entity.HasIndex(e => e.CoatDate);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.PartId);

                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => e.Run);

                entity.HasIndex(e => e.Shift);

                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Run, e.RunNr, e.PartId })
                    .HasName("IX_tblRingAssemblyDetails_FK_tblCoating")
                    .IsUnique();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Run).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.CirclipQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpanderQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.LowerCompQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.RailQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodQty).HasDefaultValueSql("(0)");

                entity.Property(e => e.UpperCompQty).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.TblCoating)
                    .WithOne(p => p.TblRingAssemblyDetails)
                    .HasForeignKey<TblRingAssemblyDetails>(d => new { d.CoatDate, d.Shift, d.DepartmentId, d.Run, d.RunNr, d.PartId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRingAssemblyDetails_tblCoating");
            });

            modelBuilder.Entity<TblRingAssemblyIssued>(entity =>
            {
                entity.HasKey(e => new { e.PartGroupId, e.AdjustDate })
                    .IsClustered(false);

                entity.HasIndex(e => e.PartGroupId);

                entity.Property(e => e.CclipAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExpAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.LcompAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.PinAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.RailAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.RodAdjust).HasDefaultValueSql("(0)");

                entity.Property(e => e.UcompAdjust).HasDefaultValueSql("(0)");

                entity.HasOne(d => d.PartGroup)
                    .WithMany(p => p.TblRingAssemblyIssued)
                    .HasForeignKey(d => d.PartGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblRingAssemblyIssued_tblRingAssemlyParts");
            });

            modelBuilder.Entity<TblRingAssemblyParts>(entity =>
            {
                entity.HasKey(e => e.PartGroupId)
                    .IsClustered(false);
            });

            modelBuilder.Entity<TblRoute>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Bcode).IsUnicode(false);

                entity.Property(e => e.Cell).IsFixedLength();

                entity.Property(e => e.Currentqty).IsUnicode(false);

                entity.Property(e => e.Dcode).IsFixedLength();

                entity.Property(e => e.Die).IsFixedLength();

                entity.Property(e => e.Rlink1).IsUnicode(false);

                entity.Property(e => e.Rlink2).IsUnicode(false);

                entity.Property(e => e.Rlink3).IsUnicode(false);

                entity.Property(e => e.Spart).IsUnicode(false);

                entity.Property(e => e.Startqty).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Ycode).IsFixedLength();
            });

            modelBuilder.Entity<TblRouteList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tblRouteList");

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Bcode).IsUnicode(false);

                entity.Property(e => e.Cell).IsFixedLength();

                entity.Property(e => e.Currentqty).IsUnicode(false);

                entity.Property(e => e.Dcode).IsFixedLength();

                entity.Property(e => e.Die).IsFixedLength();

                entity.Property(e => e.Fmpart).IsUnicode(false);

                entity.Property(e => e.Rlink1).IsUnicode(false);

                entity.Property(e => e.Rlink2).IsUnicode(false);

                entity.Property(e => e.Rlink3).IsUnicode(false);

                entity.Property(e => e.Spart).IsUnicode(false);

                entity.Property(e => e.Startqty).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Ycode).IsFixedLength();
            });

            modelBuilder.Entity<TblRoutePart>(entity =>
            {
                entity.Property(e => e.Id).IsFixedLength();

                entity.Property(e => e.Fbasket).IsFixedLength();

                entity.Property(e => e.Fpart).IsFixedLength();

                entity.Property(e => e.Metal).IsFixedLength();

                entity.Property(e => e.Mpart).IsFixedLength();
            });

            modelBuilder.Entity<TblRoutePartList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tblRoutePartList");

                entity.Property(e => e.Fbasket).IsFixedLength();

                entity.Property(e => e.Fpart).IsFixedLength();

                entity.Property(e => e.Id).IsFixedLength();

                entity.Property(e => e.Metal).IsFixedLength();

                entity.Property(e => e.Mpart).IsFixedLength();
            });

            modelBuilder.Entity<TblRouteScrap>(entity =>
            {
                entity.Property(e => e.Id).IsFixedLength();

                entity.Property(e => e.Area).IsUnicode(false);

                entity.Property(e => e.Bcode).IsUnicode(false);

                entity.Property(e => e.Eeid).IsUnicode(false);

                entity.Property(e => e.Qty).IsUnicode(false);

                entity.Property(e => e.Scode).IsUnicode(false);
            });

            modelBuilder.Entity<TblScrapCodes>(entity =>
            {
                entity.HasKey(e => e.DefectId)
                    .IsClustered(false);

                entity.HasIndex(e => e.DefectId);

                entity.Property(e => e.DefectId).IsFixedLength();
            });

            modelBuilder.Entity<TblScrapCounts>(entity =>
            {
                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.TblScrapCounts)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ScrapCounts_tbl_Assy_Prod");

                entity.HasOne(d => d.ScrapCodeNavigation)
                    .WithMany(p => p.TblScrapCounts)
                    .HasForeignKey(d => d.ScrapCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ScrapCounts_tbl_SCodes");
            });

            modelBuilder.Entity<TblScrapList>(entity =>
            {
                entity.HasKey(e => e.ScrapId)
                    .HasName("pk_tbl_ScrapList");

                entity.HasOne(d => d.MachineCodeNavigation)
                    .WithMany(p => p.TblScrapList)
                    .HasForeignKey(d => d.MachineCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ScrapList_tbl_MachineNames");

                entity.HasOne(d => d.ScrapCodeNavigation)
                    .WithMany(p => p.TblScrapList)
                    .HasForeignKey(d => d.ScrapCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ScrapList_tbl_SCodes");
            });

            modelBuilder.Entity<TblSkirtCoat>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblSkirtCoatKey")
                    .IsUnique();

                entity.Property(e => e.BadFinish).HasDefaultValueSql("((0))");

                entity.Property(e => e.CoatingInGrooves).HasDefaultValueSql("((0))");

                entity.Property(e => e.Debris).HasDefaultValueSql("(0)");

                entity.Property(e => e.DebrisNonM).HasDefaultValueSql("(0)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.HandlingMachine).HasDefaultValueSql("((0))");

                entity.Property(e => e.HandlingPersonnel).HasDefaultValueSql("((0))");

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun).IsFixedLength();

                entity.Property(e => e.RunNr).IsFixedLength();

                entity.Property(e => e.SetUpScrap).HasDefaultValueSql("((0))");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.Voids).HasDefaultValueSql("((0))");

                entity.Property(e => e.WipeOffReruns).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TblSkirtCoatCount>(entity =>
            {
                entity.Property(e => e.CoatNr).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblSpecialData>(entity =>
            {
                entity.HasKey(e => e.FieldName)
                    .IsClustered(false);
            });

            modelBuilder.Entity<TblStdHours>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblTinPlate>(entity =>
            {
                entity.HasIndex(e => new { e.CoatDate, e.Shift, e.DepartmentId, e.Prun, e.RunNr, e.PartId })
                    .HasName("U_tblTinPlateKey")
                    .IsUnique();

                entity.Property(e => e.Adhesion).HasDefaultValueSql("(0)");

                entity.Property(e => e.CoatThick).HasDefaultValueSql("(0)");

                entity.Property(e => e.Corrosion).HasDefaultValueSql("(0)");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.GrossProduction).HasDefaultValueSql("(0)");

                entity.Property(e => e.Handling).HasDefaultValueSql("(0)");

                entity.Property(e => e.HoistFail).HasDefaultValueSql("(0)");

                entity.Property(e => e.IncompleteCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadAnodizing).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadFoundry).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadMachining).HasDefaultValueSql("(0)");

                entity.Property(e => e.NadSkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartId)
                    .IsFixedLength()
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.Prun)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RunNr)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.TestScrap).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblTolerances>(entity =>
            {
                entity.HasKey(e => new { e.PartId, e.ComponentId });

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.ComponentId).IsFixedLength();
            });

            modelBuilder.Entity<TblTwtags>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LoggingName).IsUnicode(false);
            });

            modelBuilder.Entity<TblUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_tblUsersInsp")
                    .IsClustered(false);

                entity.HasIndex(e => e.FdrySecurity)
                    .HasName("IX_tblUsers_InspSecurity");

                entity.HasIndex(e => e.InspSecurity)
                    .HasName("IX_tblUsers_SecurityCode");

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Initial).IsFixedLength();
            });

            modelBuilder.Entity<TblWebMail>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.MailGroup });
            });

            modelBuilder.Entity<Tblprotopartparameters>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<TblxtDefectCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.CategoryId).IsFixedLength();
            });

            modelBuilder.Entity<TblxtDepart>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .IsClustered(false);

                entity.HasIndex(e => e.DepartmentId);

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.DeptAbbrev).IsFixedLength();
            });

            modelBuilder.Entity<TblxtPart>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .IsClustered(false);

                entity.HasIndex(e => e.AlloyCode)
                    .HasName("IX_tblxtPartFmly_AlloyCode");

                entity.HasIndex(e => e.PartCode)
                    .HasName("IX_tblxtPartFmly_PartCode");

                entity.HasIndex(e => e.PartId);

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.AlloyCode).IsFixedLength();

                entity.Property(e => e.CastingPartId).IsFixedLength();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Customer).IsUnicode(false);

                entity.Property(e => e.Dead).HasDefaultValueSql("(0)");

                entity.Property(e => e.FoundryNumber).IsUnicode(false);

                entity.Property(e => e.LastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.Mconly).HasDefaultValueSql("(0)");

                entity.Property(e => e.MisMatchCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartCode).IsFixedLength();

                entity.Property(e => e.PartDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.PipCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.Tponly).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblxtPartAssembly>(entity =>
            {
                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Anodize).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly1).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly2).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly3).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly4).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly5).HasDefaultValueSql("(0)");

                entity.Property(e => e.Assembly6).HasDefaultValueSql("(0)");

                entity.Property(e => e.ManualPackout).HasDefaultValueSql("(0)");

                entity.Property(e => e.PostAssy).HasDefaultValueSql("(0)");

                entity.Property(e => e.SkirtCoat).HasDefaultValueSql("(0)");

                entity.Property(e => e.TinPlate).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblxtPartFmly>(entity =>
            {
                entity.HasIndex(e => e.AlloyCode);

                entity.Property(e => e.AlloyCode).IsFixedLength();

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.Customer).IsFixedLength();

                entity.Property(e => e.IsDead).HasDefaultValueSql("(0)");

                entity.Property(e => e.LastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.MisMatchCheck).HasDefaultValueSql("(0)");

                entity.Property(e => e.PartPerBasket).HasDefaultValueSql("(700)");

                entity.Property(e => e.PartWt).HasDefaultValueSql("(0)");

                entity.Property(e => e.PipCheck).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<TblxtProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId)
                    .IsClustered(false);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.ProcessId);

                entity.Property(e => e.ProcessId).IsFixedLength();

                entity.Property(e => e.DepartmentId).IsFixedLength();
            });

            modelBuilder.Entity<TblxtScrapDept>(entity =>
            {
                entity.HasIndex(e => e.ScrapDept)
                    .HasName("IXU_tblxtScrapDept_ScrapDept")
                    .IsUnique();

                entity.Property(e => e.ScrapDeptId).IsFixedLength();
            });

            modelBuilder.Entity<TblxtScrapDeptArea>(entity =>
            {
                entity.HasKey(e => new { e.ScrapDeptId, e.ScrapDeptAreaId });

                entity.HasIndex(e => e.ScrapDeptId);

                entity.Property(e => e.ScrapDeptId).IsFixedLength();

                entity.Property(e => e.ScrapDeptAreaId).IsFixedLength();

                entity.Property(e => e.DefectDepartment).IsFixedLength();

                entity.HasOne(d => d.ScrapDept)
                    .WithMany(p => p.TblxtScrapDeptArea)
                    .HasForeignKey(d => d.ScrapDeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblxtScrapDeptArea_tblxtScrapDept");
            });

            modelBuilder.Entity<TblxtScrapDeptAreaDef>(entity =>
            {
                entity.HasKey(e => new { e.ScrapDeptId, e.ScrapDeptAreaId, e.ScrapDeptAreaDefectId });

                entity.HasIndex(e => e.HepworthId);

                entity.HasIndex(e => e.ScrapDeptAreaDefect)
                    .HasName("IX_tblxtScrapDeptAreaDef_Defect");

                entity.HasIndex(e => e.SummaryId);

                entity.Property(e => e.ScrapDeptId).IsFixedLength();

                entity.Property(e => e.ScrapDeptAreaId).IsFixedLength();

                entity.Property(e => e.ScrapDeptAreaDefectId).IsFixedLength();

                entity.Property(e => e.HepworthId).IsFixedLength();

                entity.Property(e => e.SummaryId).IsFixedLength();

                entity.HasOne(d => d.Summary)
                    .WithMany(p => p.TblxtScrapDeptAreaDef)
                    .HasForeignKey(d => d.SummaryId)
                    .HasConstraintName("FK_tblxtScrapDeptAreaDef_tblHepSummary");

                entity.HasOne(d => d.ScrapDept)
                    .WithMany(p => p.TblxtScrapDeptAreaDef)
                    .HasForeignKey(d => new { d.ScrapDeptId, d.ScrapDeptAreaId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblxtScrapDeptAreaDef_tblxtScrapDeptArea");
            });

            modelBuilder.Entity<TmpInspSummary>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Line).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.RunId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAnodizeReport2016>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_anodizeReport2016");

                entity.Property(e => e.AnodizeId).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy2");

                entity.Property(e => e.Assembly2Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy3");

                entity.Property(e => e.Assembly3Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy4>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy4");

                entity.Property(e => e.Assembly4Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy5>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy5");

                entity.Property(e => e.Assembly5Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy6>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy6");

                entity.Property(e => e.Assembly6Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy7>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy7");

                entity.Property(e => e.Assembly7Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssy8>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assy8");

                entity.Property(e => e.Assembly8Id).ValueGeneratedOnAdd();

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.Orientation).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewAssyDowntime>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_AssyDowntime");
            });

            modelBuilder.Entity<ViewAssyDtloss>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_AssyDTLoss");
            });

            modelBuilder.Entity<ViewAssyRejects>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_AssyRejects");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewAssyScrap>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_assyScrap");
            });

            modelBuilder.Entity<ViewFoundryscrapAF>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_foundryscrap_A&F");

                entity.Property(e => e.Dept).IsUnicode(false);

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<ViewSc2016>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_SC_2016");

                entity.Property(e => e.EnteredBy).IsFixedLength();

                entity.Property(e => e.Grade).IsFixedLength();

                entity.Property(e => e.Machine).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();

                entity.Property(e => e.SkirtCoatId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewScrapCountsArea>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_ScrapCounts_Area");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalAnodAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_TotalAnod_Assy");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalAssyAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_TotalAssy_Assy");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalFoundryAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_TotalFoundry_Assy");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalMachAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_TotalMach_Assy");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<ViewTotalScAssy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_TotalSC_Assy");

                entity.Property(e => e.Area).IsUnicode(false);
            });

            modelBuilder.Entity<VwAnodizeByDateShiftLinePart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_AnodizeByDateShiftLinePart");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<VwCastingPartTranslate>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_CastingPartTranslate");

                entity.Property(e => e.CastingPartId).IsFixedLength();

                entity.Property(e => e.MachPartId).IsFixedLength();
            });

            modelBuilder.Entity<VwDateShifts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DateShifts");

                entity.Property(e => e.Shift).IsFixedLength();
            });

            modelBuilder.Entity<VwDefects>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Defects");

                entity.Property(e => e.DefectDepartment).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.HepworthId).IsFixedLength();

                entity.Property(e => e.SummaryId).IsFixedLength();
            });

            modelBuilder.Entity<VwDefectsNumericOnly>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DefectsNumericOnly");

                entity.Property(e => e.DefectDepartment).IsFixedLength();

                entity.Property(e => e.DefectId).IsFixedLength();

                entity.Property(e => e.HepworthId).IsFixedLength();

                entity.Property(e => e.SummaryId).IsFixedLength();
            });

            modelBuilder.Entity<VwSkirtcoatByDateShiftLinePart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_SkirtcoatByDateShiftLinePart");

                entity.Property(e => e.DepartmentId).IsFixedLength();

                entity.Property(e => e.PartId).IsFixedLength();

                entity.Property(e => e.Shift).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
