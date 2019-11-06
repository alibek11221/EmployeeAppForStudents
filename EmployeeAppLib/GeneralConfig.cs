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
                //Добавить в список сотрудников
                await Db.Employees.AddAsync(employee);
                //Сохранить изменения
                await Db.SaveChangesAsync();
            }
        }
        public async static Task AddUnit(this UnitModel unit)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                //Добавить в список должностей
                await Db.Units.AddAsync(unit);
                //Сохранить изменения
                await Db.SaveChangesAsync();
            }
        }
        public async static Task AddPosition(this PositionModel position)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                //Добавить в список должностей
                await Db.Positions.AddAsync(position);
                //Сохранить изменения
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

        /// <summary>
        /// Метод для получения сотрудников конкретного отдела с данными о его должности
        /// </summary>
        /// <param name="employees">Контейнер</param>
        /// <param name="id">Id отдела в базе данных</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public async static Task<List<EmployeeModel>> GetEmployeesWithPosititon(this List<EmployeeModel> employees, int id)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                employees = await Db.Employees.Where(e => e.UnitId == id).Include(e => e.Position).ToListAsync();
            }
            return employees;
        }

        /// <summary>
        /// Метод для получения списка отделов из базы и сохранения их в контейнере
        /// </summary>
        /// <param name="units">Пустой контейнер</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public async static Task<List<UnitModel>> GetAllUnits(this List<UnitModel> units)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                units = await Db.Units.ToListAsync();
            }
            return units;
        }
        /// <summary>
        /// Метод для получения списка отделов с должностями из базы и сохранения их в контейнере
        /// </summary>
        /// <param name="units">Пустой контейнер</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public async static Task<List<UnitModel>> GetAllUnitsWithPositions(this List<UnitModel> output)
        {
             //= new List<UnitModel>();
            using (Db = new EmployeeAppContext(Options))
            {
                 output =  await Db.Units.Include(u => u.Positions).ToListAsync();
            }
            return output;
        }

        /// <summary>
        /// Метод для получения списка должностей для конкретного отдела из базы и сохранения их в контейнере
        /// </summary>
        /// <param name="positions">Контейнер для списка должностей</param>
        /// <param name="unit">Конкретный отдел</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
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
