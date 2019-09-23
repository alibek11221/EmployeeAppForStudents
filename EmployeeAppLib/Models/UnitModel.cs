using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeAppLib.Models
{
    public class UnitModel
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public List<PositionModel> Positions { get; set; }
        public List<EmployeeModel> Employees { get; set; }
    }
}
