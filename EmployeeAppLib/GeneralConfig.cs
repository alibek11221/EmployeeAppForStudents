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
        
        public static void Add<T>(T data) where T : DbSet<T>
        {
            using (Db = new EmployeeAppContext(Options))
            {
                Db.
            }
        }
        public static void AddEmployee(this EmployeeModel employee)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                //Добавить в список сотрудников
                Db.Employees.Add(employee);
                //Сохранить изменения
                Db.SaveChanges();
            }
        }
        public static void AddPosition(this PositionModel position)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                //Добавить в список должностей
                Db.Positions.Add(position);
                //Сохранить изменения
                Db.SaveChanges();
            }
        }
        public static void AddPayment(this PaymentModel payment)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                Db.Payments.Add(payment);
                Db.SaveChanges();
            }
        }

        /// <summary>
        /// Метод для получения сотрудников конкретного отдела с данными о его должности
        /// </summary>
        /// <param name="employees">Контейнер</param>
        /// <param name="id">Id отдела в базе данных</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public static List<EmployeeModel> GetEmployeesWithPosititon(this List<EmployeeModel> employees, int id)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                employees = Db.Employees.Where(e => e.UnitId == id).Include(e => e.Position).ToList();
            }
            return employees;
        }

        /// <summary>
        /// Метод для получения списка отделов из базы и сохранения их в контейнере
        /// </summary>
        /// <param name="units">Пустой контейнер</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public static List<UnitModel> GetAllUnits(this List<UnitModel> units)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                units = Db.Units.ToList();
            }
            return units;
        }
        /// <summary>
        /// Метод для получения списка отделов с должностями из базы и сохранения их в контейнере
        /// </summary>
        /// <param name="units">Пустой контейнер</param>
        /// <returns>Контейнер заполненный данными из базы данных</returns>
        public static List<UnitModel> GetAllUnitsWithPositions(this List<UnitModel> output)
        {
             //= new List<UnitModel>();
            using (Db = new EmployeeAppContext(Options))
            {
                 output =  Db.Units.Include(u => u.Positions).ToList();
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
