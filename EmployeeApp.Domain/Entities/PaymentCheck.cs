using System;

namespace EmployeeApp.Domain.Entities
{
    public class PaymentCheck
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PaymentDate { get; set; }
        public Employee Employee { get; set; }
    }
}