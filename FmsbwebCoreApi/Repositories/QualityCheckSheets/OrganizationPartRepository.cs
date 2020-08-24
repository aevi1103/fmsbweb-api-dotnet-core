using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Repositories.Interfaces;
using FmsbwebCoreApi.Repositories.Interfaces.QualityCheckSheets;
using Microsoft.EntityFrameworkCore;

namespace FmsbwebCoreApi.Repositories.QualityCheckSheets
{
    public class OrganizationPartRepository : IOrganizationPartRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public OrganizationPartRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public IQueryable<OrganizationPart> Query()
        {
            return _context.OrganizationParts.AsNoTracking();
        }

        public OrganizationPart Query(int id)
        {
            return _context.OrganizationParts
                .AsNoTracking()
                .Include(x => x.ControlMethod)
                .Include(x => x.Characteristics)
                .FirstOrDefault(x => x.OrganizationPartId == id);
        }

        public Task<List<OrganizationPart>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrganizationPart> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<OrganizationPart> Create(OrganizationPart data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.OrganizationParts.AddAsync(data).ConfigureAwait(false);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public virtual async Task<OrganizationPart> Update(OrganizationPart data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.OrganizationParts.Update(data);
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return data;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> Delete(int id)
        {
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.OrganizationParts.Remove(new OrganizationPart { OrganizationPartId = id });
                await _context.SaveChangesAsync().ConfigureAwait(false);
                await transaction.CommitAsync().ConfigureAwait(false);
                return true;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync().ConfigureAwait(false);
                throw new Exception(e.Message);
            }
        }

        public async Task<bool> IsPartExist(string leftHand, string rightHand)
        {
            return await _context.OrganizationParts
                .AnyAsync(x => x.LeftHandPart == leftHand.Trim() && x.RightHandPart == rightHand.Trim()).ConfigureAwait(false);
        }
    }
}
