using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.ResourceParameters.SAP;

namespace FmsbwebCoreApi.Services.SAP
{
    public interface ISapLibraryRepository
    {
        //scrap
        ScrapByCodeDto GetScrapByCode(List<Models.SAP.Scrap> scrap, string area, bool isSbScrap, int sapNet);
        DepartmentScrapDto GetDepartmentScrap(List<Models.SAP.Scrap> scrap, string area, int sapNet);
        SapProductionByTypeDto GetSapProductionByType(List<SapProdDto> sapProd, string area);
        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByScrapAreaFromDb(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByDepartmentFromDb(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<DailyScrapByShiftDto>> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams);
        Task<IEnumerable<dynamic>> GetScrapByProgram(DateTime startDate, DateTime endDate, string area, bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetScrapByShift(DateTime startDate, DateTime endDate, string area, bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetScrapByDept(DateTime startDate, DateTime endDate, bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetPlantWideScrapVariance(DateTime startDate, DateTime endDate, string area = "", bool isPurchasedScrap = false);
    

        //prod
        Task<IEnumerable<SapProdDto>> GetSapProdByAreaFromDb(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime startDate, DateTime endDate, string area);
        Task<GetSapProdAndScrapDto> GetSapProdAndScrap(DateTime startDate, DateTime endDate, string area);

        //prod and scrap and labor hours
        Task<ProductionMorningMeetingDto> GetProductionData(DateTime startDate, DateTime endDate, string area);

        //prod scrap downtime
        Task<DepartmentKpiDto> GetDepartmentKpi(DateTime startDate, DateTime endDate, string area);

        //labor hours
        Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<dynamic>> GetPpmhPerShiftVariance(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<dynamic>> GetPlantWidePpmh(DateTime startDate, DateTime endDate);
        decimal? CalculatePlantPpmh(decimal? overallHours, decimal? sapNetDmax, decimal sapNetLessDmax);
        decimal? GetOverallHours(decimal? regular, decimal? overtime, decimal? doubleTime, decimal? orientation);
        decimal? GetOverallHoursLessDmax(decimal? overallHours, decimal? sapNetDmax, decimal? sapNetLessDmax);
        //prod, scrap, downtime, components
        IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxHProductionByLineDto> hxh,
            IEnumerable<Models.SAP.Scrap> warmers,
            IEnumerable<SwotTargetWithDeptId> lineTargets);

        IEnumerable<ProductionByProgramDto> GetDepartmentDetailsByProgram(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxhProductionByProgramDto> hxh);

        Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime startDate, DateTime endDate, string area);

        //targets
        IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget();

        //utils
        string GetColorCode(KpiTarget targets, string type, decimal? value);
        int MapShiftToShiftOrder(string shift);

        //charts
        Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRateByCode(
            DateTime startDate, DateTime endDate, string area,
            bool isPurchasedScrap = false);

        Task<IEnumerable<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDate, DateTime endDate, string area);

        MachineMapping GetMappedLineToWorkCenter(string line, string side);

        Task<List<MachineMappingDto>> GetWorkcentersByDept(string dept);

    }
}
