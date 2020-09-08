using System.Collections.Generic;

namespace EmployeeAppWebApi.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public List<Position> Positions { get; set; }
        public List<Employee> Employees { get; set; }
    }
}