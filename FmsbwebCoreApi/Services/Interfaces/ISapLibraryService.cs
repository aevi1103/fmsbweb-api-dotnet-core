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
        Task<IEnumerable<dynamic>> GetScrapByShift(DateTime startDate, DateTime endDate, string area, bool isPurchasedScrap = false);
        Task<IEnumerable<DailyScrapByShiftDateDto>> GetDailyScrapRate(DateTime startDate, DateTime endDate, string area,bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetScrapByDept(DateTime startDate, DateTime endDate, bool isPurchasedScrap = false);
        Task<IEnumerable<dynamic>> GetPlantWideScrapVariance(DateTime startDate, DateTime endDate, string area = "", bool isPurchasedScrap = false);

        Task<List<dynamic>> GetScrapVariancePerProgram(DateTime startDate, DateTime endDate, string area = "",
            bool isPurchasedScrap = false, bool isPlantTotal = false);

        #endregion

        #region Production KPI

        Task<GetSapProdAndScrapDto> GetSapProdAndScrap(DateTime startDate, DateTime endDate, string area);

        /// <summary>
        /// Get production data with labor hours
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        Task<ProductionMorningMeetingDto> GetProductionData(DateTime startDate, DateTime endDate, string area);


        /// <summary>
        /// Get production data with downtime
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        Task<DepartmentKpiDto> GetDepartmentKpi(DateTime startDate, DateTime endDate, string area);

        /// <summary>
        /// Get Production details by line filtered by area
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="area"></param>
        /// <returns></returns>
        Task<DepartmentDetailsDto> GetDepartmentDetails(DateTime startDate, DateTime endDate, string area);

        Task<IEnumerable<DailyDepartmentKpiDto>> GetDailyKpiChart(DateTime startDate, DateTime endDate, string area);

        #endregion

        #region Labor Hours

        Task<IEnumerable<dynamic>> GetPpmhPerDeptPlantWideVariance(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<dynamic>> GetPpmhPerShiftVariance(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<dynamic>> GetPlantWidePpmh(DateTime startDate, DateTime endDate);

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
