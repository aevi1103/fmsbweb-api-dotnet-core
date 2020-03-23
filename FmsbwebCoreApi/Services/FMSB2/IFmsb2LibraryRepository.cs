using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Models.FMSB2;
using FmsbwebCoreApi.Models.SAP;

namespace FmsbwebCoreApi.Services.FMSB2
{
    public interface IFmsb2LibraryRepository
    {
        #region Labor Hours

        List<FinanceLaborHoursView> TransformLaborHoursData(
                IEnumerable<FinanceLaborHoursView> data, string dept = "");

        Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime start, DateTime end);
        ProductionLaborHoursDto GetLaborHours(List<FinanceLaborHoursView> laborHrs, string dept = "");
        ProductionLaborHoursDto GetRollingDaysPPMH(
            IEnumerable<SapProdDto> prodData,
            IEnumerable<Scrap> scrapData,
            List<FinanceLaborHoursView> laborHrs,
            DateTime start,
            DateTime end,
            string area);

        ProductionLaborHoursDto GetPPMH(int sapGross, List<FinanceLaborHoursView> laborHrs, string area);

        Task<ProdScrapForLaborHours> GetProdScrapForLaborHrs(DateTime start, DateTime end, string area);
        Task<IEnumerable<WeeklyProductionLaborHoursDto>> GetWeeklyProdScrapForLaborHrs(DateTime start, DateTime end, string area);

        #endregion

        #region Finance

        Task<IEnumerable<FinanceDailyKpi>> GetFinanceDailyKpi(DateTime date);
        Task<IEnumerable<FinanceDeptFcst>> GetFinanceDeptForecast(int year, int month);
        Task<IEnumerable<FinanceFlashProjections>> GetFinanceFlashProjections(int year, int month);
        Task<FinaceKpiDto> GetFinanceKpi(DateTime date);

        #endregion

        #region KPI Targets

        Task<KpiTarget> GetTargets(string dept, DateTime endDate);
        Task<List<KpiTarget>> GetTargets(string area, int startYear, int endYear);

        #endregion

    }
}
