using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi.Services
{
    public interface IUnitService
    {
        Task<List<Unit>> GetUnitsAsync(CancellationToken cancellationToken);
        Task<Unit> GetUnitByIdAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> UpdateUnitAsync(Unit unitToUpdate, CancellationToken cancellationToken);
        Task<bool> DeleteUnitAsync(Guid id, CancellationToken cancellationToken);
        Task<Unit> CreateUnitAsync(Unit unit, CancellationToken cancellationToken);
    }
}