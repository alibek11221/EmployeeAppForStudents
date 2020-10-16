using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EmployeeAppWebApiDataBaseLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApiDataBaseLibrary.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IDateTrackable &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified))
                .ToList();
            entries.ForEach(x =>
            {
                ((IDateTrackable) x.Entity).UpdatedAt = DateTime.Now;
                if (x.State == EntityState.Added)
                    ((IDateTrackable) x.Entity).CreatedAt = DateTime.Now;
            });
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}