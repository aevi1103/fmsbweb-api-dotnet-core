using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IProductionService : IProductionRepository
    {
        Task<List<HxHProductionByLineDto>> GetHourByHourProductionByLine(ProductionResourceParameter resourceParameter, List<Scrap2> scrap);
        Task<List<HourlyProductionDto>> GetHourByHourProductionByHour(ProductionResourceParameter resourceParameter, List<Scrap2> scrap, List<SwotTargetWithDeptId> target);

        Task<IEnumerable<HxhProductionDto>> GetHxhProduction(DateTime start, DateTime end, string area);
        Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineAndProgram(DateTime start, DateTime end, string area, string shift = "");
        Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime start, DateTime end, string area);
        Task<IEnumerable<HxHTargetDto>> HxHTargetByArea(DateTime startDate, DateTime endDate, string area);
    }
}
