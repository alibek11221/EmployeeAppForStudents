using EmployeeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Models
{
    public class DepartmentHead : EmployeeModel, ISalary, IBonus
    {
        public decimal Bonus { get; set; }
        public void GetBonus(Bonuses bonus)
        {
            switch (bonus)
            {
                case Bonuses.Double:
                    Bonus = Position.HourSalary * 2;
                    break;
                case Bonuses.Half:
                    Bonus = Position.HourSalary * 0.5M;
                    break;
                case Bonuses.Quarter:
                    Bonus = Position.HourSalary * 0.25M;
                    break;
                default:
                    Bonus = 0;
                    break;
            }
        }

        public decimal GetSalary(DateTime begin, DateTime end)
        {
            return Position.HourSalary + Bonus * 0.13M;
        }

    }
}
