using System;
using System.Collections.Generic;
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

        public async Task<List<Unit>> GetUnitsAsync()
        {
            return await _dataContext.Units.ToListAsync();
        }

        public async Task<Unit> GetUnitByIdAsync(Guid id)
        {
            return await _dataContext.Units.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<bool> UpdateUnitAsync(Unit unitToUpdate)
        {
            _dataContext.Units.Update(unitToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteUnitAsync(Guid id)
        {
            var unit = await GetUnitByIdAsync(id);
            if (unit == null)
            {
                return false;
            }

            _dataContext.Units.Remove(unit);
            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<bool> CreateUnitAsync(Unit unit)
        {
            await _dataContext.Units.AddAsync(unit);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }
    }
}