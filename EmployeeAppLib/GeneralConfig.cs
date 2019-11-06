using EmployeeAppLib.Models;
using EmployeeAppLib.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAppLib
{
    public static class GeneralConfig
    {
        private static string cnnString;
        private static EmployeeAppContext Db;
        private static readonly DbContextOptionsBuilder<EmployeeAppContext> OptionsBuilder = new DbContextOptionsBuilder<EmployeeAppContext>();
        private static DbContextOptions<EmployeeAppContext> Options;
        
        public static void SetCnnString(string name)
        {
            cnnString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            Options = OptionsBuilder.UseSqlServer(cnnString).Options;
            Db = new EmployeeAppContext(Options);
        }

        public async static Task AddEmployee(this EmployeeModel employee)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                await Db.Employees.AddAsync(employee);
                await Db.SaveChangesAsync();
            }
        }
        public async static Task AddUnit(this UnitModel unit)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                await Db.Units.AddAsync(unit);
                await Db.SaveChangesAsync();
            }
        }
        public async static Task AddPosition(this PositionModel position)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                await Db.Positions.AddAsync(position);
                await Db.SaveChangesAsync();
            }
        }
        public async static Task AddPayment(this PaymentModel payment)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                await  Db.Payments.AddAsync(payment);
                await Db.SaveChangesAsync();
            }
        }

        public async static Task<List<EmployeeModel>> GetEmployeesWithPosititon(this List<EmployeeModel> employees, int id)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                employees = await Db.Employees.Where(e => e.UnitId == id).Include(e => e.Position).ToListAsync();
            }
            return employees;
        }

        public async static Task<List<UnitModel>> GetAllUnits(this List<UnitModel> units)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                units = await Db.Units.ToListAsync();
            }
            return units;
        }
       
        public async static Task<List<UnitModel>> GetAllUnitsWithPositions(this List<UnitModel> output)
        {
             //= new List<UnitModel>();
            using (Db = new EmployeeAppContext(Options))
            {
                 output =  await Db.Units.Include(u => u.Positions).ToListAsync();
            }
            return output;
        }

        public static List<PositionModel> GetPositionByUnit(this List<PositionModel> positions, UnitModel unit)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                foreach (PositionModel position in unit.Positions)
                {
                    positions.Add(position);
                }
            }
            return positions;
        }
    }
}
