using System;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Entity.Fmsb2;
using FmsbwebCoreApi.Repositories.Interfaces;

namespace FmsbwebCoreApi.Repositories
{
    public class ProjectTrackerRepository : IProjectTrackerRepository
    {
        private readonly Fmsb2Context _context;

        public ProjectTrackerRepository(Fmsb2Context context)
        {
            _context = context;
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
