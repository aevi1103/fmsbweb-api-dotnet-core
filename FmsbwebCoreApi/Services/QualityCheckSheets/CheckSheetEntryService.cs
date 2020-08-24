using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.QualityCheckSheets;
using FmsbwebCoreApi.Services.Interfaces.QualityCheckSheets;

namespace FmsbwebCoreApi.Services.QualityCheckSheets
{
    public class CheckSheetEntryService : CheckSheetEntryRepository, ICheckSheetEntryService
    {
        public CheckSheetEntryService(QualityCheckSheetsContext context) : base(context)
        {
        }

        public async Task<CheckSheetEntry> AddOrUpdate(CheckSheetEntry data)
        {
            var entity = await IsExist(data);

            if (entity != null)
                data.CheckSheetEntryId = entity.CheckSheetEntryId;

            return await Update(data);
        }
    }
}
