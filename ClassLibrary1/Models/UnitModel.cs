using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAppLib.Models
{
    public class UnitModel
    {
        public int Id { get; set; }
        public string UnitName { get; set; }
        public List<EmployeeModel> Employees { get; set; }

    }
}
