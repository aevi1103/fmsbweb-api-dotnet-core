using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.ResourceParameters;
using Microsoft.AspNetCore.Razor.Language.Intermediate;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories
{
    public class ProjectTrackerRepository : IProjectTrackerRepository
    {
        private readonly Fmsb2Context _context;

        public ProjectTrackerRepository(Fmsb2Context context)
        {
            _context = context;
        }

        public IQueryable<ProjectTracker> GetQry(ProjectTrackerResourceParameter parameters)
        {
            var qry = _context.ProjectTracker
                .Where(x => x.DateTimeRequested >= parameters.StartDateTime && x.DateTimeRequested <= parameters.EndDateTime)
                .Where(x => x.ProjectName.ToLower().Trim().Contains(parameters.SearchKeyword) || x.ProjectDescription.ToLower().Trim().Contains(parameters.SearchKeyword))
                .AsNoTracking()
                .AsQueryable();

            return qry;
        }

        public async Task<ProjectTracker> AddOrUpdate(ProjectTracker data)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var result = _context.ProjectTracker.Update(data);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return result.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<ProjectTracker> Delete(int id)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                var result = _context.ProjectTracker.Remove(new ProjectTracker { ProjectTrackerId = id});
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return result.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }
    }
}
