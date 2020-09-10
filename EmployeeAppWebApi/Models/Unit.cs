using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppWebApi.Models
{
    public class Unit
    {
        [Key]
        public Guid Id { get; set; }
        public string UnitName { get; set; }
        public List<Position> Positions { get; set; }
        public List<Employee> Employees { get; set; }
    }
}