using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAppLib.Interfaces
{
    public interface ISalary
    {
        decimal GetSalary(DateTime begin, DateTime end);
    }
}
