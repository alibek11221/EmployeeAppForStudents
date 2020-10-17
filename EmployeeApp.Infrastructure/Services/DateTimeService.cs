using System;
using EmployeeApp.Application.Common.Interfaces;

namespace EmployeeApp.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}