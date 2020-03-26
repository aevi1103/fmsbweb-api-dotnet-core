using FmsbwebCoreApi.Models.Intranet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Intranet
{
    public interface IIntranetLibraryRepository
    {
        Task<IEnumerable<HxhProductionDto>> GetHxhProduction(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime startDate, DateTime endDate, string area);
        Task<IEnumerable<HxHTargetDto>> HxHTargetByArea(DateTime startDate, DateTime endDate, string area);
        Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineAndProgram(DateTime startDate, DateTime endDate, string area);
    }
}
