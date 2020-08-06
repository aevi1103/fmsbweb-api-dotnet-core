using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.SAP;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters.SAP;
using Scrap = FmsbwebCoreApi.Models.SAP.Scrap;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IScrapService : IScrapRepository
    {
        Task<dynamic> GetDailyScrapByShift(DailyScrapByShiftResourceParameter resourceParams);

        Task<List<DailyScrapByShiftDateDto>> GetDailyScrapRate(DateTime start, DateTime end, string area, bool isPurchasedScrap = false);
        List<Scrap> GetScrapSummary(List<Scrap2> data);
    }
}
