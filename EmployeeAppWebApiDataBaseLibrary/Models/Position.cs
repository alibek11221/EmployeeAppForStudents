using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppWebApiDataBaseLibrary.Models
{
    public class Position : IDateTrackable
    {
        [Key] public Guid Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "money")] public decimal DailySalary { get; set; }
        public Guid EmployeeId { get; set; }
        public Unit Unit { get; set; }
        public Employee Employee { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}