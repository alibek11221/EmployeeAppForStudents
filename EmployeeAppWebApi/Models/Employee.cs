﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAppWebApi.Models
{
    public class Employee
    {
        [Key] public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornYear { get; set; }
        public bool Gender { get; set; }
        public bool IsMarried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; } = 0;
        public Unit Unit { get; set; }
        public Position Position { get; set; }
        public List<Payment> Payments { get; set; }
    }
}