using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using EmployeeAppLib.Models;

namespace EmployeeAppLib.Sql
{
    public sealed class EmployeeAppContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }
        public DbSet<PositionModel> Positions { get; set; }
        public DbSet<PaymentModel> Payments { get; set; }
        public DbSet<UnitModel> Units { get; set; }

        public  EmployeeAppContext(DbContextOptions<EmployeeAppContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitModel>()
                .HasMany(u => u.Employees)
                .WithOne(e => e.Unit)
                .HasForeignKey(c => c.UnitId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<UnitModel>()
                .HasMany(u => u.Positions)
                .WithOne(p => p.Unit)
                .HasForeignKey(k => k.UnitId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeModel>()
                .HasOne(p => p.Position)
                .WithOne(e => e.Employee)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<EmployeeModel>()
                .HasMany(e => e.Payments)
                .WithOne(p => p.Employee)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
