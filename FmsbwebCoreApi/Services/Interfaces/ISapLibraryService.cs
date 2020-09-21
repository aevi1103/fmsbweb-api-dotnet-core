using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters.SAP;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface ISapLibraryService
    {
        #region Scrap

        Task<dynamic> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams);
        Task<IEnumerable<dynamic>> GetScrapByShift(SapResourceParameter @params);
        Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRate(DateTime startDate, DateTime endDate, string area,bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetScrapByDept(SapResourceParameter @params);
        Task<IEnumerable<dynamic>> GetPlantWideScrapVariance(DateTime startDate, DateTime endDate, string area = "", bool isPurchasedScrap = false);

        Task<List<dynamic>> GetScrapVariance(SapResourceParameter @params);

        Task<List<dynamic>> GetScrapVariancePerProgram(SapResourceParameter @params);

        #endregion

        #region Production KPI

        Task<GetSapProdAndScrapDto> GetSapProdAndScrap(SapResourceParameter @params);
        Task<ProductionMorningMeetingDto> GetProductionData(SapResourceParameter @params);
        Task<DepartmentKpiDto> GetDepartmentKpi(SapResourceParameter @params);
        Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime startDate, DateTime endDate, string area);

        Task<IEnumerable<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDate, DateTime endDate, string area);

        #endregion

        #region Labor Hours

        Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(SapResourceParameter @params);
        Task<IEnumerable<dynamic>> GetPpmhPerShiftVariance(SapResourceParameter @params);
        Task<IEnumerable<dynamic>> GetPlantWidePpmh(SapResourceParameter @params);

        #endregion

        #region Charts

        /// <summary>
        /// Map HxH line into a work center
        /// </summary>
        /// <param name="line"></param>
        /// <param name="side"></param>
        /// <returns></returns>
        MachineMapping GetMappedLineToWorkCenter(string line, string side);

        Task<List<MachineMappingDto>> GetWorkCentersByDept(string dept);

        #endregion

    }
}
