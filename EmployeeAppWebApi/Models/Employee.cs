using System;
using System.Collections.Generic;

namespace EmployeeAppWebApi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornYear { get; set; }
        public bool Gender { get; set; }
        public bool IsMaried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; } = 0;
        public Unit Unit { get; set; }
        public Position Position { get; set; }
        public List<Payment> Payments { get; set; }
    }
}