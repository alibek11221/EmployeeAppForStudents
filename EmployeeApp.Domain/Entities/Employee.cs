using System;
using System.Collections.Generic;
using EmployeeApp.Domain.Common;
using EmployeeApp.Domain.Enums;

namespace EmployeeApp.Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            PaymentChecks = new List<PaymentCheck>();
        }
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public int PositionId { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }
        public bool IsMarried { get; set; }
        public bool HasKids { get; set; }
        public int AmountOfKids { get; set; }
        public Position Position { get; set; }
        public Department Department { get; set; }
        public List<PaymentCheck> PaymentChecks { get; set; }
    }
}