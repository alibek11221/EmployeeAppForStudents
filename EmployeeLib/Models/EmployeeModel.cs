﻿using EmployeeLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Models
{
    public  class EmployeeModel 
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BornYear { get; set; }
        public bool Gender { get; set; }
        public bool IsMaried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; } = 0;
        public int UnitId { get; set; }
        public int PositionId { get; set; }
        public PositionModel Position { get; set; }
        public UnitModel Unit { get; set; }
    }

}