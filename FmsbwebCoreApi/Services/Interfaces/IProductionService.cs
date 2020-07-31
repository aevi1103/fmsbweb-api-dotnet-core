using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Services.Interfaces
{
    public interface IProductionService : IProductionRepository
    {
        Task<List<HxHProductionByLineDto>> GetHourByHourProduction(ProductionResourceParameter resourceParameter, List<Scrap2> scrap);
    }
}
