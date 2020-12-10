using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.Iconics;
using FmsbwebCoreApi.Entity.Intranet;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.FMSB2;  
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IProductionRepository
    {
        IQueryable<Production2> GetProductionQueryable(ProductionResourceParameter resourceParameter);
        IQueryable<KepserverPermCountsHistory> GetPlcProductionQueryable(PlcProdResourceParameter resourceParameter);
        Task<List<HxHProdDto>> GetHxHProduction(ProductionResourceParameter resourceParameter);
        Task<List<HxHProdDto>> GetMachiningEosProduction(DateTime start, DateTime end, string shift = "");
    }
}
