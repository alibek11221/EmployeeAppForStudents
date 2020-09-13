using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Data;
using EmployeeAppWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApi.Services
{
    public class UnitService : IUnitService
    {
        private readonly DataContext _dataContext;

        public UnitService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Unit>> GetUnitsAsync(CancellationToken cancellationToken)
        {
            return await _dataContext.Units.ToListAsync(cancellationToken);
        }

        public async Task<Unit> GetUnitByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dataContext.Units.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<bool> UpdateUnitAsync(Unit unitToUpdate, CancellationToken cancellationToken)
        {
            _dataContext.Units.Update(unitToUpdate);
            var updated = await _dataContext.SaveChangesAsync(cancellationToken);
            return updated > 0;
        }

        public async Task<bool> DeleteUnitAsync(Guid id, CancellationToken cancellationToken)
        {
            var unit = await GetUnitByIdAsync(id, cancellationToken);
            if (unit == null)
            {
                return false;
            }

            _dataContext.Units.Remove(unit);
            var deleted = await _dataContext.SaveChangesAsync(cancellationToken);
            return deleted > 0;
        }

        public async Task<Unit> CreateUnitAsync(Unit unit, CancellationToken cancellationToken)
        {
            await _dataContext.Units.AddAsync(unit, cancellationToken);
            await _dataContext.SaveChangesAsync(cancellationToken);
            return unit;
        }
    }
}