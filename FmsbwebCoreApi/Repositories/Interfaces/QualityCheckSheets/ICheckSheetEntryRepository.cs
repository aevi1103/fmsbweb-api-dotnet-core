using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;

namespace FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets
{
    public interface ICheckSheetEntryRepository : ICrudRepository<CheckSheetEntry>
    {
        Task<CheckSheetEntry> IsExist(CheckSheetEntry data);
    }
}
