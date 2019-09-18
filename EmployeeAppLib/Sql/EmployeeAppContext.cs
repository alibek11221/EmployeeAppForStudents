using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using EmployeeAppLib.Models;

namespace EmployeeLib.Sql
{
    public class EmployeeAppContext : DbContext
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
    }
}
