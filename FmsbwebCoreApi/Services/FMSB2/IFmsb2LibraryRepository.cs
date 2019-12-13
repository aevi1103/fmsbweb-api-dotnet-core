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
        Task<ProdScrapForLaborHours> GetProdScrapForLaborHrs(DateTime start, DateTime end, string area);
    }
}
