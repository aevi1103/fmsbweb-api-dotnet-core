using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;

namespace FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets
{
    public interface IReCheckRepository : ICrudRepository<ReCheck>
    {
        Task<bool> HasInitialReCheck(int checkSheetEntryId);
        Task<ReCheck> GetLatestRecheck(int checkSheetEntryId);
        Task<ReCheck> GetByIdNoTracking(int id);
    }
}
