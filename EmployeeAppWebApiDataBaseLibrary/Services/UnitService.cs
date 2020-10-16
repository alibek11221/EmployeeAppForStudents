using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApiDataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApiDataBaseLibrary.Services
{
    public class UnitService : IUnitService
    {
        private readonly DataContext.DataContext _dataContext;

        public UnitService(DataContext.DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Unit>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dataContext.Units.ToListAsync(cancellationToken);
        }

        public async Task<Unit> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var unit = await _dataContext.Units.FirstOrDefaultAsync(x => id.Equals(x.Id), cancellationToken);
            return unit;
        }

        public async Task<bool> UpdateAsync(Unit unitToUpdate, CancellationToken cancellationToken)
        {
            _dataContext.Units.Update(unitToUpdate);
            var updated = await _dataContext.SaveChangesAsync(cancellationToken);
            return updated > 0;
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var unit = await GetByIdAsync(id, cancellationToken);
            if (unit == null)
            {
                return false;
            }

            _dataContext.Units.Remove(unit);
            var deleted = await _dataContext.SaveChangesAsync(cancellationToken);
            return deleted > 0;
        }

        public async Task<Unit> CreateAsync(Unit unit, CancellationToken cancellationToken)
        {
            await _dataContext.Units.AddAsync(unit, cancellationToken);
            await _dataContext.SaveChangesAsync(cancellationToken);
            return unit;
        }
    }
}