using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppWebApi.Models
{
    public class Employee : IDateModel
    {
        [Key] public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornYear { get; set; }
        public bool Gender { get; set; }
        public bool IsMarried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; } = 0;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Unit Unit { get; set; }
        public Position Position { get; set; }
        public List<Payment> Payments { get; set; }
    }
}