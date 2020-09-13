using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppWebApi.Models
{
    public class Position : IDateModel
    {
        [Key] 
        public Guid Id { get; set; }
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        [Column(TypeName = "money")] 
        public decimal DailySalary { get; set; }

        public Guid EmployeeId { get; set; }
        public Unit Unit { get; set; }
        public Employee Employee { get; set; }
    }
}