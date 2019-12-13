using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.SAP;

namespace FmsbwebCoreApi.Services.SAP
{
    public interface ISapLibraryRepository
    {
        IEnumerable<Scrap2Summary2> GetScrap(DateTime start, DateTime end);
        Task<ProductionMorningMeetingDto> GetProductionData(DateTime start, DateTime end, string area);
        ScrapByCodeDto GetScrapByCode(List<Models.SAP.Scrap> scrap, string area, bool isSbScrap, int sapNet);
        DepartmentScrapDto GetDepartmentScrap(List<Models.SAP.Scrap> scrap, string area, int sapNet);
        SapProductionByTypeDto GetSapProductionByType(List<SapProdDto> sapProd, string area);

        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByScrapAreaFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<Models.SAP.Scrap>> GetScrapDataByDepartmentFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<SapProdDto>> GetSapProdByAreaFromDb(DateTime start, DateTime end, string area);
        Task<IEnumerable<SapProdDto>> GetSapProdByTypeFromDb(DateTime start, DateTime end, string area);
        IEnumerable<Models.SAP.KpiTargets> GetInMemoryKpiTarget(string area, string type);
        string GetColorCode(string area, string type, decimal? value);

    }
}
