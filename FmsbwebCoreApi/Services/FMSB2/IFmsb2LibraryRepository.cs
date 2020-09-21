using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.SAP;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.FMSB2
{
    public interface IFmsb2LibraryRepository
    {
        #region Labor Hours

        List<FinanceLaborHoursView> TransformLaborHoursData(IEnumerable<FinanceLaborHoursView> data, string dept = "");
        Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime startDate, DateTime endDate);
        Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime startDate, DateTime endDate, string area);
        Task<List<FinanceLaborHoursView>> GetPlantLaborHours(DateTime startDate, DateTime endDate);
        ProductionLaborHoursDto GetLaborHours(List<FinanceLaborHoursView> laborHrs);
        ProductionLaborHoursDto GetRollingDaysPPMH(
            IEnumerable<SapProdDto> prodData,
            List<FinanceLaborHoursView> laborHrs,
            DateTime startDate,
            DateTime endDate);

        ProductionLaborHoursDto GetPPMH(int sapNet, List<FinanceLaborHoursView> laborHrs);

        Task<List<SapProdDto>> GetProdForLaborHrs(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<WeeklyProductionLaborHoursDto>> GetWeeklyProdScrapForLaborHrs(DateTime startDate, DateTime endDate, string area);

        Task<dynamic> GetOvertimePercentage(string dept, DateTime start, DateTime end);

        #endregion

        #region Finance

        Task<IEnumerable<FinanceDailyKpi>> GetFinanceDailyKpi(DateTime date);
        Task<IEnumerable<FinanceDeptFcst>> GetFinanceDeptForecast(int year, int month);
        Task<IEnumerable<FinanceFlashProjections>> GetFinanceFlashProjections(int year, int month);
        Task<FinaceKpiDto> GetFinanceKpi(DateTime date);

        #endregion

        #region Targets

        Task<KpiTarget> GetTargets(string area, DateTime endDate);
        Task<List<KpiTarget>> GetTargets(string area, int startDateYear, int endDateYear);
        Task<KpiTarget> GetTargets(string area, DateTime startDate, DateTime endDate);

        #endregion


    }
}
