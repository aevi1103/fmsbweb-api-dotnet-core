using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IScrapRepository
    {
        IQueryable<Scrap2> GetScrap2Queryable(ScrapResourceParameter resourceParameter, bool excludeWarmers = true);
        Task<List<ScrapAreaCode>> GetScrapAreaCodes();
    }
}
