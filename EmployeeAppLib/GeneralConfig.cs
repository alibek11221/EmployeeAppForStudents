using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using EmployeeAppLib.Models;
using EmployeeAppLib.Sql;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppLib
{
    public static class GeneralConfig
    {
        private static string _cnnString;
        private static EmployeeAppContext _db;

        private static readonly DbContextOptionsBuilder<EmployeeAppContext> OptionsBuilder =
            new DbContextOptionsBuilder<EmployeeAppContext>();

        private static DbContextOptions<EmployeeAppContext> _options;

        public static void SetCnnString(string name)
        {
            _cnnString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            _options = OptionsBuilder.UseSqlServer(_cnnString).Options;
            _db = new EmployeeAppContext(_options);
        }

        public static async Task AddEmployee(this EmployeeModel employee)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                await _db.Employees.AddAsync(employee);
                await _db.SaveChangesAsync();
            }
        }

        public static async Task AddUnit(this UnitModel unit)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                await _db.Units.AddAsync(unit);
                await _db.SaveChangesAsync();
            }
        }

        public static async Task AddPosition(this PositionModel position)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                await _db.Positions.AddAsync(position);
                await _db.SaveChangesAsync();
            }
        }

        public static async Task AddPayment(this PaymentModel payment)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                await _db.Payments.AddAsync(payment);
                await _db.SaveChangesAsync();
            }
        }

        public static async Task<List<EmployeeModel>> GetEmployeesWithPosititon(this List<EmployeeModel> employees,
            int id)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                employees = await _db.Employees.Where(e => e.UnitId == id).Include(e => e.Position).ToListAsync();
            }

            return employees;
        }

        public static async Task<List<UnitModel>> GetAllUnits(this List<UnitModel> units)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                units = await _db.Units.ToListAsync();
            }

            return units;
        }

        public static async Task<List<UnitModel>> GetAllUnitsWithPositions(this List<UnitModel> output)
        {
            //= new List<UnitModel>();
            using (_db = new EmployeeAppContext(_options))
            {
                output = await _db.Units.Include(u => u.Positions).ToListAsync();
            }

            return output;
        }

        public static List<PositionModel> GetPositionByUnit(this List<PositionModel> positions, UnitModel unit)
        {
            using (_db = new EmployeeAppContext(_options))
            {
                positions.AddRange(unit.Positions);
            }

            return positions;
        }
    }
}