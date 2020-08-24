using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;

namespace FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets
{
    public interface ICheckSheetEntryService : ICheckSheetEntryRepository
    {
        Task<CheckSheetEntry> AddOrUpdate(CheckSheetEntry data);
    }
}
