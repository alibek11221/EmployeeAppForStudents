using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApi.Models
{
    public class Position 
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "money")] public decimal DailySalary { get; set; }
        public Guid EmployeeId { get; set; }
        public Unit Unit { get; set; }
        public Employee Employee { get; set; }
    }
}