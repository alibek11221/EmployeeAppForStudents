using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLib.Interfaces
{
    public interface ISalary
    {
        decimal GetSalary(DateTime begin, DateTime end);
    }
}
