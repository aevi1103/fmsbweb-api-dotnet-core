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
        private readonly QualityCheckSheetsContext _context;
        private readonly IReCheckService _reCheckService;

        public CheckSheetEntryService(QualityCheckSheetsContext context, IReCheckService reCheckService) : base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _reCheckService = reCheckService ?? throw new ArgumentNullException(nameof(reCheckService));
        }

        public async Task<CheckSheetEntry> AddOrUpdate(CheckSheetEntry data)
        {
            var entity = await IsExist(data);

            if (entity != null)
                data.CheckSheetEntryId = entity.CheckSheetEntryId;

            return await Update(data);
        }

        public async Task<CheckSheetEntry> AddInitialReCheck(ReCheck data)
        {
            var hasInitial = await _reCheckService.HasInitialReCheck(data.CheckSheetEntryId);
            if (hasInitial) return null;
            await _reCheckService.Update(data);
            return await GetById(data.CheckSheetEntryId);
        }
    }
}
