using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EmployeeAppWebApi.Models;

namespace EmployeeAppWebApi.Services
{
    public interface IUnitService
    {
        Task<List<Unit>> GetUnitsAsync();
        Task<Unit> GetUnitByIdAsync(Guid id);
        Task<bool> UpdateUnitAsync(Unit unitToUpdate);
        Task<bool> DeleteUnitAsync(Guid id);
        Task<bool> CreateUnitAsync(Unit unit);
    }
}