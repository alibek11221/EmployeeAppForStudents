using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppWebApiDataBaseLibrary.Models
{
    public class Employee : IDateTrackable
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