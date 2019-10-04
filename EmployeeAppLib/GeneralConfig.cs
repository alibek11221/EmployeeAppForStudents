using EmployeeAppLib.Models;
using EmployeeLib.Sql;
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
        private static DbContextOptionsBuilder<EmployeeAppContext> OptionsBuilder = new DbContextOptionsBuilder<EmployeeAppContext>();
        private static DbContextOptions<EmployeeAppContext> Options;
        public static EmployeeAppContext GetDb()
        {
            return Db;
        }
        public static string GetCnnString()
        {
            return cnnString;
        }

        public static void SetCnnString(string name)
        {
            cnnString = ConfigurationManager.ConnectionStrings[name].ConnectionString;
            Options = OptionsBuilder.UseSqlServer(cnnString).Options;
            Db = new EmployeeAppContext(Options);
        }
        
        public static void AddUnit(this UnitModel unit)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                Db.Units.Add(unit);
                Db.SaveChanges();
            }
        }
        public static void AddEmployee(this EmployeeModel employee)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                Db.Employees.Add(employee);
                Db.SaveChanges();
            }
        }
        public static void AddPosition(this PositionModel position)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                Db.Positions.Add(position);
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
        public static List<UnitModel> GetAllUnitsWithEmployees(this List<UnitModel> units)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                units = Db.Units
                    .Include(u => u.Employees)
                    .ToList();
            }
            return units;
        }
        public static void RemovePosition(this PositionModel position)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                Db.Positions.Remove(position);
                Db.SaveChanges();
            }
        }
        public static void RemoveUnit(this UnitModel unit)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                Db.Units.Remove(unit);
                Db.SaveChanges();
            }
        }
        public static void RemoveEmployee(this EmployeeModel model)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                Db.Employees.Remove(model);
                Db.SaveChanges();
            }
        }
        public static List<EmployeeModel> GetEmployeesWithPosititon(this List<EmployeeModel> employees, int id)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                employees = Db.Employees.Where(e => e.UnitId == id).Include(e => e.Position).ToList();
            }
            return employees;
        }
        public static List<UnitModel> GetAllUnits(this List<UnitModel> units)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                units = Db.Units.ToList();
            }
            return units;
        }
        public static List<UnitModel> GetAllUnitsWithPositions(this List<UnitModel> units)
        {
            using (Db = new EmployeeAppContext(Options))
            {
                units = Db.Units.Include(u => u.Positions).ToList();
            }
            return units;
        }
        public static List<PositionModel> GetAllPositions(this List<PositionModel> positions)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                foreach (PositionModel position in Db.Positions)
                {
                    positions.Add(position);
                }
            }
            return positions;
        }
        public static List<EmployeeModel> GetAllEmployees(this List<EmployeeModel> employees)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                foreach (EmployeeModel employee in Db.Employees)
                {
                    employees.Add(employee);
                }
            }
            return employees;
        }
        public static List<PaymentModel> GetAllPayments(this List<PaymentModel> payments)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                return Db.Payments.ToList();
            }
        }
        public static List<PositionModel> GetPOsitionByUnit(this List<PositionModel> positions, UnitModel unit)
        {
            using(Db = new EmployeeAppContext(Options))
            {
                foreach (PositionModel _position in unit.Positions)
                {
                    positions.Add(_position);
                }
            }
            return positions;
        }
    }
}
