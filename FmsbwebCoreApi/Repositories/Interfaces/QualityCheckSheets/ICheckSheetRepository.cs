using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Controllers.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;

namespace FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets
{
    public interface ICheckSheetRepository : ICrudRepository<CheckSheet>
    {
        Task<CheckSheet> IsExist(CheckSheet data);
    }
}
