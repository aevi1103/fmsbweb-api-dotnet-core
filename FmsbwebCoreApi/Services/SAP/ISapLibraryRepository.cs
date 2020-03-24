using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByScrapAreaFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByDepartmentFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<DailyScrapByShiftDto>> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams);
        Task<IEnumerable<dynamic>> GetScrapByProgram(DateTime start, DateTime end, string area, bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetPlantWideScrapVariance(DateTime start, DateTime end, string area = "", bool isPurchasedScrap = false);

        //prod
        Task<IEnumerable<SapProdDto>> GetSapProdByAreaFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime start, DateTime end, string area);
        Task<GetSapProdAndScrapDto> GetSapProdAndScrap(DateTime start, DateTime end, string area);

        //prod and scrap and labor hours
        Task<ProductionMorningMeetingDto> GetProductionData(DateTime start, DateTime end, string area);

        //labor hours
        Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(DateTime start, DateTime end, string area);

        //prod, scrap, downtime, components
        IEnumerable<ProductionByLineDto> GetDepartmentDetailsByLine(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxHProductionByLineDto> hxh,
            IEnumerable<Models.SAP.Scrap> warmers);

        IEnumerable<ProductionByProgramDto> GetDepartmentDetailsByProgram(
            IEnumerable<Models.SAP.Scrap> scrap,
            IEnumerable<SapProdDetailDto> prod,
            IEnumerable<HxhProductionByProgramDto> hxh);

        Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime start, DateTime end, string area);

        //targets
        IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget();

        //utils
        string GetColorCode(string area, string type, decimal? value, DateTime dateEnd);
        string MapAreaTopScrapArea(string area);
        int MapShiftToShiftOrder(string shift);

        //charts
        Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRateByCode(
            DateTime start, DateTime end, string area,
            bool isPurchasedScrap = false);

        Task<IEnumerable<DepartmentKpiDto>> GetDailyKpiChart(DateTime start, DateTime end, string area);

        MachineMapping GetMappedLineToWorkCenter(string line, string side);

        Task<List<MachineMappingDto>> GetWorkcentersByDept(string dept);

    }
}
