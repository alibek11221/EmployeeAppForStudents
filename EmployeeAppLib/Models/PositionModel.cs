using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppLib.Models
{
    public class PositionModel
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DayliSalary { get; set; }
        public int UnitID { get; set; }
        public UnitModel Unit { get; set; }
        public EmployeeModel Employee { get; set; }
    }
}
