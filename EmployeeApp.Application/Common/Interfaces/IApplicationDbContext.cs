using System.Threading;
using System.Threading.Tasks;
using EmployeeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PaymentCheck> PaymentChecks { get; set; }
        public DbSet<Position> Positions { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}