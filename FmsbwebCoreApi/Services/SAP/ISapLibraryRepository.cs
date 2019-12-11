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
        IEnumerable<ProductionMorningMeetingDto> GetProductionData(DateTime start, DateTime end);
        IEnumerable<ScrapByCodeDto> GetScrapByCode(List<Models.SAP.Scrap> scrap, string area, bool isSbScrap, int sapNet);
        IEnumerable<DepartmentScrapDto> GetDepartmentScrap(List<Models.SAP.Scrap> scrap, string area, int sapNet);

    }
}
