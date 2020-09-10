﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppWebApi.Models
{
    public class Position
    {
        [Key] 
        public Guid Id { get; set; }
        public string PositionName { get; set; }
        [Column(TypeName = "money")]
        public decimal DailySalary { get; set; }
        public Guid EmployeeId { get; set; }
        public Unit Unit { get; set; }
        public Employee Employee { get; set; }
    }
}