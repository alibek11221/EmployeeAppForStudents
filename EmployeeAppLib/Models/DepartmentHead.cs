using EmployeeAppLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAppLib.Models
{
    public class DepartmentHead : EmployeeModel, ISalary, IBonus
    {
        public decimal Bonus { get; set; }
        public void GetBonus(Bonuses bonus)
        {
            switch (bonus)
            {
                case Bonuses.Double:
                    Bonus = Position.DayliSalary * 2;
                    break;
                case Bonuses.Half:
                    Bonus = Position.DayliSalary * 0.5M;
                    break;
                case Bonuses.Quarter:
                    Bonus = Position.DayliSalary * 0.25M;
                    break;
                default:
                    Bonus = 0;
                    break;
            }
        }

        public decimal GetSalary(DateTime begin, DateTime end)
        {
            return Position.DayliSalary + Bonus * 0.13M;
        }

    }
}
