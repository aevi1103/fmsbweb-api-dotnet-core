﻿using System;
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
    public class CharacteristicRepository : ICharacteristicRepository
    {
        private readonly QualityCheckSheetsContext _context;

        public CharacteristicRepository(QualityCheckSheetsContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IQueryable<Characteristic> Query()
        {
            return _context.Characteristics.AsNoTracking();
        }

        public Characteristic Query(int id)
        {
            return _context.Characteristics.AsNoTracking()
                .Include(x => x.OrganizationPart)
                .Include(x => x.DisplayAs)
                .FirstOrDefault(x => x.CharacteristicId == id);
        }

        public Task<List<Characteristic>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Characteristic> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Characteristic> Create(Characteristic data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                await _context.Characteristics.AddAsync(data).ConfigureAwait(false);
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

        public async Task<Characteristic> Update(Characteristic data)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            await using var transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
            try
            {
                _context.Characteristics.Update(data);
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
                _context.Characteristics.Remove(new Characteristic { CharacteristicId = id});
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
    }
}
