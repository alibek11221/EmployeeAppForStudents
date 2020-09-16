using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EmployeeAppWebApi.Data;
using EmployeeAppWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApi.Services
{
    public class PositionService : IPositionService
    {
        private readonly DataContext _dataContext;

        public PositionService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Position>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dataContext.Positions.ToListAsync(cancellationToken);
        }

        public Task<Position> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Position entityToUpdate, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Position> CreateAsync(Position entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}