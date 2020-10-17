using System.Collections.Generic;
using EmployeeApp.Domain.Common;

namespace EmployeeApp.Domain.Entities
{
    public class Department : AuditableEntity
    {
        public Department()
        {
            Positions = new List<Position>();
            Employees = new List<Employee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Position> Positions { get; set; }
        public List<Employee> Employees { get; set; }
    }
}