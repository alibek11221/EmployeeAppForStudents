using System;
using System.Linq;
using EmployeeAppWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApi.Data
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

        public override int SaveChanges()
        {
            var entries = ChangeTracker
                .Entries()
                .Where(e => e.Entity is IDateModel &&
                            (e.State == EntityState.Added || e.State == EntityState.Modified))
                .ToList();
            entries.ForEach(x =>
            {
                ((IDateModel) x.Entity).UpdatedAt = DateTime.Now;
                if (x.State == EntityState.Added)
                    ((IDateModel) x.Entity).CreatedAt = DateTime.Now;
            });

            return base.SaveChanges();
        }
    }
}