using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppWebApi.Models
{
    public class Unit
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<Position> Positions { get; set; }
    }
}