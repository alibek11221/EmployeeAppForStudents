using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Models
{
    public class PositionModel
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int HourSalary { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}
