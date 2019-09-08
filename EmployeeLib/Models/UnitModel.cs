using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Models
{
    public class UnitModel
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public List<EmployeeModel> Employees { get; set; }

    }
}
