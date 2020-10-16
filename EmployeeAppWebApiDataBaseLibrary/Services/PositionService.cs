using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApiDataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApiDataBaseLibrary.Services
{
    public class PositionService : IPositionService
    {
        private readonly DataContext.DataContext _dataContext;

        public PositionService(DataContext.DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Position>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dataContext.Positions.ToListAsync(cancellationToken);
        }

        public async Task<Position> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _dataContext.Positions.FindAsync(id, cancellationToken);
        }

        public async Task<bool> UpdateAsync(Position entityToUpdate, CancellationToken cancellationToken)
        {
            _dataContext.Positions.Update(entityToUpdate);
            var updated = await _dataContext.SaveChangesAsync(cancellationToken);
            return updated > 0;
        }

        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            var position = await GetByIdAsync(id, cancellationToken);
            if (position == null)
            {
                return false;
            }

            _dataContext.Positions.Remove(position);
            var deleted = await _dataContext.SaveChangesAsync(cancellationToken);
            return deleted > 0;
        }

        public async Task<Position> CreateAsync(Position entity, CancellationToken cancellationToken)
        {
            await _dataContext.Positions.AddAsync(entity, cancellationToken);
            await _dataContext.SaveChangesAsync(cancellationToken);
            return entity;
        }
    }
}