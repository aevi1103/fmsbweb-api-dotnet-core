using FmsbwebCoreApi.Models.Intranet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FmsbwebCoreApi.Services.Intranet
{
    public interface IIntranetLibraryRepository
    {
        Task<IEnumerable<HxhProductionDto>> GetHxhProduction(DateTime start, DateTime end, string area);
        Task<IEnumerable<DailyHxHTargetDto>> DailyHxHTargetByArea(DateTime start, DateTime end, string area);
    }
}
