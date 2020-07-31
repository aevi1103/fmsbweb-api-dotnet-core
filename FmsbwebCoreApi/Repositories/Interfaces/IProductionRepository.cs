using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Entity.SAP;
using FmsbwebCoreApi.Models.Intranet;
using FmsbwebCoreApi.ResourceParameters;

namespace FmsbwebCoreApi.Repositories.Interfaces
{
    public interface IProductionRepository
    {
        IQueryable<Production2> GetProductionQueryable(ProductionResourceParameter resourceParameter);

        Task<HxhProductionByLineAndProgramDto> GetHxhProdByLineAndProgram(ProductionResourceParameter resourceParameter);
        Task<HxHProductionByLineDto> GetHxhProductionByLine(ProductionResourceParameter resourceParameter);
        Task<List<HxHProductionByLineDto>> GetHxhProductionTempTable(ProductionResourceParameter resourceParameter);
        Task<List<HxHProd>> GetHxHProduction(ProductionResourceParameter resourceParameter);
    }
}
