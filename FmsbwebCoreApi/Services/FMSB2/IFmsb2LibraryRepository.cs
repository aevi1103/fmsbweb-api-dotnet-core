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

        List<FinanceLaborHoursView> TransformLaborHoursData(
                IEnumerable<FinanceLaborHoursView> data, string dept = "");

        Task<List<FinanceLaborHoursView>> GetLaborHoursData(DateTime startDate, DateTime endDate);
        ProductionLaborHoursDto GetLaborHours(List<FinanceLaborHoursView> laborHrs, string dept = "");
        ProductionLaborHoursDto GetRollingDaysPPMH(
            IEnumerable<SapProdDto> prodData,
            IEnumerable<Scrap> scrapData,
            List<FinanceLaborHoursView> laborHrs,
            DateTime startDate,
            DateTime endDate,
            string area);

        ProductionLaborHoursDto GetPPMH(int sapGross, List<FinanceLaborHoursView> laborHrs, string area);

        Task<ProdScrapForLaborHours> GetProdScrapForLaborHrs(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<WeeklyProductionLaborHoursDto>> GetWeeklyProdScrapForLaborHrs(DateTime startDate, DateTime endDate, string area);


        Task<IEnumerable<FinanceDailyKpi>> GetFinanceDailyKpi(DateTime date);
        Task<IEnumerable<FinanceDeptFcst>> GetFinanceDeptForecast(int year, int month);
        Task<IEnumerable<FinanceFlashProjections>> GetFinanceFlashProjections(int year, int month);
        Task<FinaceKpiDto> GetFinanceKpi(DateTime date);


        Task<KpiTarget> GetTargets(string dept, DateTime endDate);
        Task<List<KpiTarget>> GetTargets(string area, int startDateYear, int endDateYear);


    }
}
